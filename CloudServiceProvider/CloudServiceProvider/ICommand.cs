using System;
using System.Drawing;

namespace CloudServiceProvider {
    public interface ICommand {
        string DisplayText { get; }
        Image Image { get; }

        void Execute();
    }
}
