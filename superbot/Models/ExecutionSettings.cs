using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using superbot.Models.Commands;

namespace superbot.Models
{
    class ExecutionSettings : ISerializable
    {
        public bool loop { get; set; }
        public bool humanMouseMove{ get; set; }

        public void deserialize(BinaryReader stream)
        {
            loop = stream.ReadBoolean();
            humanMouseMove = stream.ReadBoolean();
        }

        public void serialize(BinaryWriter stream)
        {
            stream.Write(loop);
            stream.Write(humanMouseMove);
        }
    }
}
