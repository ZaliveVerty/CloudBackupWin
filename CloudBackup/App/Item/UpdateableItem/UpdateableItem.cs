using System;
using System.IO;
using CommonUtilities;

namespace CloudBackup {
    public abstract class UpdateableItem : Item {
        public UpdateableItemID UpdateableItemID { get; }

        public string GeneratedID { get; internal set; }
        public Settings Settings {
            get => _settings;
            set {
                if (_settings == value) return;

                if (_settings != null) _settings.OnContentsChanged -= Settings_OnContentsChanged;
                _settings = value;
                _settings.OnContentsChanged += Settings_OnContentsChanged;
            }
        }
        private Settings _settings;
        public DateTimeHistory UpdateHistory { get; private set; }

        public CloudApplication Application { get; private set; }

        protected UpdateableItem(CloudApplication application, UpdateableItemID fileId) : base(ItemID.UpdateableItem) {
            UpdateableItemID = fileId;
            Application = application;
            GeneratedID = ShortIdUtilities.GenerateShortId();

            Settings = new Settings();

            UpdateHistory = new DateTimeHistory(new DateTime[0]);
            UpdateHistory.OnContentsChanged += UpdateHistory_OnContentsChanged;
        }

        private void UpdateHistory_OnContentsChanged(object sender, EventArgs e) {
            RaiseOnContentsChanged(false);
        }
        private void Settings_OnContentsChanged(object sender, EventArgs e) {
            RaiseOnContentsChanged(true);
        }

        public bool Update(IProgress<ProgressReport> progress) {
            return Application.Updater.Update(this, progress);
        }
        public abstract CompressionResult ProvideFinishedLocalFile(IProgress<float> progress);

        public bool Download(string outputDirectory, IProgress<ProgressReport> progress) {
            return Application.Updater.Download(this, outputDirectory, progress);
        }
        public bool Delete() {
            return Application.Updater.Delete(this);
        }

        public void ChangeID(string uniqueID) {
            if (GeneratedID == uniqueID) return;

            GeneratedID = uniqueID;
            RaiseOnContentsChanged(true);
            RaiseOnIdChanged();
        }

        protected void CloneToObject(UpdateableItem item) {
            base.CloneToObject(item);

            item.Settings = Settings.Clone();
        }
        protected bool ObjectEquals(UpdateableItem item) {
            return base.ObjectEquals(item) && UpdateableItemID != item.UpdateableItemID && Settings.Equals(item.Settings);
        }
    }
}
