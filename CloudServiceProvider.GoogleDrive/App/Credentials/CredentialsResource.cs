using System;
using System.IO;
using CommonUtilities;
using SimpleBinaryTag;

namespace CloudServiceProvider.GoogleDrive {
    public class CredentialsResource : NamedSerializeableResource {
        public Credentials Credentials { get; private set; }

        public CredentialsResource(string name, INamedStreamProviderController controller) : base(name, controller) {}

        protected override void SetDefaultState() {
            Credentials = new Credentials();
        }
        protected override void SetState(Stream inputStream) {
            Credentials = new CredentialsDeserializer().Deserialize(Tag.FromStream(inputStream));
        }
        protected override void Serialize(Stream outputStream) {
            new CredentialsSerializer().Serialize(Credentials).WriteToStream(outputStream);
        }
    }
}
