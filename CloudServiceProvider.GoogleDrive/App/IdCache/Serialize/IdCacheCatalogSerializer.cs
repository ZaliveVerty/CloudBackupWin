using System;
using System.Collections.Generic;
using System.Linq;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudServiceProvider.GoogleDrive {
    public class IdCacheCatalogSerializer : IObjectSerializer<IdCacheCatalog> {
        public IObjectSerializer<IdCache> IdCacheSerializer { get; set; }

        public IdCacheCatalogSerializer() { 
            IdCacheSerializer = new IdCacheSerializer();
        }

        public Tag Serialize(IdCacheCatalog item) {
            ObjectTag[] idTags = new ObjectTag[item.IdCache.Count];

            for (int i = 0; i < item.IdCache.Count; i++) {
                KeyValuePair<string, IdCache> pair = item.IdCache.ElementAt(i);

                idTags[i] = new ObjectTag() {
                    { "Email", pair.Key },
                    { "Cache", IdCacheSerializer.Serialize(item.IdCache.Values.ElementAt(i)) }
                };
            }

            return idTags;
        }
    }
}
