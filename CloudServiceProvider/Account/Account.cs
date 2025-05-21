using System;
using System.Drawing;

namespace CloudServiceProvider {
    public class Account : IAccount {
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public Image ProfilePicture { get; set; }

        public ICloudServiceProvider CloudServiceProvider { get; set; }
    }
}
