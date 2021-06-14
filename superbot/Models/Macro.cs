using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using superbot.Models.Commands;

namespace superbot.Models
{
    class Macro
    {
        public bool isRunning { get; set; } = false;

        public List<Command> commands = new List<Command>();
        public ExecutionSettings executionSettings = new ExecutionSettings(); 

        CancellationTokenSource cts;
        Task taskExecute;

        public Macro() { }
        public Macro(string filename)
        {
            this.load(filename);
        }

        public void run()
        {
            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;
            taskExecute = Task.Factory.StartNew(() =>
            {
                do
                {
                    foreach (var command in commands)
                    {
                        if (cts.Token.WaitHandle.WaitOne(command.delay))
                            return;
                        command.execute();
                    }
                } while (executionSettings.loop);
            }, token);
        }

        public void stop()
        {
            if (cts != null)
                cts.Cancel();
        }
        public void save(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (BinaryWriter writer = new BinaryWriter(fs))
                {
                    executionSettings.serialize(writer);
                    writer.Write(commands.Count);
                    foreach (var command in commands)
                    {
                        command.serializeWithTypeInfo(writer);
                    }
                }
            }
        }
        public void load(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                using (BinaryReader reader = new BinaryReader(fs))
                {
                    executionSettings.deserialize(reader);

                    commands.Clear();
                    int count = reader.ReadInt32();
                    for (int i = 0; i < count; i++)
                    {
                        Command command = Command.deserializeToNew(reader);
                        commands.Add(command);
                    }
                }
            }
        }

    }
}
