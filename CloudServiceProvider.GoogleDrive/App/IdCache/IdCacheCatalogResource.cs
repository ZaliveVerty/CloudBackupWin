using System;
using System.IO;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudServiceProvider.GoogleDrive {
    public class IdCacheCatalogResource : NamedSerializeableResource {
        public IdCacheCatalog IdCacheCatalog { get; private set; }

        public IdCacheCatalogResource(string name, INamedStreamProviderController controller) : base(name, controller) { }

        protected override void SetDefaultState() {
            IdCacheCatalog = new IdCacheCatalog();
        }
        protected override void SetState(Stream inputStream) {
            IdCacheCatalog = new IdCacheCatalogDeserializer().Deserialize(Tag.FromStream(inputStream));
        }
        protected override void Serialize(Stream outputStream) {
            new IdCacheCatalogSerializer().Serialize(IdCacheCatalog).WriteToStream(outputStream);
        }
    }
}
