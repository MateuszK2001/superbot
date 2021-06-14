using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superbot.Models.Commands
{
    class MouseMoveCommand : Command, IPositionable
    {
        public int x { get; set; }
        public int y { get; set; }

        public MouseMoveCommand() { }
        public MouseMoveCommand(TimeSpan delay, int x, int y) : base(delay)
        {
            this.x = x;
            this.y = y;
        }

        public override void deserialize(BinaryReader stream)
        {
            base.deserialize(stream);
            x = stream.ReadInt32();
            y = stream.ReadInt32();
        }

        public override void execute()
        {
            Cursor.Position = new Point(x, y);
        }

        public override void serialize(BinaryWriter stream)
        {
            base.serialize(stream);
            stream.Write(x);
            stream.Write(y);
        }

        public override string ToString()
        {
            return $"Cursor move ({x}, {y})";    
        }
    }
}
