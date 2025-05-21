using System;
using CloudServiceProvider;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class CloudProviderCatalogDeserializer : IObjectDeserializer<CloudProviderCatalog> {
        public IObjectDeserializer<CloudProvider> CloudProviderDeserializer { get; set; }
        public CloudApplication Application { get; set; }

        public CloudProviderCatalogDeserializer(CloudApplication application) {
            CloudProviderDeserializer = new CloudProviderDeserializer();
            Application = application;
        }

        public CloudProviderCatalog Deserialize(Tag tag) {
            ObjectTag obj = tag as ObjectTag;
            
            CloudProviderCatalog output = new CloudProviderCatalog();
            output.Load(Application);

            ObjectTag[] cloudProviderArray = obj["CloudProviders"];
            
            foreach (ObjectTag cludProviderObj in cloudProviderArray) {
                CloudProvider cloudProvider = CloudProviderDeserializer.Deserialize(cludProviderObj["Accounts"]);
                cloudProvider.CloudServiceProvider = GetServiceProvider(output, cludProviderObj["CloudProvider"]);

                foreach (IAccount account in cloudProvider.Accounts) {
                    account.CloudServiceProvider = cloudProvider.CloudServiceProvider;
                }

                output.CloudProviders.Add(cloudProvider);
                output.CloudServiceProviders.Remove(cloudProvider.CloudServiceProvider);
            }

            foreach (ICloudServiceProvider leftProvider in output.CloudServiceProviders) {
                output.CloudProviders.Add(new CloudProvider() {
                    CloudServiceProvider = leftProvider
                });
            }
            output.CloudServiceProviders.Clear();

            if (obj.TryGetValue("SelectedAccount", out Tag selectedAccountTag)) { 
                ObjectTag selectedAccountObj = selectedAccountTag as ObjectTag;

                output.SelectedAccount = output.GetAccount(selectedAccountObj["Email"], selectedAccountObj["CloudProvider"]);
            }

            return output;
        }

        private static ICloudServiceProvider GetServiceProvider(CloudProviderCatalog cloudProviderCatalog, string name) {
            foreach (ICloudServiceProvider cloudServiceProvider in cloudProviderCatalog.CloudServiceProviders) {
                if (cloudServiceProvider.Name == name) return cloudServiceProvider;
            }

            return null;
        }
    }
}
