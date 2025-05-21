using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudServiceProvider.GoogleDrive {
    public class CredentialsDeserializer : IObjectDeserializer<Credentials> {
        public Credentials Deserialize(Tag tag) {
            return new Credentials() { 
                JsonCredentials = tag
            };
        }
    }
}
