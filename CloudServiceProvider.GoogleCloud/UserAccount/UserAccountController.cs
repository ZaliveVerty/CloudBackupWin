using System;
using System.Linq;
using System.Collections.Generic;

namespace CloudServiceProvider.GoogleCloud {
    public class UserAccountController {
        public IList<UserAccount> UserAccounts { get; private set; }
        public ProviderApplication Application { get; private set; }

        public UserAccountController(ProviderApplication application) {
            Application = application;
            UserAccounts = new List<UserAccount>();

            foreach (Credentials credentials in Application.CredentialsCatalog.Credentials) {
                UserAccounts.Add(new UserAccount() {
                    Credentials = credentials,
                    CloudServiceProvider = Application.CloudServiceProvider
                });
            }
        }

        public UserAccount AuthorizeUser(IAccount account) {
            UserAccount userAccount = UserAccounts.Where(x => x.Credentials.Email == account.Email).FirstOrDefault();
            if (userAccount == null) return null;

            if (!userAccount.Authorized) userAccount.Authorize();
            userAccount.Account = account;

            return userAccount;
        }
    }
}
