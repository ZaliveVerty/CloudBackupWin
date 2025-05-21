using System;
using System.Text;
using System.Windows.Forms;
using CustomDialogs;

namespace CloudServiceProvider.GoogleDrive {
    public partial class IdResourceEditor : Form {
        public IdCacheCatalog IdCacheCatalog { get; set; }

        public IdResourceEditor(IdCacheCatalog idCacheCatalog) {
            InitializeComponent();

            IdCacheCatalog = idCacheCatalog;
            Icon = ImageToIconConverter.Convert(Properties.Resources._16pxCache, 64, 64);
        }

        private void IdResourceViewer_Load(object sender, EventArgs e) {
            LoadDialog();
            GridView.ClearSelection();
        }

        private void LoadDialog() {
            foreach (var pair in IdCacheCatalog.IdCache) {
                EmailComboBox.Items.Add(pair.Key);
            }
        }
        private void LoadGrid(IdCache ids) {
            GridView.Rows.Clear();

            foreach (var pair in ids.Ids) {
                GridView.Rows.Add(pair.Key, pair.Value);
            }

            GridView.ClearSelection();
        }

        private void EmailComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            string email = EmailComboBox.SelectedItem as string;

            LoadGrid(IdCacheCatalog.IdCache[email]);
        }
        private void ClearCacheButton_Click(object sender, EventArgs e) {
            if (EmailComboBox.SelectedItem == null) return;

            string result = CustomDialog.ShowMessage(
                "Clear cache",
                "Are you sure you want to clear the cache?",
                Properties.Resources._64pxRemoveNamespace, System.Media.SystemSounds.Hand, "Yes, clear cache", "No");

            if (result == "Yes, clear cache") {
                string email = EmailComboBox.SelectedItem as string;

                IdCacheCatalog.IdCache[email].Ids.Clear();

                RefreshDialog();
            }
        }

        private void CopyToClipboardLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (EmailComboBox.SelectedItem == null ||
                !IdCacheCatalog.IdCache.TryGetValue(EmailComboBox.SelectedItem as string, out IdCache ids)) {

                return;
            }

            StringBuilder builder = new StringBuilder("File name\tFile ID\n");
            foreach (var pair in ids.Ids) {
                builder.AppendLine($"{pair.Key}\t{pair.Value}");
            }

            string output = builder.ToString();
            if (output != null) Clipboard.SetText(output);
        }

        private void RefreshButton_Click(object sender, EventArgs e) {
            RefreshDialog();
        }
        private void CloseButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void RefreshDialog() {
            if (EmailComboBox.SelectedItem != null &&
                    IdCacheCatalog.IdCache.TryGetValue(EmailComboBox.SelectedItem as string, out IdCache ids)) {

                LoadGrid(ids);
            } else {
                GridView.Rows.Clear();
            }
        }
    }
}
