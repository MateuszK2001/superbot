using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using superbot.Models.Commands;

namespace superbot.Models
{
    class RecordingSettings : ISerializable
    {
        public bool ignoreMouseMove { get; set; }
        public bool clickInsteadOfUpDown { get; set; }
        public bool pressInsteadOfUpDown { get; set; }

        public void deserialize(BinaryReader stream)
        {
            ignoreMouseMove = stream.ReadBoolean();
            clickInsteadOfUpDown = stream.ReadBoolean();
            pressInsteadOfUpDown = stream.ReadBoolean();
        }

        public void serialize(BinaryWriter stream)
        {
            stream.Write(ignoreMouseMove);
            stream.Write(clickInsteadOfUpDown);
            stream.Write(pressInsteadOfUpDown);
        }
    }
}
