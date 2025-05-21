using System;
using System.Linq;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudBackup {
    public class UpdateableItemSerializer : IObjectSerializer<UpdateableItem> {
        public IObjectSerializer<Folder> FolderSerializer { get; set; }
        public IObjectSerializer<FilteredFolder> FilteredFolderSerializer { get; set; }
        public IObjectSerializer<ItemBundle> ItemBundleSerializer { get; set; }
        
        public IObjectSerializer<Settings> SettingsSerializer { get; set; }

        public UpdateableItemSerializer(IObjectSerializer<Folder> folderSerializer, IObjectSerializer<FilteredFolder> filteredFolderSerializer, IObjectSerializer<ItemBundle> itemBundleSerializer, IObjectSerializer<Settings> settingsSerializer) {
            FolderSerializer = folderSerializer;
            FilteredFolderSerializer = filteredFolderSerializer;
            ItemBundleSerializer = itemBundleSerializer;
            SettingsSerializer = settingsSerializer;
        }

        public Tag Serialize(UpdateableItem item) {
            Tag child;

            switch (item.UpdateableItemID) {
                case UpdateableItemID.Folder:
                    child = FolderSerializer.Serialize(item as Folder);
                    break;
                case UpdateableItemID.FilteredFolder:
                    child = FilteredFolderSerializer.Serialize(item as FilteredFolder);
                    break;
                case UpdateableItemID.ItemBundle:
                    child = ItemBundleSerializer.Serialize(item as ItemBundle);
                    break;
                default:
                    child = null;
                    break;
            }

            return new ObjectTag() {
                { "UpdateableItemID", (byte)item.UpdateableItemID },
                { "GeneratedID", item.GeneratedID },
                { "Settings", SettingsSerializer.Serialize(item.Settings) },
                { "UpdateHistory", item.UpdateHistory.Dates.ToArray() },
                { "Child", child }
            };
        }
    }
}
