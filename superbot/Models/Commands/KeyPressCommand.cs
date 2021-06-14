using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using superbot.Models.Hooks;
using WindowsInput.Native;

namespace superbot.Models.Commands
{
    class KeyPressCommand : Command, IHavingKeyboardKey
    {
        public Keys key { get; set; }

        public KeyPressCommand() { }
        public KeyPressCommand(TimeSpan delay, Keys key) : base(delay)
        {
            this.key = key;
        }

        public override void deserialize(BinaryReader stream)
        {
            base.deserialize(stream);
            key = (Keys)stream.ReadInt32();
        }

        public override void execute()
        {
            Simulator.simulator.Keyboard.KeyDown((VirtualKeyCode)key);
        }

        public override void serialize(BinaryWriter stream)
        {
            base.serialize(stream);
            stream.Write((int)key);
        }

        public override string ToString()
        {
            return "Pressed key: " + key.ToString();
        }
    }
}
