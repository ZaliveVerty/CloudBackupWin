using System;
using System.Threading;
using CloudServiceProvider;
using CustomDialogs;

namespace CloudBackup.Gui {
    public partial class AccountPanel : ClickablePanel {
        public IAccount Account { get; set; }
        private ICloudStorageInformation _storageInformation;

        public AccountPanel(IAccount account) {
            InitializeComponent();

            MenuStrip.Renderer = new CustomToolStripRenderer();

            Account = account;

            ProfilePictureBox.Image = account.ProfilePicture;
            DisplayNameLabel.Text = account.DisplayName;
            EmailLabel.Text = account.Email;

            MouseControl = new MouseControl(this);
            MouseControl.Click += OnClick;
        }

        private void AccountPanel_Load(object sender, EventArgs e) {
            SetStorageInformation();
        }

        private void SetStorageInformation() {
            RefreshButton.Visible = false;
            FreeSpaceLabel.Text = "";
            LoadingPictureBox.Visible = true;

            Thread thread = new Thread(() => {
                try {
                    _storageInformation = Account.CloudServiceProvider.ProvideStorageInformation(Account);

                    Invoke(new Action(() => {
                        if (_storageInformation.StorageType == StorageType.Unlimited) {
                            FreeSpaceLabel.Text = "Free space: unlimited";
                        } else {
                            FreeSpaceLabel.Text = $"Free space: {(_storageInformation.Capacity - _storageInformation.UsedBytes).ConvertToStorage()}";
                        }

                        LoadingPictureBox.Visible = false;
                        RefreshButton.Visible = true;
                    }));
                } catch { 
                
                }
            });
            thread.Start();
        }

        private void OnClick(object sender, EventArgs e) {
            CallUserClick(this, EventArgs.Empty);
        }
        private void StorageInformationMenuItem_Click(object sender, EventArgs e) {
            new StorageViewer(_storageInformation).ShowDialog();
        }

        private void RefreshButton_Click(object sender, EventArgs e) {
            SetStorageInformation();
        }
    }
}
