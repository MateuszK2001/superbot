using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace superbot.Models.Hooks
{
    public class MouseEventExtArgs : MouseEventArgs
    {
        public MouseEventExtArgs(MouseButtons buttons, int clicks, int x, int y, int delta)
            : base(buttons, clicks, x, y, delta)
        { }

        internal MouseEventExtArgs(MouseEventArgs e) : base(e.Button, e.Clicks, e.X, e.Y, e.Delta)
        { }

        public bool Handled;
    }
}
