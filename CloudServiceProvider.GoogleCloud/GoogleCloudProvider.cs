using System;
using System.IO;

namespace CloudServiceProvider.GoogleCloud {
    public class GoogleCloudProvider : ICloudProvider {
        public UserAccountController UserAccountController { get; set; }

        public GoogleCloudProvider(UserAccountController userAccountController) {
            UserAccountController = userAccountController;
        }

        public void Update(IAccount account, UploadFileRequest uploadFileRequest) {
            UserAccount userAccount = UserAccountController.AuthorizeUser(account);
            if (userAccount == null || !userAccount.Authorized) uploadFileRequest.Progress.Report(ByteProgressReport.Error);

            try {
                string cloudObjectPath = CreateValidPath(Path.Combine(userAccount.Credentials.FolderName, uploadFileRequest.CloudObjectPath));

                Google.Apis.Storage.v1.Data.Object obj = new Google.Apis.Storage.v1.Data.Object();
                obj.Bucket = userAccount.Credentials.AccountCredentials.BucketName;
                obj.Name = cloudObjectPath;

                uploadFileRequest.InputStream.Position = 0;

                UploadProgressAdapter progressAdapter = new UploadProgressAdapter(uploadFileRequest.Progress, uploadFileRequest.InputStream.Length);
                var uploadedObject = userAccount.StorageClient.UploadObject(obj, uploadFileRequest.InputStream, null, progressAdapter);

                if (uploadFileRequest.ShareLink) uploadFileRequest.SharedLink = uploadedObject.MediaLink;
            } catch (Exception e) {
                RequestStatus error = RequestStatus.OtherError;

                if (e is System.Net.Http.HttpRequestException) {
                    error = RequestStatus.NoInternetConnection;
                }

                uploadFileRequest.Progress.Report(ByteProgressReport.FromError(e, error));
            }
        }
        public void Download(IAccount account, DownloadFileRequest downloadFileRequest) {
            UserAccount userAccount = UserAccountController.AuthorizeUser(account);
            if (userAccount == null || !userAccount.Authorized) downloadFileRequest.Progress.Report(ByteProgressReport.Error);

            try {
                string cloudObjectPath = CreateValidPath(Path.Combine(userAccount.Credentials.FolderName, downloadFileRequest.CloudObjectPath));

                Google.Apis.Storage.v1.Data.Object obj = userAccount.StorageClient.GetObject(userAccount.Credentials.AccountCredentials.BucketName, cloudObjectPath);

                DownloadProgressAdapter progressAdapter = new DownloadProgressAdapter(downloadFileRequest.Progress, (long)obj.Size);
                userAccount.StorageClient.DownloadObject(obj, downloadFileRequest.OutputStream, null, progressAdapter);
            } catch (Exception e) {
                RequestStatus error = RequestStatus.OtherError;

                if (e is System.Net.Http.HttpRequestException) {
                    error = RequestStatus.NoInternetConnection;
                } else if (e is Google.GoogleApiException apiExcepion && apiExcepion.HttpStatusCode == System.Net.HttpStatusCode.NotFound) {
                    error = RequestStatus.FileNotFound;
                }

                downloadFileRequest.Progress.Report(ByteProgressReport.FromError(e, error));
            }
        }
        public RequestStatus Delete(IAccount account, ObjectRequest objectRequest) {
            UserAccount userAccount = UserAccountController.AuthorizeUser(account);
            if (userAccount == null || !userAccount.Authorized) return RequestStatus.OtherError;

            try {
                string cloudObjectPath = CreateValidPath(Path.Combine(userAccount.Credentials.FolderName, objectRequest.CloudObjectPath));

                userAccount.StorageClient.DeleteObject(userAccount.Credentials.AccountCredentials.BucketName, cloudObjectPath);

                return RequestStatus.Successfull;
            } catch (Exception e) {
                RequestStatus error = RequestStatus.OtherError;

                if (e is System.Net.Http.HttpRequestException) {
                    error = RequestStatus.NoInternetConnection;
                } else if (e is Google.GoogleApiException apiExcepion && apiExcepion.HttpStatusCode == System.Net.HttpStatusCode.NotFound) {
                    error = RequestStatus.FileNotFound;
                }

                return error;
            }
        }

        private static string CreateValidPath(string path) {
            return path.Replace("\\", "/");
        }
    }
}
