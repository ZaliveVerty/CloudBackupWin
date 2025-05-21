using System;
using System.IO;
using CloudServiceProvider;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class CloudProviderCatalogResource : SerializeableResource {
        public CloudProviderCatalog CloudProviderCatalog { get; private set; }
        public CloudApplication Application { get; private set; }

        public CloudProviderCatalogResource(CloudApplication application, IStreamProvider streamProvider) : base(streamProvider) {
            Application = application;
        }

        protected override void SetDefaultState() {
            CloudProviderCatalog = new CloudProviderCatalog();
            CloudProviderCatalog.Load(Application);

            foreach (ICloudServiceProvider cloudServiceProvider in CloudProviderCatalog.CloudServiceProviders) {
                CloudProviderCatalog.CloudProviders.Add(new CloudProvider() { 
                    CloudServiceProvider = cloudServiceProvider
                });
            }
        }
        protected override void SetState(Stream inputStream) {
            CloudProviderCatalog = new CloudProviderCatalogDeserializer(Application).Deserialize(Tag.FromStream(inputStream));
        }
        protected override void Serialize(Stream outputStream) {
            new CloudProviderCatalogSerializer().Serialize(CloudProviderCatalog).WriteToStream(outputStream);
        }
    }
}
