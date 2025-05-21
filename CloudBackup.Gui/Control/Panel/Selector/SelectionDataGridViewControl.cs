using System;
using System.Windows.Forms;
using CloudServiceProvider;
using CustomDialogs;

namespace CloudBackup.Gui {
    public partial class ItemSelectionDataGridViewControl : IDataGridViewSelectionControl {
        public DataGridView DataGridView { get; set; }
        public Func<object, bool> ViewableItemValidator { get; }

        public ViewController ViewController { get; set; }

        public ItemSelectionDataGridViewControl(Func<object, bool> viewableItemValidator) {
            ViewableItemValidator = viewableItemValidator;
        }

        public DataGridViewColumn[] CreateColumns() {
            return new DataGridViewTextBoxColumn[] {
                new TextAndImageColumn(){
                    HeaderText = "Name",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                },
                new TextAndImageColumn(){
                    HeaderText = "Cloud provider",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                    Width = 110
                },
                new TextAndImageColumn(){
                    HeaderText = "Email",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                    Width = 60
                }
            };
        }

        //Update
        private ImageCache _imageCache = new ImageCache();

        public void SetRow(DataGridViewRow row, object item) {
            if (((Item)item).ID == ItemID.Group) SetGroupRow(row, item as Group);
            else SetUpdateableItemRow(row, item as UpdateableItem);
        }
        private void SetGroupRow(DataGridViewRow row, Group group) {
            row.SetValues(group.Name);
            row.DisplayImage(DataGridView.Columns[0], _imageCache.GetImage(group.GetImageChacheKey(), group.GetIcon(), 22, 22), 27);
        }
        private void SetUpdateableItemRow(DataGridViewRow row, UpdateableItem item) {
            row.SetValues(item.Name);

            ((TextAndImageCell)row.Cells[0]).XOffet = item.UpdateableItemID == UpdateableItemID.Folder || item.UpdateableItemID == UpdateableItemID.FilteredFolder ? 4 : 3;
            row.DisplayImage(DataGridView.Columns[0], _imageCache.GetImage(item.GetImageChacheKey(), item.GetIcon(), 16, 16), 27);

            if (item.Settings.Account != null) {
                IAccount account = item.Settings.Account;

                row.Cells[1].Value = account.CloudServiceProvider.Name;
                row.Cells[2].Value = account.Email;

                row.DisplayImage(DataGridView.Columns[1], _imageCache.GetImage($"type.provider.{account.CloudServiceProvider.GetType().FullName}", account.CloudServiceProvider.Icon, 16, 16), 23);
                row.DisplayImage(DataGridView.Columns[2], _imageCache.GetImage($"type.account.{account.CloudServiceProvider.GetType().FullName}.{account.Email}", account.ProfilePicture, 16, 16), 23);
            }
        }

        //Double click
        public void GridDoubleClick(DataGridViewCellEventArgs e, object item) {
            ItemID id = ((Item)item).ID;

            if (id == ItemID.Group) {
                ViewController.OpenChild(item as Group);
            }
        }
    }
}
