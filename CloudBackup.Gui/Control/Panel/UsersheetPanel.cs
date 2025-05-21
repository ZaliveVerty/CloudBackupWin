using System;
using System.Windows.Forms;
using CloudServiceProvider;
using CustomDialogs;

namespace CloudBackup.Gui {
    public partial class UsersheetPanel : UserControl {
        public CloudApplication Application { get; set; }
        public IAccount Account { get; set; }

        public UsersheetPanel(CloudApplication application, IAccount account) {
            InitializeComponent();

            Application = application;
            Account = account;

            AccountPanel.DisplayAccount(Account);

            new MouseControl(this, DownloadLink, OpenInBrowserLink);

            OpenInBrowserLink.Enabled = Application.UsersheetCatalog.GetUsersheet(account) != null;
        }

        private void DownloadLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            ItemUtilities.DownloadUserSheet(Application, Account);
        }
        private void OpenInBrowserLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            string link = Application.UsersheetCatalog.GetUsersheet(Account).Link;
            ItemUtilities.OpenInBrowser(link);
        }
    }
}
