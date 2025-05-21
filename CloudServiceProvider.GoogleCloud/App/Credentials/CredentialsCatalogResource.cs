using System;
using System.IO;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudServiceProvider.GoogleCloud {
    public class CredentialsCatalogResource : NamedSerializeableResource {
        public CredentialsCatalog CredentialsCatalog { get; private set; }

        public CredentialsCatalogResource(string name, INamedStreamProviderController controller) : base(name, controller) {}

        protected override void SetDefaultState() {
            CredentialsCatalog = new CredentialsCatalog();
        }
        protected override void SetState(Stream inputStream) {
            CredentialsCatalog = new CredentialsCatalogDeserializer().Deserialize(Tag.FromStream(inputStream));
        }
        protected override void Serialize(Stream outputStream) {
            new CredentialsCatalogSerializer().Serialize(CredentialsCatalog).WriteToStream(outputStream);
        }
    }
}
