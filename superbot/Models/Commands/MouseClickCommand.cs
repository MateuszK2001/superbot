using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using superbot.Models.Hooks;

namespace superbot.Models.Commands
{
    class MousePressCommand : Command, IPositionable, IHavingMouseBtn
    {
        public int x { get; set; }
        public int y { get; set; }
        public MouseButtons button { get; set; }

        public MousePressCommand() { }
        public MousePressCommand(TimeSpan delay, int x, int y, MouseButtons button) : base(delay)
        {
            this.x = x;
            this.y = y;
            this.button = button;
        }

        public override void deserialize(BinaryReader stream)
        {
            base.deserialize(stream);
            x = stream.ReadInt32();
            y = stream.ReadInt32();
            button = (MouseButtons)stream.ReadInt32();
        }

        public override void execute()
        {
            Cursor.Position = new Point(x, y);
            if (button == MouseButtons.Left)
            {
                MouseHook.Click(MouseHook.Buttons.MOUSEEVENTF_LEFTDOWN);
                MouseHook.Click(MouseHook.Buttons.MOUSEEVENTF_LEFTUP);
            }
            if (button == MouseButtons.Right)
            {
                MouseHook.Click(MouseHook.Buttons.MOUSEEVENTF_RIGHTDOWN);
                MouseHook.Click(MouseHook.Buttons.MOUSEEVENTF_RIGHTUP);
            }
        }

        public override void serialize(BinaryWriter stream)
        {
            base.serialize(stream);
            stream.Write(x);
            stream.Write(y);
            stream.Write((int)button);
        }

        public override string ToString()
        {
            return "Pressed " + button.ToString();
        }
    }
}
