using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudServiceProvider.GoogleCloud {
    public class CredentialsDeserializer : IObjectDeserializer<Credentials> {
        public IObjectDeserializer<Common.Credentials> AccountCredentialsDeserializer { get; set; }

        public CredentialsDeserializer(IObjectDeserializer<Common.Credentials> accountCredentialsDeserializer) { 
            AccountCredentialsDeserializer = accountCredentialsDeserializer;
        }

        public Credentials Deserialize(Tag tag) {
            ObjectTag obj = tag as ObjectTag;

            return new Credentials() { 
                AccountCredentials = AccountCredentialsDeserializer.Deserialize(obj["AccountCredentials"]),
                Email = obj["Email"],
                Name = obj["Name"],
                FolderName = obj["FolderName"]
            };
        }
    }
}
