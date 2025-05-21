using System;

namespace CloudBackup {
    public abstract class Item : ICloneable {
        public ItemID ID { get; }
        public Group Parent { get; internal set; }

        public string Name {
            get => _name;
            set {
                if (_name == value) return;

                _name = value;
                RaiseOnContentsChanged(true);
                RaiseOnNameChanged();
            }
        }
        private string _name;

        public DateTime CreationDate {
            get => _creationDate;
            set {
                if (_creationDate == value) return;

                _creationDate = value;
                RaiseOnContentsChanged(false);
            }
        }
        private DateTime _creationDate;

        public DateTime LastModificationDate { get; set; }

        public event EventHandler OnContentsChanged;
        public event EventHandler OnNameChanged;
        public event EventHandler OnIdChanged;
        public event EventHandler OnDeletion;

        private bool _updateModeActivated = false;
        private bool _updateOccured = false;
        private bool _modifyDate = false;

        protected Item(ItemID id) {
            ID = id;
            _name = string.Empty;
            _creationDate = DateTime.Now;
            LastModificationDate = DateTime.Now;
        }

        internal void RaiseOnContentsChanged(bool modifyDate) {
            if (_updateModeActivated) {
                _updateOccured = true;
                if (modifyDate) _modifyDate = true;
            } else {
                if (modifyDate) LastModificationDate = DateTime.Now;

                OnContentsChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        internal void RaiseOnNameChanged() {
            OnNameChanged?.Invoke(this, EventArgs.Empty);
        }
        internal void RaiseOnIdChanged() {
            OnIdChanged?.Invoke(this, EventArgs.Empty);
        }
        internal void RaiseOnDeletion() {
            OnDeletion?.Invoke(this, EventArgs.Empty);
        }

        public void ApplyUpdateMode() {
            _updateModeActivated = true;
        }
        public void SuspendUpdateMode() {
            _updateModeActivated = false;

            if (_updateOccured) {
                _updateOccured = false;

                bool modifyDate = _modifyDate;
                _modifyDate = false;

                RaiseOnContentsChanged(modifyDate);
            }
        }
        public abstract object Clone();
        protected virtual void CloneToObject(Item item) {
            item._name = Name;
        }

        public abstract bool Equals(Item other);
        protected bool ObjectEquals(Item item) {
            return Name == item.Name && CreationDate == item.CreationDate && LastModificationDate == item.LastModificationDate;
        }
    }
}
