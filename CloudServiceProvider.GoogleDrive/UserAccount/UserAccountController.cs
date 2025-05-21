using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading;
using System.Drawing;
using System.Text;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.Apis.Auth.OAuth2;

namespace CloudServiceProvider.GoogleDrive {
    public class UserAccountController {
        public IList<UserAccount> UserAccounts { get; private set; }

        public ProviderApplication Application { get; private set; }

        public string[] Scopes { get; set; } = { DriveService.Scope.Drive };
        public string ApplicationName { get; set; } = "Cloud Backup";

        public UserAccountController(ProviderApplication application) {
            Application = application;
            UserAccounts = new List<UserAccount>();

            foreach (KeyValuePair<string, Token> pair in Application.TokenCatalog.Tokens) {
                UserAccounts.Add(new UserAccount() { 
                    Token = pair.Value
                });
            }
        }

        public UserAccount AuthorizeUser(IAccount account) {
            UserAccount userAccount = UserAccounts.Where(x => x.Token.Email == account.Email).FirstOrDefault();

            if (!userAccount.Authorized) InitializeUser(userAccount);
            userAccount.Account = account;

            return userAccount;
        }
        public void Reauthorize(string email) {
            UserAccount newAccount = CreateAccountInstance();

            newAccount.Token.Created = DateTime.Now;

            IEnumerable<UserAccount> oldAccountSearch = UserAccounts.Where(x => x.Token.Email == email);
            UserAccount oldAccount = oldAccountSearch.Any() ? oldAccountSearch.First() : null;

            if (oldAccount == null) {
                UserAccounts.Add(newAccount);
            } else {
                UserAccounts.Remove(oldAccount);
                UserAccounts.Add(newAccount);
            }
        }

        public IAccount CreateAccount() {
            UserAccount userAccount = CreateAccountInstance();
            Application.TokenCatalog.Tokens.Add(userAccount.Account.Email, userAccount.Token);

            UserAccounts.Add(userAccount);

            return userAccount.Account;
        }
        public UserAccount CreateAccountInstance() {
            UserAccount output = new UserAccount();
            InitializeUser(output);

            AboutResource.GetRequest aboutRequest = output.DriveService.About.Get();
            aboutRequest.Fields = "user";
            Google.Apis.Drive.v3.Data.About about = aboutRequest.Execute();

            output.Token.Email = about.User.EmailAddress;

            Account account = new Account() {
                DisplayName = about.User.DisplayName,
                Email = about.User.EmailAddress,
                CloudServiceProvider = Application.CloudServiceProvider
            };

            if (!string.IsNullOrEmpty(about.User.PhotoLink)) {
                account.ProfilePicture = ImageUtilities.DownloadImage(about.User.PhotoLink);
            } else {
                account.ProfilePicture = new Bitmap(32, 32);
            }

            output.Account = account;

            return output;
        }

        private void InitializeUser(UserAccount account) {
            account.UserCredential = AuthorizeUser(new CustomDataStore(account.Token));

            account.DriveService = new DriveService(new BaseClientService.Initializer() {
                HttpClientInitializer = account.UserCredential,
                ApplicationName = ApplicationName,
            });
            account.DriveService.HttpClient.Timeout = TimeSpan.FromSeconds(300);

            account.Authorized = true;
        }
        private UserCredential AuthorizeUser(IDataStore dataStore) {
            UserCredential credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                GoogleClientSecrets.FromStream(new MemoryStream(Encoding.UTF8.GetBytes(Application.Credentials.JsonCredentials))).Secrets,
                Scopes,
                "user",
                CancellationToken.None,
                dataStore).Result;

            return credential;
        }

        public void Remove(IAccount account) {
            for (int i = 0; i < UserAccounts.Count; i++) {
                if (UserAccounts[i].Account.Email == account.Email) {
                    UserAccounts.RemoveAt(i);
                    return;
                }
            }
        }
    }
}
