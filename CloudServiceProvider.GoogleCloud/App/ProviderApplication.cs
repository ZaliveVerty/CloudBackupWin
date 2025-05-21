using System;
using CommonUtilities;

namespace CloudServiceProvider.GoogleCloud {
    public class ProviderApplication {
        public CredentialsCatalogResource CredentialsCatalogResource { get; private set; }
        public CredentialsCatalog CredentialsCatalog => CredentialsCatalogResource.CredentialsCatalog;

        public ICloudServiceProvider CloudServiceProvider { get; private set; }
        public UserAccountController AccountController { get; private set; }

        public INamedStreamProviderController NamedStreamProviderController { get; private set; }

        public ProviderApplication(INamedStreamProviderController namedStreamProviderController, ICloudServiceProvider cloudServiceProvider) { 
            NamedStreamProviderController = namedStreamProviderController;

            CredentialsCatalogResource = new CredentialsCatalogResource("AccountCredentials", namedStreamProviderController);
            CredentialsCatalogResource.Load();
            CredentialsCatalogResource.CredentialsCatalog.OnContentsChanged += CredentialsCatalog_OnContentsChanged;

            CloudServiceProvider = cloudServiceProvider;
            AccountController = new UserAccountController(this);
        }

        private void CredentialsCatalog_OnContentsChanged(object sender, EventArgs e) {
            CredentialsCatalogResource.Save();
        }
    }
}
