using System;
using System.Windows.Forms;

namespace CloudBackup.Gui {
    public partial class UsersheetManager : Form {
        public CloudApplication Application { get; set; }

        public UsersheetManager(CloudApplication application) {
            InitializeComponent();

            Application = application;

            foreach (var service in Application.CloudProviderCatalog.CloudProviders) {
                foreach (var account in service.Accounts) {
                    UsersheetPanel panel = new UsersheetPanel(Application, account) {
                        Dock = DockStyle.Top
                    };

                    PanelContainer.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    PanelContainer.Controls.Add(panel, 0, PanelContainer.Controls.Count);
                }
            }
        }

        private void DoneButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
