using System;
using System.IO;
using System.Windows.Forms;
using CustomDialogs;

namespace CloudRecovery.Gui {
    public partial class ExtractItemForm : Form {
        public ZippedItem ZippedItem { get; }
        public Settings Settings { get; set; }

        public ExtractItemForm(ZippedItem item, Settings settings) {
            InitializeComponent();

            ZippedItem = item;
            Settings = settings;

            ArchivePathTextBox.Text = ZippedItem.FilePath;
            DirectoryPathTextBox.Text = Settings.LastDirectory;
        }

        private void BrowseArchiveButton_Click(object sender, EventArgs e) {
            OpenFileDialog.ShowDialog();
            ArchivePathTextBox.Text = OpenFileDialog.FileName;
        }
        private void BrowseDirectoryButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog.ShowDialog();
            DirectoryPathTextBox.Text = FolderBrowserDialog.SelectedPath;
        }

        private void ExtractButton_Click(object sender, EventArgs e) {
            if (!ValidateContents()) return;

            Settings.LastDirectory = DirectoryPathTextBox.Text;

            ItemUtilities.Extract(ZippedItem, ArchivePathTextBox.Text, Settings);
            Close();
        }

        private bool ValidateContents() {
            if (string.IsNullOrEmpty(ArchivePathTextBox.Text)) {
                CustomDialog.ShowError("Error", "Archive path cannot be empty.");
                return false;
            }

            if (!File.Exists(ArchivePathTextBox.Text)) {
                CustomDialog.ShowError("Error", "Archive doesn't exist.");
                return false;
            }

            if (string.IsNullOrEmpty(DirectoryPathTextBox.Text)) {
                CustomDialog.ShowError("Error", "Output directory path cannot be empty.");
                return false;
            }

            return true;
        }

        private void ExtractItemForm_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        private void ExtractItemForm_DragDrop(object sender, DragEventArgs e) {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            FileAttributes attr = File.GetAttributes(files[0]);

            if (attr.HasFlag(FileAttributes.Directory)) DirectoryPathTextBox.Text = files[0];
            else ArchivePathTextBox.Text = files[0];
        }
    }
}
