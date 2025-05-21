using System;
using System.Collections.Generic;
using System.Linq;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudServiceProvider.GoogleDrive {
    public class IdCacheSerializer : IObjectSerializer<IdCache> {
        public Tag Serialize(IdCache item) {
            ObjectTag[] idArray = new ObjectTag[item.Ids.Count];

            for (int i = 0; i < item.Ids.Count; i++) {
                KeyValuePair<string, string> pair = item.Ids.ElementAt(i);
            
                idArray[i] = new ObjectTag() {
                    { "FileName", pair.Key },
                    { "Id", pair.Value }
                };
            }

            return idArray;
        }
    }
}
