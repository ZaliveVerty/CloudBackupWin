using System;
using System.IO;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudServiceProvider.GoogleDrive {
    public class TokenCatalogResource : NamedSerializeableResource {
        public TokenCatalog TokenCatalog { get; private set; }

        public TokenCatalogResource(string name, INamedStreamProviderController controller) : base(name, controller) { }

        protected override void SetDefaultState() {
            TokenCatalog = new TokenCatalog();
        }
        protected override void SetState(Stream inputStream) {
            TokenCatalog = new TokenCatalogDeserializer().Deserialize(Tag.FromStream(inputStream));
        }
        protected override void Serialize(Stream outputStream) {
            new TokenCatalogSerializer().Serialize(TokenCatalog).WriteToStream(outputStream);
        }
    }
}
