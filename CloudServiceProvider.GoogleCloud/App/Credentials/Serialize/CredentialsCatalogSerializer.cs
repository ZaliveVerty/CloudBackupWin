using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudServiceProvider.GoogleCloud {
    public class CredentialsCatalogSerializer : IObjectSerializer<CredentialsCatalog> {
        public IObjectSerializer<Credentials> CredentialsSerializer { get; set; }

        public CredentialsCatalogSerializer() {
            CredentialsSerializer = new CredentialsSerializer(new Common.CredentialsSerializer());
        }

        public Tag Serialize(CredentialsCatalog item) {
            Tag[] output = new Tag[item.Credentials.Count];

            for (int i = 0; i < item.Credentials.Count; i++) { 
                output[i] = CredentialsSerializer.Serialize(item.Credentials[i]);
            }

            return output;
        }
    }
}
