using System;
using System.Drawing;

namespace CloudServiceProvider {
    public interface IAccount {
        string DisplayName { get; }
        string Email { get; }
        Image ProfilePicture { get; }

        ICloudServiceProvider CloudServiceProvider { get; set; }
    }
}
