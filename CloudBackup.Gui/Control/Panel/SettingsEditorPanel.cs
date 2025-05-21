using System;
using System.Windows.Forms;
using CustomDialogs;

namespace CloudBackup.Gui {
    public partial class SettingsEditorPanel : UserControl {
        public CloudApplication Application { get; set; }
        public Settings Settings { get; set; }
        public UpdateableItem Owner { get; set; }

        public SettingsEditorPanel() {
            InitializeComponent();
        }

        public void SetSettings(CloudApplication application, Settings settings, UpdateableItem owner) {
            Application = application;
            Settings = settings;
            Owner = owner;

            AccountDisplayer.DisplayAccount(Settings.Account);
        }

        private void SelectAccountButton_Click(object sender, EventArgs e) {
            AccountSelector accountSelector = new AccountSelector(Application.CloudProviderCatalog, Settings.Account);
            accountSelector.ShowDialog();

            Settings.Account = accountSelector.SelectedAccount;
            AccountDisplayer.DisplayAccount(Settings.Account);
        }
        private void ChangePasswordButton_Click(object sender, EventArgs e) {
            InputResult<string> result = DialogUtilities.ShowPasswordInput(Owner.Name, Settings.Password);
            if (result.DialogClosed) return;

            Settings.Password = result.Value;
        }
        private void ChangePathInDriveButton_Click(object sender, EventArgs e) {
            Func<string, bool> validator = path => {
                if (path.IsValidPath()) return true;

                CustomDialog.ShowError("Error", "Path is invalid.");
                return false;
            };

            InputResult<string> result = CustomDialog.ShowTextInput($"{Owner.Name} | Path in drive",
                "Edit item's path in drive.", Settings.PathInDrive, Properties.Resources._64pxTreeView, validator);
            if (result.DialogClosed) return;

            Settings.PathInDrive = result.Value;
        }
        private void ChangeLinkButton_Click(object sender, EventArgs e) {
            InputResult<string> result = DialogUtilities.ShowLinkInput(Owner.Name, Settings.Link);
            if (result.DialogClosed) return;

            Settings.Link = result.Value;
        }
    }
}
