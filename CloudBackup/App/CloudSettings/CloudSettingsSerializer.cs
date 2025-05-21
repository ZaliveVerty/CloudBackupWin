using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class CloudSettingsSerializer : IObjectSerializer<CloudSettings> {
        public Tag Serialize(CloudSettings item) {
            return new ObjectTag() {
                { "ZipPath", item.ZipPath }
            };
        }
    }
}
