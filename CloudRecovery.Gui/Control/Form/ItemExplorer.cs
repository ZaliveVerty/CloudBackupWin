using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CustomDialogs;

namespace CloudRecovery.Gui {
    public partial class ItemExplorer : Form {
        public Group Group { get; set; }
        public Group CurrentGroup => CurrentView.ViewNode.Node as Group;

        public IView CurrentView => ViewControl.ViewController.CurrentView;

        public ItemExplorerGridControl GridControl { get; set; }
        public DataGridView GridView {
            get => GridControl.DataGridView;
        }

        public ViewControl ViewControl { get; set; }

        public Settings Settings { get; set; }

        public ItemExplorer(Group group) {
            InitializeComponent();

            Group = group;
            Settings = new Settings();

            ViewController viewController = new ViewController(new GroupViewNode(Group));
            GridControl = new ItemExplorerGridControl(viewController);

            ViewControl = new ViewControl() {
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

            StandardVerticalViewControl viewControl = new StandardVerticalViewControl(ViewControl, GridControl);
            viewControl.HeaderToolBar.ViewController = viewController;
            viewControl.HeaderToolBar.NodeCreator = item => new GroupNode(item as Group);

            ViewControl.Initialize(viewController, viewControl);
            Controls.Add(ViewControl);

            GridView.CellClick += GridView_CellClick;
            GridView.ContextMenuStrip = MenuStrip;
        }

        private void ItemExplorer_Load(object sender, EventArgs e) {
            ViewControl.UpdateView();
        }

        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 3 && CurrentView.SelectedItems.ElementAt(0) is ZippedItem zItem) OpenInBrowser(zItem);
            else if (e.ColumnIndex == 4 && CurrentView.SelectedItems.ElementAt(0) is ZippedItem z) ExtractSimple(z);
        }

        //DragDrop
        private void ItemExplorer_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        private void ItemExplorer_DragDrop(object sender, DragEventArgs e) {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files) {
                string ext = Path.GetExtension(file).ToLower();

                if (ext == ".7z") {
                    List<ZippedItem> zippedItems = new List<ZippedItem>();
                    Group.GetAllZippedItems(zippedItems);

                    string id = Path.GetFileName(file);
                    ZippedItem item = zippedItems.Find(x => x.Id == id);

                    if (item != null) new ExtractItemForm(item, Settings).ShowDialog();
                }
            }
        }

        //MenuStrip
        private void MenuStrip_Opening(object sender, CancelEventArgs e) {
            Item item = GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as Item;

            bool canOpenInBrowser = CurrentView.SelectedItems.Count == 1 && item != null && item is ZippedItem zItem && !string.IsNullOrEmpty(zItem.Link);
            bool canExtract = CurrentView.SelectedItems.Count == 1 && item != null && item is ZippedItem z && !string.IsNullOrEmpty(z.FilePath);

            OpenInBrowserMenuItem.Enabled = canOpenInBrowser;
            ExtractMenuItem.Enabled = canExtract;
            ExtractWithOptionsMenuItem.Enabled = CurrentView.SelectedItems.Count == 1 && item != null; ;
            ShowPasswordMenuItem.Enabled = CurrentView.SelectedItems.Count == 1 && item != null && item is ZippedItem;
        }

        private void OpenInBrowserMenuItem_Click(object sender, EventArgs e) {
            OpenInBrowser(GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as ZippedItem);
        }
        private void ExtractMenuItem_Click(object sender, EventArgs e) {
            ExtractSimple(GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as ZippedItem);
        }
        private void ExtractWithOptionsMenuItem_Click(object sender, EventArgs e) {
            new ExtractItemForm(GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as ZippedItem, Settings).ShowDialog();
        }
        private void ShowPasswordMenuItem_Click(object sender, EventArgs e) {
            ZippedItem item = GridControl.GetItemFromPoint(MenuStrip.Bounds.Location) as ZippedItem;

            CustomDialog.ShowMessage($"Password | {item.DisplayName}", item.Password, Properties.Resources._64pxKey);
        }
        private void Change7ZipPathMenuitem_Click(object sender, EventArgs e) {
            InputResult<string> result = CustomDialog.ShowTextInput("7zip path", "7zip path", Settings.ZipPath);
            if (result.DialogClosed) return;

            Settings.ZipPath = result.Value;
        }

        //Functions
        private void ExtractSimple(ZippedItem item) {
            if (string.IsNullOrEmpty(item.FilePath)) return;

            if (string.IsNullOrEmpty(Settings.LastDirectory)) {
                InputResult<string> result = CustomDialog.ShowBrowser(BrowseType.BrowseFolder);
                if (result.DialogClosed) return;

                Settings.LastDirectory = result.Value;
            }

            ItemUtilities.Extract(item, item.FilePath, Settings);
        }
        private void OpenInBrowser(ZippedItem item) {
            if (string.IsNullOrEmpty(item.Link)) return;

            try {
                using (Process process = new Process()) {
                    process.StartInfo.UseShellExecute = true;
                    process.StartInfo.FileName = item.Link;
                    process.Start();
                }
            } catch {
                CustomDialog.ShowError("Error", "There was an error opening the link.");
            }
        }
    }
}
