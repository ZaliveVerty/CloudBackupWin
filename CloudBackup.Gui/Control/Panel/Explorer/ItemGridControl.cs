using System;
using System.Windows.Forms;
using CloudServiceProvider;
using CustomDialogs;

namespace CloudBackup.Gui {
    public partial class ItemGridControl : DataGridViewControl {
        public ViewController ViewController { get; set; }

        public ItemGridControl(ViewController viewController) {
            Initialize();

            ViewController = viewController;
        }

        public override DataGridViewTextBoxColumn[] CreateColumns() {
            return new DataGridViewTextBoxColumn[] {
                new TextAndImageColumn(){
                    HeaderText = "Name",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                    Width = 190
                },
                new TextAndImageColumn(){
                    HeaderText = "Path in drive",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    Width = 390,
                    AlignmentToRight = true
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
                },
                new TextAndImageColumn(){
                    HeaderText = "Last updated",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                    Width = 100,
                    DefaultCellStyle = new DataGridViewCellStyle(){
                        Alignment = DataGridViewContentAlignment.MiddleRight,
                        Padding = new Padding(0, 0, 5, 0)
                    }
                }
            };
        }

        //Update
        private ImageCache _imageCache = new ImageCache();

        protected override bool SetRow(DataGridViewRow row, object item) {
            if (((Item)item).ID == ItemID.Group) SetGroupRow(row, item as Group);
            else SetUpdateableItemRow(row, item as UpdateableItem);

            return true;
        }

        private void SetGroupRow(DataGridViewRow row, Group group) {
            row.SetValues(group.Name);
            row.DisplayImage(DataGridView.Columns[0], _imageCache.GetImage(group.GetImageChacheKey(), group.GetIcon(), 22, 22), 27);
        }
        private void SetUpdateableItemRow(DataGridViewRow row, UpdateableItem item) {
            row.SetValues(item.Name, item.Settings.PathInDrive, "", "", item.GetLastUpdatedString());

            ((TextAndImageCell)row.Cells[0]).XOffet = item.UpdateableItemID == UpdateableItemID.Folder || item.UpdateableItemID == UpdateableItemID.FilteredFolder ? 4 : 3;
            row.DisplayImage(DataGridView.Columns[0], _imageCache.GetImage(item.GetImageChacheKey(), item.GetIcon(), 16, 16), 27);

            if (!string.IsNullOrEmpty(item.Settings.Password)) {
                row.DisplayImage(DataGridView.Columns[1], Properties.Resources._16pxKey);
            }

            if (item.Settings.Account != null) {
                IAccount account = item.Settings.Account;

                row.Cells[2].Value = account.CloudServiceProvider.Name;
                row.Cells[3].Value = account.Email;

                row.DisplayImage(DataGridView.Columns[2], _imageCache.GetImage($"type.provider.{account.CloudServiceProvider.GetType().FullName}", account.CloudServiceProvider.Icon, 16, 16), 23);
                row.DisplayImage(DataGridView.Columns[3], _imageCache.GetImage($"type.account.{account.CloudServiceProvider.GetType().FullName}.{account.Email}", account.ProfilePicture, 16, 16), 23);
            }
        }

        //Double click
        protected override void GridDoubleClick(DataGridViewCellEventArgs e, object item) {
            ItemID id = ((Item)item).ID;

            if (id == ItemID.Group) {
                ViewController.OpenChild(item as Group);
            } else {
                ItemUtilities.EditItem(item as Item);
            }
        }
    }
}
