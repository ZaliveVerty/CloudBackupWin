using System;
using CommonUtilities;

namespace CloudServiceProvider.GoogleDrive {
    public class ProviderApplication {
        public TokenCatalogResource TokenCatalogResource { get; private set; }
        public TokenCatalog TokenCatalog => TokenCatalogResource.TokenCatalog;

        public IdCacheCatalogResource FolderCacheResource { get; private set; }
        public IdCacheCatalog FolderCache => FolderCacheResource.IdCacheCatalog;

        public IdCacheCatalogResource FileCacheResource { get; private set; }
        public IdCacheCatalog FileCache => FileCacheResource.IdCacheCatalog;

        public CredentialsResource CredentialsResource { get; private set; }
        public Credentials Credentials => CredentialsResource.Credentials;

        public ICloudServiceProvider CloudServiceProvider { get; private set; }
        public UserAccountController AccountController { get; private set; }

        public INamedStreamProviderController NamedStreamProviderController { get; private set; }

        public ProviderApplication(ICloudServiceProvider cloudServiceProvider, INamedStreamProviderController namedStreamProviderController) { 
            NamedStreamProviderController = namedStreamProviderController;

            TokenCatalogResource = new TokenCatalogResource("Tokens", namedStreamProviderController);
            TokenCatalogResource.Load();
            TokenCatalogResource.TokenCatalog.OnContentsChanged += TokenCatalog_OnContentsChanged;

            FolderCacheResource = new IdCacheCatalogResource("FolderCache", namedStreamProviderController);
            FolderCacheResource.Load();
            FolderCacheResource.IdCacheCatalog.OnContentsChanged += FolderCache_OnContentsChanged;

            FileCacheResource = new IdCacheCatalogResource("FileCache", namedStreamProviderController);
            FileCacheResource.Load();
            FileCacheResource.IdCacheCatalog.OnContentsChanged += FileCache_OnContentsChanged;

            CredentialsResource = new CredentialsResource("Credentials", namedStreamProviderController);
            CredentialsResource.Load();
            CredentialsResource.Credentials.OnContentsChanged += Credentials_OnContentsChanged;

            CloudServiceProvider = cloudServiceProvider;
            AccountController = new UserAccountController(this);
        }

        private void TokenCatalog_OnContentsChanged(object sender, EventArgs e) {
            TokenCatalogResource.Save();
        }
        private void FolderCache_OnContentsChanged(object sender, EventArgs e) {
            FolderCacheResource.Save();
        }
        private void FileCache_OnContentsChanged(object sender, EventArgs e) {
            FileCacheResource.Save();
        }
        private void Credentials_OnContentsChanged(object sender, EventArgs e) {
            CredentialsResource.Save();
        }
    }
}
