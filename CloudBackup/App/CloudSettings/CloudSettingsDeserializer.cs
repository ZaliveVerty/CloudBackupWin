using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class CloudSettingsDeserializer : IObjectDeserializer<CloudSettings> {
        public CloudSettings Deserialize(Tag tag) {
            ObjectTag obj = tag as ObjectTag;

            return new CloudSettings() { 
                ZipPath = obj["ZipPath"]
            };
        }
    }
}
