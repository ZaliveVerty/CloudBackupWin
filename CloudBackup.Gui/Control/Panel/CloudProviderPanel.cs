using System;
using CustomDialogs;

namespace CloudBackup.Gui {
    public partial class CloudProviderPanel : ClickablePanel {
        public CloudProvider CloudProvider { get; set; }

        public CloudProviderPanel(CloudProvider cloudProvider) {
            InitializeComponent();

            CloudProvider = cloudProvider;

            CloudLogoPictureBox.BackgroundImage = cloudProvider.CloudServiceProvider.Icon;
            CloudNameLabel.Text = cloudProvider.CloudServiceProvider.Name;

            MouseControl = new MouseControl(this);
            MouseControl.Click += OnClick;
        }

        private void OnClick(object sender, EventArgs e) {
            CallUserClick(this, EventArgs.Empty);
        }
    }
}
