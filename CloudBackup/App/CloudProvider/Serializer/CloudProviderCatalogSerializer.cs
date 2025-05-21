using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class CloudProviderCatalogSerializer : IObjectSerializer<CloudProviderCatalog> {
        public IObjectSerializer<CloudProvider> CloudProviderSerializer { get; set; }

        public CloudProviderCatalogSerializer() {
            CloudProviderSerializer = new CloudProviderSerializer();
        }

        public Tag Serialize(CloudProviderCatalog item) {
            ObjectTag[] cloudProviderArray = new ObjectTag[item.CloudProviders.Count];

            for (int i = 0; i < item.CloudProviders.Count; i++) {
                cloudProviderArray[i] = new ObjectTag() {
                    { "CloudProvider", item.CloudProviders[i].CloudServiceProvider.Name },
                    { "Accounts", CloudProviderSerializer.Serialize(item.CloudProviders[i]) }
                };
            }

            ObjectTag output = new ObjectTag() {
                { "CloudProviders", cloudProviderArray }
            };

            if (item.SelectedAccount != null) {
                output.Add("SelectedAccount", new ObjectTag(){
                    { "Email", item.SelectedAccount.Email },
                    { "CloudProvider", item.SelectedAccount.CloudServiceProvider.Name }
                });
            }

            return output;
        }
    }
}
