using System;
using System.Collections.Generic;
using System.Drawing;
using Google.Apis.Drive.v3;
using CustomDialogs;
using CommonUtilities;

namespace CloudServiceProvider.GoogleDrive {
    public class GoogleDriveServiceProvider : ICloudServiceProvider {
        public string Name => "Google Drive";
        public Image Icon => Properties.Resources.GoogleDriveLogo;

        public ICloudProvider CloudProvider { get; private set; }
        public IEnumerable<ICommand> Commands { get; private set; }

        public ProviderApplication Application { get; private set; }

        public void Initialize(INamedStreamProviderController streamProviderController) {
            Application = new ProviderApplication(this, streamProviderController);

            CloudProvider = new GoogleDriveProvider(Application);
            Commands = new List<ICommand>() {
                new ReauthorizeCommand(Application.AccountController, Application.TokenCatalog),
                new ViewCacheCommand(Application.FileCache, "View file cache"),
                new ViewCacheCommand(Application.FolderCache, "View folder cache"),
                new CredentialsCommand(Application.Credentials)
            };
        }

        public IAccount CreateAccount() {
            return Application.AccountController.CreateAccount();
        }
        public bool RemoveAccount(IAccount account) {
            string result = CustomDialog.ShowMessage("Remove account",
                "Do you want to delete the backup files created within this account?",
                Properties.Resources._64pxRemoveNamespace, System.Media.SystemSounds.Exclamation,
                "Yes", "No", "Cancel");
            if (result == "Cancel" || result == "Closed") return false;

            if (result == "Yes") {
                try {
                    CloudProvider.Delete(account, new ObjectRequest() {
                        ObjectType = ObjectType.Directory
                    });

                    Application.AccountController.Remove(account);

                    Application.TokenCatalog.Tokens.Remove(account.Email);
                    Application.FolderCache.IdCache.Remove(account.Email);
                    Application.FileCache.IdCache.Remove(account.Email);
                } catch (Exception e) {
                    CustomDialog.ShowError(e);
                    return false;
                }
            }

            return true;
        }
        public ICloudStorageInformation ProvideStorageInformation(IAccount account) {
            UserAccount userAccount = Application.AccountController.AuthorizeUser(account);

            AboutResource.GetRequest aboutRequest = userAccount.DriveService.About.Get();
            aboutRequest.Fields = "storageQuota";
            Google.Apis.Drive.v3.Data.About about = aboutRequest.Execute();

            return new CloudStorageInformation() {
                StorageType = StorageType.Limited,
                UsedBytes = about.StorageQuota.Usage.Value,
                Capacity = about.StorageQuota.Limit.Value
            };
        }
    }
}
