using System;
using System.Collections.Generic;
using System.IO;
using Google.Apis.Drive.v3;

namespace CloudServiceProvider.GoogleDrive {
    public class FolderUtilities {
        public UserAccount UserAccount { get; set; }
        public IdCacheCatalog FolderIDs { get; set; }

        public FolderUtilities(UserAccount account, IdCacheCatalog folderIDs) {
            UserAccount = account;
            FolderIDs = folderIDs;
        }

        public string GetFolderId(string path) {
            if (string.IsNullOrEmpty(path)) return "";
            if (FolderIDs.TryGetId(UserAccount.Account.Email, path, out string id)) {
                Output<bool> output = Exists(id);
                if (output.Certainty == Certainty.Uncertain) {
                    GoogleDriveProvider.ThrowStandardError();
                }

                if (output.Value) return id;

                FolderIDs.RemoveId(UserAccount.Account.Email, id);
            }

            string parentId = GetFolderId(Path.GetDirectoryName(path));
            id = CreateFolder(parentId, Path.GetFileName(path));

            FolderIDs.AddId(UserAccount.Account.Email, path, id);

            return id;
        }

        private string CreateFolder(string parentId, string name) {
            Google.Apis.Drive.v3.Data.File folder = new Google.Apis.Drive.v3.Data.File();
            folder.Name = name;
            folder.MimeType = MimeType.GetFolderMimeType();

            if (!string.IsNullOrEmpty(parentId)) {
                folder.Parents = new List<string>() { parentId };
            }

            var folderRequest = UserAccount.DriveService.Files.Create(folder);
            return folderRequest.Execute().Id;
        }

        public Output<bool> Exists(string folderId) {
            try {
                FilesResource.GetRequest request = UserAccount.DriveService.Files.Get(folderId);
                request.Fields = "";
                var file = request.Execute();

                return new Output<bool>(true, Certainty.Certain);
            } catch (Google.GoogleApiException e) {
                if (e.Error.Code == 404) return new Output<bool>(false, Certainty.Certain);

                return new Output<bool>(false, Certainty.Uncertain);
            }
        }
    }
}
