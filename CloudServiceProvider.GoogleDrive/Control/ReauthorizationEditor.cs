using System;
using System.Linq;
using System.Windows.Forms;
using CustomDialogs;

namespace CloudServiceProvider.GoogleDrive {
    public partial class ReauthorizationEditor : Form {
        public UserAccountController UserAccountController { get; set; }
        public TokenCatalog TokenCatalog { get; set; }

        public ReauthorizationEditor(UserAccountController userAccountController, TokenCatalog tokenCatalog) {
            InitializeComponent();

            UserAccountController = userAccountController;
            TokenCatalog = tokenCatalog;

            Icon = ImageToIconConverter.Convert(Properties.Resources.GoogleDriveLogo, 64, 64);
        }

        private void ReauthorizationForm_Load(object sender, EventArgs e) {
            LoadDialog();
            GridView.ClearSelection();
        }
        private void LoadDialog() {
            GridView.Rows.Clear();

            for (int i = 0; i < TokenCatalog.Tokens.Count; i++) {
                var pair = TokenCatalog.Tokens.ElementAt(i);

                GridView.Rows.Add(pair.Key, pair.Value.Email, $"{pair.Value.Created} ({(DateTime.Now - pair.Value.Created).ToRelativeTimeString()})",  "Reauthorize");
                GridView.Rows[i].Tag = pair.Key;
            }

            GridView.ClearSelection();
        }

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (GridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) {
                UserAccountController.Reauthorize((string)GridView.Rows[e.RowIndex].Tag);

                LoadDialog();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e) {
            LoadDialog();
        }
        private void CloseButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
