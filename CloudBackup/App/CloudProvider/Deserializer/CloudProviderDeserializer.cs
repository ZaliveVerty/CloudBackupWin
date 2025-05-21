using System;
using CloudServiceProvider;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class CloudProviderDeserializer : IObjectDeserializer<CloudProvider> {
        public CloudProvider Deserialize(Tag tag) {
            ObjectTag[] accountArray = tag;

            CloudProvider output = new CloudProvider();
            foreach (ObjectTag accountObj in accountArray) {
                output.Accounts.Add(new Account() { 
                    DisplayName = accountObj["Name"],
                    Email = accountObj["Email"],
                    ProfilePicture = ImageUtilities.ImageFromByteArray(accountObj["ProfilePicture"])
                });
            }

            return output;
        }
    }
}
