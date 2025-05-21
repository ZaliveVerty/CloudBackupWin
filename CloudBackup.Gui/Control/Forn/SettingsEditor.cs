using System;
using System.Windows.Forms;
using CustomDialogs;

namespace CloudBackup.Gui {
    public partial class SettingsEditor : Form {
        public GuiSettings GuiSettings { get; set; }
        public CloudSettings Settings { get; set; }

        private bool _canceled = false;

        public SettingsEditor(GuiSettings guiSettings, CloudSettings settings) {
            InitializeComponent();

            GuiSettings = guiSettings;
            Settings = settings;

            DefaultPasswordLengthTextBox.Text = GuiSettings.DefaultPasswordLength.ToString();
            ZipPathTextBox.Text = Settings.ZipPath;
            ProgressBarColorPanel.BackColor = GuiSettings.ProgressBarColor;
        }

        private void ProgressBarColorPanel_MouseDown(object sender, MouseEventArgs e) {
            ColorDialog colorDialog = new ColorDialog() {
                Color = ProgressBarColorPanel.BackColor
            };
            colorDialog.ShowDialog();

            ProgressBarColorPanel.BackColor = colorDialog.Color;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (_canceled) return;

            if (!ValidateContents(false) || CheckForChanges()) {
                SaveConfirmation result = CustomDialog.ShowSaveConfirmation();

                if (result == SaveConfirmation.Save) {
                    if (ValidateContents()) Save();
                    else e.Cancel = true;
                } else if (result == SaveConfirmation.Cancel) {
                    e.Cancel = true;
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            if (!ValidateContents()) return;

            Save();
            Close();
        }
        private void Cancelbutton_Click(object sender, EventArgs e) {
            _canceled = true;
            Close();
        }

        private bool ValidateContents(bool showErrorMessage = true) {
            if (!int.TryParse(DefaultPasswordLengthTextBox.Text, out int result)) {
                if (showErrorMessage) {
                    CustomDialog.ShowError("Error", "Cannot parse default password length.");
                }

                return false;
            }

            return true;
        }
        private bool CheckForChanges() {
            return GuiSettings.DefaultPasswordLength != int.Parse(DefaultPasswordLengthTextBox.Text) || Settings.ZipPath != ZipPathTextBox.Text || GuiSettings.ProgressBarColor != ProgressBarColorPanel.BackColor;
        }
        private void Save() {
            GuiSettings.ApplyUpdateMode();

            GuiSettings.DefaultPasswordLength = int.Parse(DefaultPasswordLengthTextBox.Text);
            GuiSettings.ProgressBarColor = ProgressBarColorPanel.BackColor;

            GuiSettings.SuspendUpdateMode();

            Settings.ZipPath = ZipPathTextBox.Text;
        }
    }
}
