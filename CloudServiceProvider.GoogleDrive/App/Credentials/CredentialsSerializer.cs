using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudServiceProvider.GoogleDrive {
    public class CredentialsSerializer : IObjectSerializer<Credentials> {
        public Tag Serialize(Credentials item) {
            return item.JsonCredentials;
        }
    }
}
