using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superbot.Models.Commands
{
    interface ISerializable
    {
        void serialize(BinaryWriter stream);
        void deserialize(BinaryReader stream);
    }
}
