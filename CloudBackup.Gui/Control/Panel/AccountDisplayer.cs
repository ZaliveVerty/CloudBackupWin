using System;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using CloudServiceProvider;
using CustomDialogs;

namespace CloudBackup.Gui {
    public partial class AccountDisplayer : UserControl {
        public IAccount Account { get; set; }

        public AccountDisplayer() {
            InitializeComponent();

            SeperatorLabel.Visible = false;
        }

        public void DisplayAccount(IAccount account) {
            Account = account;
            SeperatorLabel.Visible = Account != null;

            if (Account == null) {
                AccountPictureBox.Image = null;
                ProviderNameLabel.Text = "";
                ProfilePictureBox.Image = null;
                EmailLabel.Text = "";

                return;
            }

            AccountPictureBox.Image = Account.CloudServiceProvider.Icon.Resize(AccountPictureBox.Width, AccountPictureBox.Height, InterpolationMode.HighQualityBicubic);
            ProviderNameLabel.Text = Account.CloudServiceProvider.Name;
            ProfilePictureBox.Image = Account.ProfilePicture;
            EmailLabel.Text = Account.Email;
        }
    }
}
