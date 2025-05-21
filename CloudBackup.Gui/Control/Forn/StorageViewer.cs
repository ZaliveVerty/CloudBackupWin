using System;
using System.Drawing;
using System.Windows.Forms;
using CloudServiceProvider;
using CustomDialogs;

namespace CloudBackup.Gui {
    public partial class StorageViewer : Form {
        public ICloudStorageInformation StorageInformation { get; }

        public StorageViewer(ICloudStorageInformation storageInformation) {
            InitializeComponent();

            StorageInformation = storageInformation;

            DisplayInformation();
        }

        private void DisplayInformation() {
            UsedLabel.Text = $"Used: {StorageToString(StorageInformation.UsedBytes)}";

            if (StorageInformation.StorageType == StorageType.Unlimited) {
                CapacityLabel.Text = "Capacity: unlimited";
                PercentageLabel.Text = "0%";

                UsedPanel.BackColor = Color.Gray;
                UsedPanel.Width = BarPanel.Width;
            } else {
                CapacityLabel.Text = $"Capacity: {StorageToString(StorageInformation.Capacity)}";
                PercentageLabel.Text = $"{(StorageInformation.UsedBytes / (double)StorageInformation.Capacity * 100).ToString("N2")}%";

                double ratio = StorageInformation.UsedBytes / (double)StorageInformation.Capacity;
                UsedPanel.Width = (int)(ratio * BarPanel.Width);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            Close();
        }

        private static string StorageToString(long storage) {
            string output = storage.ConvertToStorage();

            return $"{output} ({storage.ToString("#,0")} bytes)";
        }
    }
}
