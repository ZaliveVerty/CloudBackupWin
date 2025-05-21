using System;
using CommonUtilities;

namespace CloudBackup {
    public class CloudApplication {
        public CloudProviderCatalogResource CloudProviderCatalogResource { get; private set; }
        public CloudProviderCatalog CloudProviderCatalog => CloudProviderCatalogResource.CloudProviderCatalog;

        public GroupResource GroupResource { get; private set; }
        public Group Group => GroupResource.Group;

        public UsersheetCatalogResource UsersheetCatalogResource { get; private set; }
        public UsersheetCatalog UsersheetCatalog => UsersheetCatalogResource.UsersheetCatalog;

        public SchemeCatalogResource SchemeCatalogResource { get; private set; }
        public SchemeCatalog SchemeCatalog => SchemeCatalogResource.SchemeCatalog;

        public CloudSettingsResource CloudSettingsResource { get; private set; }
        public CloudSettings CloudSettings => CloudSettingsResource.CloudSettings;

        public IUpdater Updater { get; private set; }

        public IResourceController ResourceController { get; private set; }
        public ReferenceKey Key { get; private set; }

        public CloudApplication(IResourceController resourceController, ReferenceKey key) { 
            ResourceController = resourceController;
            Key = key;

            CloudProviderCatalogResource = new CloudProviderCatalogResource(this, new EncryptedStreamProvider(new FileStreamProvider("Storage\\Application\\Accounts"), Key));
            CloudProviderCatalogResource.Load();
            CloudProviderCatalogResource.CloudProviderCatalog.OnContentsChanged += CloudProviderCatalog_OnContentsChanged;
            ResourceController.AddResource(CloudProviderCatalogResource);

            GroupResource = new GroupResource(this, new EncryptedStreamProvider(new FileStreamProvider("Storage\\Items"), Key));
            GroupResource.Load();
            GroupResource.Group.OnContentsChanged += Group_OnContentsChanged;
            ResourceController.AddResource(GroupResource);

            UsersheetCatalogResource = new UsersheetCatalogResource(Group, new EncryptedStreamProvider(new FileStreamProvider("Storage\\Application\\Usersheets"), Key));
            UsersheetCatalogResource.Load();
            UsersheetCatalogResource.UsersheetCatalog.OnContentsChanged += UsersheetCatalog_OnContentsChanged;
            ResourceController.AddResource(UsersheetCatalogResource);

            SchemeCatalogResource = new SchemeCatalogResource(Group, new EncryptedStreamProvider(new FileStreamProvider("Storage\\Application\\Schemes"), Key));
            SchemeCatalogResource.Load();
            SchemeCatalogResource.SchemeCatalog.OnContentsChanged += SchemeCatalog_OnContentsChanged;
            ResourceController.AddResource(SchemeCatalogResource);

            CloudSettingsResource = new CloudSettingsResource(new EncryptedStreamProvider(new FileStreamProvider("Storage\\Application\\Settings"), Key));
            CloudSettingsResource.Load();
            CloudSettingsResource.CloudSettings.OnContentsChanged += CloudSettings_OnContentsChanged;
            ResourceController.AddResource(CloudSettingsResource);

            Updater = new Updater(this);
        }

        private void CloudProviderCatalog_OnContentsChanged(object sender, EventArgs e) {
            CloudProviderCatalogResource.Save();
        }
        private void Group_OnContentsChanged(object sender, EventArgs e) {
            GroupResource.Save();
        }
        private void UsersheetCatalog_OnContentsChanged(object sender, EventArgs e) {
            UsersheetCatalogResource.Save();
        }
        private void SchemeCatalog_OnContentsChanged(object sender, EventArgs e) {
            SchemeCatalogResource.Save();
        }
        private void CloudSettings_OnContentsChanged(object sender, EventArgs e) {
            CloudSettingsResource.Save();
        }
    }
}
