using System;
using CommonUtilities;

namespace CloudBackup {
    public class CloudSettings : ObservableResource {
        public string ZipPath {
            get => _zipPath;
            set {
                if (_zipPath == value) return;

                _zipPath = value;
                RaiseOnContentsChanged();
            }
        }
        private string _zipPath;

        public CloudSettings() {
            _zipPath = string.Empty;
        }
    }
}
