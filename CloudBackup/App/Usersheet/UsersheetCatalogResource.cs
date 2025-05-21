using System;
using System.IO;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class UsersheetCatalogResource : SerializeableResource {
        public UsersheetCatalog UsersheetCatalog { get; private set; }
        public Group Group { get; private set; }

        public UsersheetCatalogResource(Group group, IStreamProvider streamProvider) : base(streamProvider) {
            Group = group;
        }

        protected override void SetDefaultState() {
            UsersheetCatalog = new UsersheetCatalog();
        }
        protected override void SetState(Stream inputStream) {
            UsersheetCatalog = new UsersheetCatalogDeserializer(Group).Deserialize(Tag.FromStream(inputStream));
        }
        protected override void Serialize(Stream outputStream) {
            new UsersheetCatalogSerializer().Serialize(UsersheetCatalog).WriteToStream(outputStream);
        }
    }
}
