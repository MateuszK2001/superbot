﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superbot.Models.Commands
{
    public abstract class Command : ISerializable, ICloneable
    {
        public TimeSpan delay { get; set; }

        public Command() { }
        public Command(TimeSpan delay) 
        {
            this.delay = delay;
        }

        public abstract void execute();

        public virtual void serialize(BinaryWriter stream)
        {
            stream.Write(delay.TotalMilliseconds);
        }
        public void serializeWithTypeInfo(BinaryWriter stream)
        {
            stream.Write(this.GetType().Name.GetHashCode());
            this.serialize(stream);
        }

        public virtual void deserialize(BinaryReader stream)
        {
            delay = TimeSpan.FromMilliseconds(stream.ReadDouble());
        }
        public static Command deserializeToNew(BinaryReader reader)
        {
            int typeHashCode = reader.ReadInt32();
            var typ = typeof(Command).Assembly.GetTypes().First(t => t.BaseType == typeof(Command) && t.Name.GetHashCode() == typeHashCode);
            var obj = Activator.CreateInstance(typ) as Command;
            obj.deserialize(reader);

            return obj;
        }

        public object Clone()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                using(BinaryWriter writer = new BinaryWriter(stream))
                {
                    serializeWithTypeInfo(writer);
                    writer.Flush();
                    stream.Position = 0;
                    using(BinaryReader reader = new BinaryReader(stream))
                    {
                        return Command.deserializeToNew(reader);
                    }
                }
            }
        }
    }
}
