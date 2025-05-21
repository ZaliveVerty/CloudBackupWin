using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudServiceProvider.GoogleDrive {
    public class IdCacheDeserializer : IObjectDeserializer<IdCache> {
        public IdCache Deserialize(Tag tag) {
            ObjectTag[] idArray = tag;

            IdCache output = new IdCache();
            foreach (ObjectTag idObj in idArray) {
                output.Ids.Add(idObj["FileName"], idObj["Id"]);
            }

            return output;
        }
    }
}
