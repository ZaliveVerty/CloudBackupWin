using System;
using CloudServiceProvider;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class CloudProviderSerializer : IObjectSerializer<CloudProvider> {
        public Tag Serialize(CloudProvider item) {
            ObjectTag[] accountArray = new ObjectTag[item.Accounts.Count];

            for (int i = 0; i < item.Accounts.Count; i++) {
                IAccount account = item.Accounts[i];

                accountArray[i] = new ObjectTag() {
                    { "Name", account.DisplayName },
                    { "Email", account.Email },
                    { "ProfilePicture", ImageUtilities.ImageToByteArray(account.ProfilePicture) }
                };
            }

            return accountArray;
        }
    }
}
