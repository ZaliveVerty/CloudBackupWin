using System;
using CloudServiceProvider;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class SettingsDeserializer : IObjectDeserializer<Settings> {
        public CloudProviderCatalog CloudProviderCatalog { get; set; }

        public SettingsDeserializer(CloudProviderCatalog cloudProviderCatalog) { 
            CloudProviderCatalog = cloudProviderCatalog;
        }

        public Settings Deserialize(Tag tag) {
            ObjectTag obj = tag as ObjectTag;

            IAccount account = null;
            if (obj.TryGetValue("Account", out Tag accountTag)) { 
                ObjectTag accountObj = accountTag as ObjectTag;

                string email = accountObj["Email"];
                string provider = accountObj["Provider"];

                account = CloudProviderCatalog.GetAccount(email, provider);
            }

            return new Settings() { 
                Account = account,
                Password = obj["Password"],
                PathInDrive = obj["PathInDrive"],
                Link = obj["Link"]
            };
        }
    }
}
