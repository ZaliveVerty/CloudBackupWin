using System;
using CommonUtilities;

namespace CloudBackup {
    public class SchemeCatalog : ObservableResource {
        public ObservableList<Scheme> Schemes { get; private set; }

        public SchemeCatalog() {
            Schemes = new ObservableList<Scheme>();
            Schemes.OnItemsAdd += (sender, schemes) => {
                foreach (Scheme scheme in schemes) {
                    scheme.OnContentsChanged += Scheme_OnContentsChanged;
                }

                RaiseOnContentsChanged();
            };
            Schemes.OnItemsRemove += (sender, schemes) => {
                foreach (Scheme scheme in schemes) {
                    scheme.OnContentsChanged -= Scheme_OnContentsChanged;
                }

                RaiseOnContentsChanged();
            };
        }

        private void Scheme_OnContentsChanged(object sender, EventArgs e) {
            RaiseOnContentsChanged();
        }

        public void SwapChildItems(Scheme child, Scheme otherChild) {
            int index = Schemes.IndexOf(child);
            int otherIndex = Schemes.IndexOf(otherChild);

            ApplyUpdateMode();

            Schemes[index] = otherChild;
            Schemes[otherIndex] = child;

            SuspendUpdateMode();
        }
    }
}
