using System;
using System.Windows.Forms;
using CustomDialogs;

namespace CloudServiceProvider.GoogleCloud {
    public partial class CredentialsCatalogEditor : Form {
        public CredentialsCatalog CredentialsCatalog { get; private set; }

        public CredentialsCatalogEditor(CredentialsCatalog credentialsCatalog) {
            InitializeComponent();

            CredentialsCatalog = credentialsCatalog;

            Icon = ImageToIconConverter.Convert(Properties.Resources._16pxCredentials, 64, 64);

            LoadDialog();
        }

        private void CredentialsCatalogEditor_Load(object sender, EventArgs e) {
            GridView.ClearSelection();
        }

        private void LoadDialog() {
            GridView.Rows.Clear();

            for (int i = 0; i < CredentialsCatalog.Credentials.Count; i++) { 
                Credentials credentials = CredentialsCatalog.Credentials[i];

                GridView.Rows.Add(credentials.Name, credentials.Email);
                GridView.Rows[i].Tag = credentials;
            }
        }
        private void GridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            new CredentialsEditor(GridView.SelectedRows[0].Tag as Credentials).ShowDialog();
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
