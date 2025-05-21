using System;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;

namespace CloudServiceProvider.GoogleDrive {
    public class UserAccount {
        public IAccount Account { get; set; }
        
        public Token Token { get; set; }
        public bool Authorized { get; set; } = false;

        public DriveService DriveService { get; set; }
        public About.StorageQuotaData StorageQuota { get; set; }
        public UserCredential UserCredential { get; set; }

        public UserAccount() {
            Token = new Token();
        }
    }
}
