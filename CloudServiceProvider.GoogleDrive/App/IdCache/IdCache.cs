using System;
using CommonUtilities;

namespace CloudServiceProvider.GoogleDrive {
    public class IdCache : ObservableResource {
        public ObservableDictionary<string, string> Ids { get; private set; }
    
        public IdCache() { 
            Ids = new ObservableDictionary<string, string>();
            Ids.OnItemsAdd += (sender, items) => { 
                RaiseOnContentsChanged();
            };
            Ids.OnItemsAdd -= (sender, items) => {
                RaiseOnContentsChanged();
            };
        }
    }
}
