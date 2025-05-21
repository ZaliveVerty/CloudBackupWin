using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using CustomDialogs;

namespace CloudBackup.Gui {
    public partial class ItemExplorer : Form {
        public CloudApplication Application { get; set; }
        public GuiApplication GuiApplication { get; set; }

        public IView CurrentView => ViewControl.ViewController.CurrentView;
        public Group CurrentGroup => CurrentView.ViewNode.Node as Group;

        public ItemGridControl GridControl { get; set; }
        public DataGridView GridView {
            get => GridControl.DataGridView;
        }

        public ItemExplorer(Group group, CloudApplication application, GuiApplication guiApplication) {
            InitializeComponent();

            Application = application;
            GuiApplication = guiApplication;

            ViewController viewController = new ViewController(new GroupViewNode(group ?? Application.Group));
            GridControl = new ItemGridControl(viewController);

            ViewControl = new ViewControl() {
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

            StandardVerticalViewControl viewControl = new StandardVerticalViewControl(ViewControl, GridControl);
            viewControl.HeaderToolBar.ViewController = viewController;
            viewControl.HeaderToolBar.NodeCreator = item => new GroupNode(item as Group);

            ViewControl.Initialize(viewController, viewControl);
            GlobalContainer.Controls.Add(ViewControl, 0, 0);
            ViewControl.Updated += View_Updated;

            GridView.ContextMenuStrip = MenuStrip;
            MoreMenuStrip.Renderer = new CustomToolStripRenderer(new CustomMenuStripColors() {
                BackColor = Color.FromArgb(35, 35, 35),
                BorderColor = Color.FromArgb(80, 80, 80),
                InnerBorderColor = Color.FromArgb(35, 35, 35),
                HoverColor = Color.FromArgb(70, 70, 70),
                DisabledHoverColor = Color.FromArgb(90, 90, 90)
            });
            InitializeMoreMenuStrip();
        }

        private void ItemExplorer_Load(object sender, EventArgs e) {
            ViewControl.UpdateView();
        }
        private void ItemExplorer_FormClosing(object sender, FormClosingEventArgs e) {
            ViewControl.ViewController.Dispose();
        }

        //Update
        private void View_Updated(object sender, EventArgs e) {
            AccountDisplayer.DisplayAccount(Application.CloudProviderCatalog.SelectedAccount);
        }

        private void InitializeMoreMenuStrip() {
            IList<ToolStripMenuItem> items = new List<ToolStripMenuItem>();

            foreach (var service in Application.CloudProviderCatalog.CloudProviders) {
                if (service.CloudServiceProvider.Commands.Count() < 1) continue;

                ToolStripMenuItem item = CreateMenuItem();

                item.Text = service.CloudServiceProvider.Name;
                item.Image = service.CloudServiceProvider.Icon;

                foreach (var command in service.CloudServiceProvider.Commands) {
                    ToolStripMenuItem dropdownItem = CreateMenuItem();

                    dropdownItem.Text = command.DisplayText;
                    dropdownItem.Image = command.Image;
                    dropdownItem.Click += (sender, e) => {
                        try {
                            command.Execute();
                        } catch (Exception exception) {
                            CustomDialog.ShowError(exception);
                        }
                    };

                    item.DropDown.Width = MoreMenuStrip.Width;
                    item.DropDown.BackColor = Color.FromArgb(35, 35, 35);

                    item.DropDownItems.Add(dropdownItem);
                }

                items.Add(item);
            }

            if (items.Count > 0) {
                MoreMenuStrip.Items.Insert(0, new ToolStripSeparator());
            }

            for (int i = items.Count - 1; i > -1; i--) {
                MoreMenuStrip.Items.Insert(0, items[i]);
            }
        }
        private static ToolStripMenuItem CreateMenuItem() {
            return new ToolStripMenuItem() {
                BackColor = Color.FromArgb(35, 35, 35),
                ForeColor = SystemColors.HighlightText
            };
        }

        //Bottom buttons
        private void ManageAccountsButton_Click(object sender, EventArgs e) {
            AccountSelector accountSelector = new AccountSelector(Application.CloudProviderCatalog, Application.CloudProviderCatalog.SelectedAccount);
            accountSelector.ShowDialog();

            if (accountSelector.DialogClosed) return;

            Application.CloudProviderCatalog.SelectedAccount = accountSelector.SelectedAccount;
            AccountDisplayer.DisplayAccount(Application.CloudProviderCatalog.SelectedAccount);
        }

        private void MoreButton_Click(object sender, EventArgs e) {
            Point lowerleft = new Point(0, MoreButton.Height);
            lowerleft = MoreButton.PointToScreen(lowerleft);
            lowerleft.Offset(-(MoreMenuStrip.Width - MoreButton.Width) / 2, -MoreButton.Height - MoreMenuStrip.Height - 5);

            MoreMenuStrip.Show(lowerleft);
        }

        private void MoveUpButton_Click(object sender, EventArgs e) {
            if (GridView.SelectedRows.Count < 1) return;

            CurrentGroup.MoveUp(CurrentView.SelectedItems.Cast<Item>().ToList());
        }
        private void MoveDownButton_Click(object sender, EventArgs e) {
            if (GridView.SelectedRows.Count < 1) return;

            CurrentGroup.MoveDown(CurrentView.SelectedItems.Cast<Item>().ToList());
        }

        private void InformationButton_Click(object sender, EventArgs e) {
            CustomDialog.ShowInformationViewer(new BuildInformationPanel(), new KeyInformationPanel(GuiApplication), new ProgramInformationPanel(GuiApplication));
        }
        private void ChangeKeyButton_Click(object sender, EventArgs e) {
            ItemUtilities.ChangeKey(GuiApplication);
        }

        private void DeselectButton_Click(object sender, EventArgs e) {
            GridView.ClearSelection();
        }
        private void CloseButton_Click(object sender, EventArgs e) {
            Close();
        }

        //MoreMenuStrip
        private void ExportItemsMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.ExportItems(Application);
        }
        private void ImportItemsMenuItem_Click(object sender, EventArgs e) {
            Group group = ItemUtilities.ImportItems(Application);
            if (group == null) return;

            CurrentGroup.Items.Add(group);
            GridControl.SelectRow(group);
        }

        private void UpdateSchemesMenuItem_Click(object sender, EventArgs e) {
            new UpdateSchemesViewer(Application, GuiApplication).ShowDialog();
        }
        private void UserSheetManagerMenuItem_Click(object sender, EventArgs e) {
            new UsersheetManager(Application).ShowDialog();
        }

        private void SettingsMenuItem_Click(object sender, EventArgs e) {
            new SettingsEditor(GuiApplication.GuiSettings, Application.CloudSettings).ShowDialog();
        }

        //MenuStrip
        private void MenuStrip_Opening(object sender, CancelEventArgs e) {
            Item item = GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as Item;

            bool onlyUpdateableItemSelected = item != null && item.ID == ItemID.UpdateableItem && CurrentView.SelectedItems.Count == 1;

            OpenInNewWindowMenuItem.Enabled = (item != null && item.ID != ItemID.UpdateableItem) || CurrentView.SelectedItems.Count < 1;

            UpdateMenuItem.Enabled = CurrentView.SelectedItems.Count > 0;
            DownloadMenuItem.Enabled = onlyUpdateableItemSelected;

            ChangePasswordMenuItem.Enabled = onlyUpdateableItemSelected;
            ManageOwnerMenuItem.Enabled = onlyUpdateableItemSelected;
            SetPathInDriveMenuItem.Enabled = onlyUpdateableItemSelected;

            CopyMenuItem.Enabled = item != null;
            PasteMenuItem.Enabled = GuiApplication.Clipboard.CopiedItems.Count > 0;

            MoveMenuItem.Enabled = item != null && CurrentView.SelectedItems.Count > 0;
            EditMenuItem.Visible = onlyUpdateableItemSelected;
            RenameMenuItem.Enabled = CurrentView.SelectedItems.Count < 2;
            DeleteMenuItem.Enabled = item != null && CurrentView.SelectedItems.Count > 0;

            PropertiesMenuItem.Enabled = CurrentView.SelectedItems.Count < 2;
        }

        private void NewGroupMenuItem_Click(object sender, EventArgs e) {
            Group group = new Group() {
                Name = "New group",
            };

            AddNewItem(group);
        }
        private void NewFolderMenuItem_Click(object sender, EventArgs e) {
            Folder folder = new Folder(Application) {
                Name = "New folder"
            };
            folder.Settings.Account = Application.CloudProviderCatalog.SelectedAccount;

            if (GuiApplication.GuiSettings.DefaultPasswordLength > 0) {
                folder.Settings.Password = PasswordGeneratorDialogProfile.NewPassword.PasswordGenerator.Generate(GuiApplication.GuiSettings.DefaultPasswordLength);
            }

            AddNewItem(folder);
        }
        private void NewFilteredFolderMenuItem_Click(object sender, EventArgs e) {
            FilteredFolder filteredFolder = new FilteredFolder(Application) {
                Name = "New filtered folder",
            };
            filteredFolder.Settings.Account = Application.CloudProviderCatalog.SelectedAccount;

            if (GuiApplication.GuiSettings.DefaultPasswordLength > 0) {
                filteredFolder.Settings.Password = PasswordGeneratorDialogProfile.NewPassword.PasswordGenerator.Generate(GuiApplication.GuiSettings.DefaultPasswordLength);
            }

            AddNewItem(filteredFolder);
        }
        private void NewItemBundleMenuItem_Click(object sender, EventArgs e) {
            ItemBundle itemBundle = new ItemBundle(Application) {
                Name = "New item bundle",
            };
            itemBundle.Settings.Account = Application.CloudProviderCatalog.SelectedAccount;

            if (GuiApplication.GuiSettings.DefaultPasswordLength > 0) {
                itemBundle.Settings.Password = PasswordGeneratorDialogProfile.NewPassword.PasswordGenerator.Generate(GuiApplication.GuiSettings.DefaultPasswordLength);
            }

            AddNewItem(itemBundle);
        }

        private void OpenInNewWindowMenuItem_Click(object sender, EventArgs e) {
            Group group = GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as Group;

            new ItemExplorer(group ?? CurrentGroup, Application, GuiApplication).Show();
        }

        private void UpdateMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.UpdateItems(CurrentView.SelectedItems.Cast<Item>().ToList(), GuiApplication.GuiSettings.ProgressBarColor);
        }
        private void DownloadMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.DownloadItem(GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as UpdateableItem, GuiApplication.GuiSettings.ProgressBarColor);
        }

        private void ChangePasswordMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.ChangeUpdateableItemPassword(GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as UpdateableItem);
        }
        private void ManageOwnerMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.ManagerOwner(GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as UpdateableItem, Application.CloudProviderCatalog);
        }
        private void SetPathInDriveMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.SetPath(GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as UpdateableItem);
        }

        private void CopyMenuItem_Click(object sender, EventArgs e) {
            GuiApplication.Clipboard.SetClipboard(CurrentView.SelectedItems.Cast<Item>().ToList());
        }
        private void PasteMenuItem_Click(object sender, EventArgs e) {
            Group parent = CurrentGroup;

            Item item = GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as Item;
            if (item != null && item.ID == ItemID.Group) parent = item as Group;

            ItemUtilities.Paste(GuiApplication.Clipboard.CopiedItems.Cast<Item>(), parent);
        }

        private void MoveMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.Move(CurrentView.SelectedItems.Cast<Item>().ToList(), CurrentGroup);
        }
        private void EditMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.EditItem(GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as Item);
        }
        private void RenameMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.RenameItem(GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as Item ?? CurrentGroup);
        }
        private void DeleteMenuItem_Click(object sender, EventArgs e) {
            ItemUtilities.Delete(CurrentView.SelectedItems.Cast<Item>().ToList(), CurrentGroup);
        }

        private void PropertiesMenuItem_Click(object sender, EventArgs e) {
            if (CurrentView.SelectedItems.Count < 1) {
                ItemUtilities.OpenGroupProperties(CurrentGroup, Application.UsersheetCatalog);
                return;
            }

            ItemUtilities.OpenProperties(GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as Item, Application.UsersheetCatalog);
        }

        //Functions
        private void AddNewItem(Item item) {
            CurrentGroup.Items.Add(item);

            GridView.ClearSelection();
            GridControl.SelectRow(item);

            ItemUtilities.EditItem(item);
        }
    }
}
