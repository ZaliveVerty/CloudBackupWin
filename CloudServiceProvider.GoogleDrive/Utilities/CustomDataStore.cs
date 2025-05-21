using System;
using System.Threading.Tasks;
using Google.Apis.Util.Store;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CloudServiceProvider.GoogleDrive {
    public class CustomDataStore : IDataStore {
        public Token Token { get; set; }
        public JObject Store { get; set; }

        public CustomDataStore(Token store) {
            Token = store;
            Store = string.IsNullOrEmpty(store.JsonToken) ? new JObject() : JObject.Parse(store.JsonToken);
        }

        public Task ClearAsync() {
            Store.RemoveAll();
            Update();

            return Task.FromResult(0);
        }
        public Task DeleteAsync<T>(string key) {
            string storedKey = GenerateStoredKey(key, typeof(T));

            if (Store.ContainsKey(storedKey)) {
                Store.Remove(storedKey);
            }

            return Task.FromResult(0);
        }

        public Task<T> GetAsync<T>(string key) {
            TaskCompletionSource<T> taskCompletion = new TaskCompletionSource<T>();

            JToken obj = Store[GenerateStoredKey(key, typeof(T))];
            if (obj == null) {
                taskCompletion.SetResult(default(T));
            } else {
                taskCompletion.SetResult(obj.ToObject<T>(new JsonSerializer() {
                    NullValueHandling = NullValueHandling.Ignore
                }));
            }

            return taskCompletion.Task;
        }
        public Task StoreAsync<T>(string key, T value) {
            string storedKey = GenerateStoredKey(key, typeof(T));

            if (Store.ContainsKey(storedKey)) Store.Remove(storedKey);

            Store.Add(storedKey, JToken.FromObject(value, new JsonSerializer() {
                NullValueHandling = NullValueHandling.Ignore
            }));

            Update();

            return Task.FromResult(0);
        }

        private void Update() {
            Token.JsonToken = Store.ToString();
        }

        private static string GenerateStoredKey(string key, Type t) {
            return string.Format("{0}-{1}", t.FullName, key);
        }
    }
}
