using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class UsersheetDeserializer : IObjectDeserializer<Usersheet> {
        public IObjectDeserializer<ItemInformation> ItemInformationDeserializer { get; set; }

        public UsersheetDeserializer(IObjectDeserializer<ItemInformation> itemInformationDeserializer) {
            ItemInformationDeserializer = itemInformationDeserializer;
        }

        public Usersheet Deserialize(Tag tag) {
            ObjectTag obj = tag as ObjectTag;

            Usersheet usersheet = new Usersheet() { 
                Link = obj["Link"]
            };

            Tag[] tagArray = obj["Items"];
            foreach (Tag childTag in tagArray) {
                ItemInformation info = ItemInformationDeserializer.Deserialize(childTag);
                if (info == null) continue;

                usersheet.Items.Add(info.Item.GeneratedID, info);
            }

            return usersheet;
        }
    }
}
