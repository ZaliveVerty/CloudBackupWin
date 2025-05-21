using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using CustomDialogs;
using CommonUtilities;

namespace CloudServiceProvider.GoogleCloud {
    public class GoogleCloudServiceProvider : ICloudServiceProvider {
        public string Name => "Google Cloud";
        public Image Icon => Properties.Resources._64pxGoogleCloudStorage;

        public ICloudProvider CloudProvider { get; private set; }
        public IEnumerable<ICommand> Commands { get; private set; }

        public ProviderApplication Application { get; private set; }

        public void Initialize(INamedStreamProviderController streamProviderController) {
            Application = new ProviderApplication(streamProviderController, this);

            CloudProvider = new GoogleCloudProvider(Application.AccountController);
            Commands = new List<ICommand>() {
                new CreentialsCommand(Application.CredentialsCatalog)
            };
        }

        public IAccount CreateAccount() {
            AccountCreator accountCreator = new AccountCreator(Application.CredentialsCatalog);
            accountCreator.ShowDialog();

            if (accountCreator.DialogClosed) return null;

            Application.CredentialsCatalog.Credentials.Add(accountCreator.CreatedAccount.Credentials);
            Application.AccountController.UserAccounts.Add(accountCreator.CreatedAccount);

            accountCreator.CreatedAccount.Account.CloudServiceProvider = this;
            accountCreator.CreatedAccount.CloudServiceProvider = this;

            return accountCreator.CreatedAccount.Account;
        }
        public bool RemoveAccount(IAccount account) {
            string result = CustomDialog.ShowMessage("Remove account",
                "The uploaded files will not be deleted.",
                Properties.Resources._64pxRemoveNamespace, System.Media.SystemSounds.Exclamation,
                "Ok", "Cancel");
            if(result == "Cancel" || result == "Closed") return false;

            try {
                UserAccount userAccount = Application.AccountController.UserAccounts.Where(x => x.Account.Email == account.Email).FirstOrDefault();

                Application.CredentialsCatalog.Credentials.Remove(userAccount.Credentials);
                Application.AccountController.UserAccounts.Remove(userAccount);
            } catch (Exception e) {
                CustomDialog.ShowError(e);
                return false;
            }

            return true;
        }
        public ICloudStorageInformation ProvideStorageInformation(IAccount account) {            
            UserAccount userAccount = Application.AccountController.AuthorizeUser(account);

            var storageObjects = userAccount.StorageClient.ListObjects(userAccount.Credentials.AccountCredentials.BucketName);

            long size = 0;
            foreach (var storageObject in storageObjects) {
                size += (long)storageObject.Size;
            }

            return new CloudStorageInformation() { 
                StorageType = StorageType.Unlimited,
                UsedBytes = size
            };
        }
    }
}
