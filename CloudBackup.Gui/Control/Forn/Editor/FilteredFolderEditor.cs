using System;
using System.IO;
using System.Windows.Forms;
using CustomDialogs;

namespace CloudBackup.Gui {
    public partial class FilteredFolderEditor : Form {
        public FilteredFolder Folder { get; set; }
        public CloudApplication Application { get; set; }

        private bool _close = false;

        public FilteredFolderEditor(FilteredFolder folder) {
            InitializeComponent();

            Folder = folder;
            Application = Folder.Application;

            LoadEditor();
        }

        private void LoadEditor() {
            Text = $"{Folder.Name} | Filtered folder";

            PathTextBox.Text = Folder.FolderPath;
            NameTextBox.Text = Folder.Name;

            FilterTextBox.Text = Folder.Filter;
            ExcludeCheckBox.Checked = Folder.Exclude;
            CaseSensitiveCheckBox.Checked = Folder.CaseSensitive;

            SettingsEditor.SetSettings(Application, Folder.Settings.Clone(), Folder);
        }

        //DragDrop
        private void FilteredFolderEditor_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        private void FilteredFolderEditor_DragDrop(object sender, DragEventArgs e) {
            string[] folders = (string[])e.Data.GetData(DataFormats.FileDrop);

            PathTextBox.Text = folders[0];
            NameTextBox.Text = Path.GetFileName(folders[0]);
        }

        private void BrowseButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog.ShowDialog();
            PathTextBox.Text = FolderBrowserDialog.SelectedPath;
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            if (!ValidateContent()) return;
            SaveChanges();

            _close = true;
            Close();
        }
        private void CancelButton_Click(object sender, EventArgs e) {
            _close = true;
            Close();
        }

        private void FilteredFolderEditor_FormClosing(object sender, FormClosingEventArgs e) {
            if (_close || !CheckForChanges()) return;

            SaveConfirmation result = CustomDialog.ShowSaveConfirmation();
            if (result == SaveConfirmation.Close || result == SaveConfirmation.Cancel) {
                e.Cancel = true;
                return;
            }
            if (result == SaveConfirmation.DontSave) return;

            if (!ValidateContent()) {
                e.Cancel = true;
                return;
            }

            SaveChanges();
        }

        private bool CheckForChanges() {
            if (NameTextBox.Text != Folder.Name || !SettingsEditor.Settings.Equals(Folder.Settings)) return true;
            if (FilterTextBox.Text != Folder.Filter || ExcludeCheckBox.Checked != Folder.Exclude ||
                CaseSensitiveCheckBox.Checked != Folder.CaseSensitive) return true;

            return PathTextBox.Text != Folder.FolderPath;
        }
        private bool ValidateContent() {
            return NameUtilities.ValidateName(Folder.GetTypeString(), NameTextBox.Text);
        }
        private void SaveChanges() {
            Folder.ApplyUpdateMode();

            Folder.Name = NameTextBox.Text;
            Folder.Settings = SettingsEditor.Settings;

            Folder.Filter = FilterTextBox.Text;
            Folder.Exclude = ExcludeCheckBox.Checked;
            Folder.CaseSensitive = CaseSensitiveCheckBox.Checked;

            Folder.FolderPath = PathTextBox.Text;

            Folder.SuspendUpdateMode();
        }
    }
}
