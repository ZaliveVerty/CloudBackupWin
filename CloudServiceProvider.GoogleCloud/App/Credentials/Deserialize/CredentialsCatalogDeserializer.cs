using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudServiceProvider.GoogleCloud {
    public class CredentialsCatalogDeserializer : IObjectDeserializer<CredentialsCatalog> {
        public IObjectDeserializer<Credentials> CredentialsDeserializer { get; set; }

        public CredentialsCatalogDeserializer() {
            CredentialsDeserializer = new CredentialsDeserializer(new Common.CredentialsDeserializer());
        }

        public CredentialsCatalog Deserialize(Tag tag) {
            Tag[] tags = tag;

            CredentialsCatalog output = new CredentialsCatalog();
            foreach (Tag credentialsTag in tags) {
                output.Credentials.Add(CredentialsDeserializer.Deserialize(credentialsTag));
            }

            return output;
        }
    }
}
