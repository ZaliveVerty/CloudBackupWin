using System;
using System.Collections.Generic;
using System.Linq;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudServiceProvider.GoogleDrive {
    public class TokenCatalogSerializer : IObjectSerializer<TokenCatalog> {
        public IObjectSerializer<Token> TokenSerializer { get; set; }

        public TokenCatalogSerializer() {
            TokenSerializer = new TokenSerializer();
        }

        public Tag Serialize(TokenCatalog item) {
            ObjectTag[] idTags = new ObjectTag[item.Tokens.Count];

            for (int i = 0; i < item.Tokens.Count; i++) {
                KeyValuePair<string, Token> pair = item.Tokens.ElementAt(i);

                idTags[i] = new ObjectTag() {
                    { "Email", pair.Key },
                    { "Token", TokenSerializer.Serialize(item.Tokens.Values.ElementAt(i)) }
                };
            }

            return idTags;
        }
    }
}
