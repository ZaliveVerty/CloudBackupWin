using System;
using System.Collections.Generic;
using CommonUtilities;

namespace CloudServiceProvider.GoogleDrive {
    public class IdCacheCatalog : ObservableResource {
        public ObservableDictionary<string, IdCache> IdCache { get; set; }

        public IdCacheCatalog() { 
            IdCache = new ObservableDictionary<string, IdCache>();
            IdCache.OnItemsAdd += (sender, pairs) => {
                foreach (KeyValuePair<string, IdCache> pair in pairs) {
                    pair.Value.OnContentsChanged += IdCache_OnContentsChanged;
                }
                RaiseOnContentsChanged();
            };
            IdCache.OnItemsAdd -= (sender, pairs) => {
                foreach (KeyValuePair<string, IdCache> pair in pairs) {
                    pair.Value.OnContentsChanged -= IdCache_OnContentsChanged;
                }
                RaiseOnContentsChanged();
            };
        }

        private void IdCache_OnContentsChanged(object sender, EventArgs e) { 
            RaiseOnContentsChanged();
        }

        public void AddId(string email, string path, string id) {
            if (!IdCache.TryGetValue(email, out IdCache ids)) {
                ids = new IdCache();
                IdCache.Add(email, ids);
            };

            ids.Ids.Add(path, id);
        }
        public bool TryGetId(string email, string path, out string id) {
            if (!IdCache.TryGetValue(email, out IdCache ids)) {
                ids = new IdCache();
                IdCache.Add(email, ids);
            };

            return ids.Ids.TryGetValue(path, out id);
        }
        public void SetId(string email, string path, string id) {
            if (!IdCache.TryGetValue(email, out IdCache ids)) {
                ids = new IdCache();
                ids.Ids.Add(path, id);
                IdCache.Add(email, ids);
                return;
            };

            if (ids.Ids.ContainsKey(path)) {
                ids.Ids[path] = id;
            } else {
                ids.Ids.Add(path, id);
            }
        }
        public void RemoveId(string email, string id) {
            IdCache ids = IdCache[email];

            foreach (var pair in ids.Ids) {
                if (pair.Value == id) {
                    ids.Ids.Remove(pair.Key);
                    return;
                }
            }
        }
    }
}
