using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudServiceProvider.GoogleDrive {
    public class IdCacheCatalogDeserializer : IObjectDeserializer<IdCacheCatalog> {
        public IObjectDeserializer<IdCache> IdCacheDeserializer { get; set; }

        public IdCacheCatalogDeserializer() {
            IdCacheDeserializer = new IdCacheDeserializer();
        }

        public IdCacheCatalog Deserialize(Tag tag) {
            ObjectTag[] idTags = tag;

            IdCacheCatalog output = new IdCacheCatalog();
            foreach (ObjectTag idObj in idTags) {
                output.IdCache.Add(idObj["Email"], IdCacheDeserializer.Deserialize(idObj["Cache"]));
            }

            return output;
        }
    }
}
