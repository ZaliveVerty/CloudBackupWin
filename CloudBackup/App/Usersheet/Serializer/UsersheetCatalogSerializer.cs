using System;
using System.Collections.Generic;
using System.Linq;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class UsersheetCatalogSerializer : IObjectSerializer<UsersheetCatalog> {
        public IObjectSerializer<Usersheet> UsersheetSerializer { get; set; }

        public UsersheetCatalogSerializer() {
            UsersheetSerializer = new UsersheetSerializer(new ItemInformationSerializer());
        }

        public Tag Serialize(UsersheetCatalog item) {
            ObjectTag[] output = new ObjectTag[item.Usersheets.Count];

            for (int i = 0; i < item.Usersheets.Count; i++) {
                KeyValuePair<string, Usersheet> pair = item.Usersheets.ElementAt(i);
                
                output[i] = new ObjectTag() {
                    { "Key", pair.Key },
                    { "Usersheet", UsersheetSerializer.Serialize(pair.Value) }
                };
            }

            return output;
        }
    }
}
