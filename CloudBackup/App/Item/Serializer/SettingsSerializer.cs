using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class SettingsSerializer : IObjectSerializer<Settings> {
        public Tag Serialize(Settings item) {
            ObjectTag output = new ObjectTag() {
                { "Password", item.Password },
                { "PathInDrive", item.PathInDrive },
                { "Link", item.Link }
            };

            if (item.Account != null) {
                output.Add("Account", new ObjectTag() {
                    { "Email", item.Account.Email },
                    { "Provider", item.Account.CloudServiceProvider.Name }
                });
            }

            return output;
        }
    }
}
