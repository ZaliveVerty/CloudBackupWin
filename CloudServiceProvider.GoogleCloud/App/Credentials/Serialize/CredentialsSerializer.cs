using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudServiceProvider.GoogleCloud {
    public class CredentialsSerializer : IObjectSerializer<Credentials> {
        public IObjectSerializer<Common.Credentials> AccountCredentialsSerializer { get; set; }

        public CredentialsSerializer(IObjectSerializer<Common.Credentials> accountCredentialsSerializer) {
            AccountCredentialsSerializer = accountCredentialsSerializer;
        }

        public Tag Serialize(Credentials item) {
            return new ObjectTag() {
                { "AccountCredentials", AccountCredentialsSerializer.Serialize(item.AccountCredentials) },
                { "Email", item.Email },
                { "Name", item.Name },
                { "FolderName", item.FolderName }
            };
        }
    }
}
