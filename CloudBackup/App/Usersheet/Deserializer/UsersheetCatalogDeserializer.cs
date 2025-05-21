using System;
using System.Collections.Generic;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class UsersheetCatalogDeserializer : IObjectDeserializer<UsersheetCatalog> {
        public IObjectDeserializer<Usersheet> UsersheetDeserializer { get; set; }

        public UsersheetCatalogDeserializer(Group group) {
            IList<UpdateableItem> updateableItems = new List<UpdateableItem>();
            group.GetUpdateableItems(updateableItems);

            UsersheetDeserializer = new UsersheetDeserializer(new ItemInformationDeserializer(updateableItems));
        }

        public UsersheetCatalog Deserialize(Tag tag) {
            ObjectTag[] usersheetTagArray = tag;
            
            UsersheetCatalog output = new UsersheetCatalog();
            foreach (ObjectTag usersheetTag in usersheetTagArray) {
                output.Usersheets.Add(usersheetTag["Key"], UsersheetDeserializer.Deserialize(usersheetTag["Usersheet"]));
            }

            return output;
        }
    }
}
