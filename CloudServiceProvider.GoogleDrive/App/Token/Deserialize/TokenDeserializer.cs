using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudServiceProvider.GoogleDrive {
    public class TokenDeserializer : IObjectDeserializer<Token> {
        public Token Deserialize(Tag tag) {
            ObjectTag obj = tag as ObjectTag;

            return new Token() { 
                JsonToken = obj["JsonToken"],
                Email = obj["Email"],
                Created = obj["Created"]
            };
        }
    }
}
