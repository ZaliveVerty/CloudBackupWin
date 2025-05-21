using System;
using System.Collections.Generic;
using CommonUtilities;

namespace CloudServiceProvider.GoogleDrive {
    public class TokenCatalog : ObservableResource {
        public ObservableDictionary<string, Token> Tokens { get; set; }

        public TokenCatalog() { 
            Tokens = new ObservableDictionary<string, Token>();
            Tokens.OnItemsAdd += (sender, pairs) => {
                foreach (KeyValuePair<string, Token> pair in pairs) {
                    pair.Value.OnContentsChanged += Token_OnContentsChanged;
                }
                RaiseOnContentsChanged();
            };
            Tokens.OnItemsAdd -= (sender, pairs) => {
                foreach (KeyValuePair<string, Token> pair in pairs) {
                    pair.Value.OnContentsChanged -= Token_OnContentsChanged;
                }
                RaiseOnContentsChanged();
            };
        }

        private void Token_OnContentsChanged(object sender, EventArgs e) { 
            RaiseOnContentsChanged();
        }
    }
}
