using System;
using System.IO;
using System.Text;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;
using CustomDialogs;

namespace CloudServiceProvider.GoogleCloud {
    public class UserAccount {
        public IAccount Account { get; set; }

        public bool Authorized { get; set; } = false;
        public Credentials Credentials { get; init; }

        public StorageClient StorageClient { get; set; }
        public GoogleCredential GoogleCredential { get; set; }

        public ICloudServiceProvider CloudServiceProvider { get; set; }

        public UserAccount() { 
            Credentials = new Credentials();
            Credentials.OnContentsChanged += Credentials_OnContentsChanged;
        }

        public void Authorize() {
            if (!ValidateCredentials()) return;

            GoogleCredential = GoogleCredential.FromStream(new MemoryStream(Encoding.UTF8.GetBytes(Credentials.AccountCredentials.CredentialsJsonString)));
            StorageClient = StorageClient.Create(GoogleCredential);

            Account = new Account() {
                Email = Credentials.Email,
                DisplayName = Credentials.Name,
                CloudServiceProvider = CloudServiceProvider
            };

            Authorized = true;
        }

        private void Credentials_OnContentsChanged(object sender, EventArgs e) {
            if (Authorized) Authorize();
        }

        private bool ValidateCredentials() {
            bool json = string.IsNullOrEmpty(Credentials.AccountCredentials.CredentialsJsonString);
            bool bucketName = string.IsNullOrEmpty(Credentials.AccountCredentials.BucketName);

            if (json && !bucketName) {
                CustomDialog.ShowError("Google Cloud Error", "Credentials json string is empty.");
            } else if (!json && bucketName) {
                CustomDialog.ShowError("Google Cloud Error", "Bucket name is empty.");
            } else if (json && bucketName) {
                CustomDialog.ShowError("Google Cloud Error", "Credentials json string and bucket name are empty.");
            }

            return !json && !bucketName;
        }
    }
}
