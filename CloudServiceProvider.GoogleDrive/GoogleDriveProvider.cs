using System;
using System.Collections.Generic;
using System.IO;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;

namespace CloudServiceProvider.GoogleDrive {
    public class GoogleDriveProvider : ICloudProvider {
        public ProviderApplication Application { get; set; }

        public GoogleDriveProvider(ProviderApplication application) {
            Application = application;
        }

        public void Update(IAccount account, UploadFileRequest uploadFileRequest) {
            uploadFileRequest.Progress.Report(new ByteProgressReport(RequestStatus.InProgress, 0));
            UserAccount userAccount = Application.AccountController.AuthorizeUser(account);

            string cloudObjectPath = Path.Combine("GoogleDriveBackup", uploadFileRequest.CloudObjectPath);

            FolderUtilities utilities = new FolderUtilities(userAccount, Application.FolderCache);

            Application.FolderCache.ApplyUpdateMode();
            string parentId = utilities.GetFolderId(Path.GetDirectoryName(cloudObjectPath));
            Application.FolderCache.SuspendUpdateMode();

            Google.Apis.Drive.v3.Data.File body = new Google.Apis.Drive.v3.Data.File() {
                Name = Path.GetFileName(uploadFileRequest.CloudObjectPath),
                MimeType = MimeType.GetFileMimeType(Path.GetExtension(cloudObjectPath).Replace(".", ""))
            };

            if (Application.FileCache.TryGetId(account.Email, cloudObjectPath, out string id)) {
                FilesResource.UpdateMediaUpload response = userAccount.DriveService.Files.Update(body, id, uploadFileRequest.InputStream, body.MimeType);

                new UploadProgressIntercepter(uploadFileRequest.Progress, response, uploadFileRequest.InputStream.Length);
                response.Upload();
            } else {
                if (!string.IsNullOrEmpty(parentId)) {
                    body.Parents = new List<string>() { parentId };
                }

                FilesResource.CreateMediaUpload response = userAccount.DriveService.Files.Create(body, uploadFileRequest.InputStream, body.MimeType);

                new UploadProgressIntercepter(uploadFileRequest.Progress, response, uploadFileRequest.InputStream.Length);
                response.Upload();

                id = response.ResponseBody.Id;
                Application.FileCache.SetId(account.Email, cloudObjectPath, id);
            }

            if (uploadFileRequest.ShareLink) uploadFileRequest.SharedLink = ShareFile(userAccount, id);
        }
        private static string ShareFile(UserAccount userAccount, string id) {
            FilesResource.GetRequest request = userAccount.DriveService.Files.Get(id);
            request.Fields = "permissions,webViewLink";
            var file = request.Execute();

            if (!IsFileShared(file.Permissions)) {
                Permission permission = new Permission() {
                    Type = "anyone",
                    Role = "reader"
                };

                userAccount.DriveService.Permissions.Create(permission, id).Execute();
            }

            return file.WebViewLink ?? "";
        }
        private static bool IsFileShared(IList<Permission> permissions) {
            foreach (var permission in permissions) {
                if (permission.Type == "anyone" && permission.Role == "reader") return true;
            }

            return false;
        }

        public void Download(IAccount account, DownloadFileRequest downloadFileRequest) {
            string cloudObjectPath = Path.Combine("GoogleDriveBackup", downloadFileRequest.CloudObjectPath);

            if (Application.FileCache.TryGetId(account.Email, cloudObjectPath, out string id)) {
                UserAccount userAccount = Application.AccountController.AuthorizeUser(account);

                Output<bool> output = Exists(userAccount, id);
                if (output.Certainty == Certainty.Uncertain) {
                    ThrowStandardError();
                }

                if (output.Value) {
                    var sizeRequest = userAccount.DriveService.Files.Get(id);
                    sizeRequest.Fields = "size";
                    long size = sizeRequest.Execute().Size.Value;

                    FilesResource.GetRequest downloadRequest = userAccount.DriveService.Files.Get(id);
                    
                    new DownloadProgressInterepter(downloadFileRequest.Progress, downloadRequest.MediaDownloader, size);
                    downloadRequest.DownloadWithStatus(downloadFileRequest.OutputStream);

                    return;
                } else {
                    Application.FileCache.RemoveId(account.Email, cloudObjectPath);
                }
            }

            ThrowFileNotFoundError();
        }

        public RequestStatus Delete(IAccount account, ObjectRequest objectRequest) {
            string cloudObjectPath = Path.Combine("GoogleDriveBackup", objectRequest.CloudObjectPath);

            IdCacheCatalog idCache = objectRequest.ObjectType == ObjectType.File ? Application.FileCache : Application.FolderCache;

            if (idCache.TryGetId(account.Email, cloudObjectPath, out string id)) {
                UserAccount userAccount = Application.AccountController.AuthorizeUser(account);

                Output<bool> output = Exists(userAccount, id);
                if (output.Certainty == Certainty.Uncertain) {
                    ThrowStandardError();
                    return RequestStatus.OtherError;
                }

                if (output.Value) {
                    userAccount.DriveService.Files.Delete(id).Execute();
                }

                idCache.RemoveId(account.Email, cloudObjectPath);
            } else {
                ThrowFileNotFoundError();
                return RequestStatus.OtherError;
            }

            return RequestStatus.Successfull;
        }

        private static Output<bool> Exists(UserAccount userAccount, string id) {
            try {
                FilesResource.GetRequest request = userAccount.DriveService.Files.Get(id);
                request.Fields = "";
                var file = request.Execute();

                return new Output<bool>(true, Certainty.Certain);
            } catch (Google.GoogleApiException e) {
                if (e.Error.Code == 404) return new Output<bool>(false, Certainty.Certain);

                return new Output<bool>(false, Certainty.Uncertain);
            }
        }

        internal static void ThrowStandardError() {
            throw new Exception("Google Drive | An error occured.");
        }
        internal static void ThrowFileNotFoundError() {
            throw new Exception("File has not been found on Google Drive.");
        }
    }
}
