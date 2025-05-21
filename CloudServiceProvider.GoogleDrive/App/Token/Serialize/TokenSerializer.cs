using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudServiceProvider.GoogleDrive {
    public class TokenSerializer : IObjectSerializer<Token> {
        public Tag Serialize(Token item) {
            return new ObjectTag() {
                { "JsonToken", item.JsonToken },
                { "Email", item.Email },
                { "Created", item.Created }
            };
        }
    }
}
