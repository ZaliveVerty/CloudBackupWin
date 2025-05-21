using System;
using System.IO;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class CloudSettingsResource : SerializeableResource {
        public CloudSettings CloudSettings { get; private set; }

        public CloudSettingsResource(IStreamProvider streamProvider) : base(streamProvider) { }

        protected override void SetDefaultState() {
            CloudSettings = new CloudSettings() { 
                ZipPath = "7z.exe"
            };
        }
        protected override void SetState(Stream inputStream) {
            CloudSettings = new CloudSettingsDeserializer().Deserialize(Tag.FromStream(inputStream));
        }
        protected override void Serialize(Stream outputStream) {
            new CloudSettingsSerializer().Serialize(CloudSettings).WriteToStream(outputStream);
        }
    }
}
