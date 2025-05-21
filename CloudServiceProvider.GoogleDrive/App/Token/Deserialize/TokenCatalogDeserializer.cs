using System;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudServiceProvider.GoogleDrive {
    public class TokenCatalogDeserializer : IObjectDeserializer<TokenCatalog> {
        public IObjectDeserializer<Token> IdCacheDeserializer { get; set; }

        public TokenCatalogDeserializer() {
            IdCacheDeserializer = new TokenDeserializer();
        }

        public TokenCatalog Deserialize(Tag tag) {
            ObjectTag[] idTags = tag;

            TokenCatalog output = new TokenCatalog();
            foreach (ObjectTag idObj in idTags) {
                output.Tokens.Add(idObj["Email"], IdCacheDeserializer.Deserialize(idObj["Token"]));
            }

            return output;
        }
    }
}
