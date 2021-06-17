using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using superbot.Models.Commands;

namespace superbot.Models
{
    class Macro
    {
        public bool isRunning { get; set; } = false;

        public List<Command> commands = new List<Command>();
        public ExecutionSettings executionSettings = new ExecutionSettings();
        public event Action onFinish;

        CancellationTokenSource cts;
        Task taskExecute;

        public Macro() { }
        public Macro(string filename)
        {
            this.load(filename);
        }

        bool moveTo(int x2, int y2, double time)
        {
            double x = Cursor.Position.X;
            double y = Cursor.Position.Y;
            const int W = 100;
            double dx = (x2 - x) / (double)W;
            double dy = (y2 - y) / (double)W;
            double dt = time / W;
            for(int i = 0; i<W; i++)
            {
                x += dx;
                y += dy;
                Cursor.Position = new System.Drawing.Point((int)x, (int)y);
                if (cts.Token.WaitHandle.WaitOne((int)dt))
                    return true;
            }
            return false;
        }
        public void run()
        {
            isRunning = true;
            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;
            taskExecute = Task.Factory.StartNew(() =>
            {
                do
                {
                    foreach (var command in commands)
                    {
                        if(executionSettings.humanMouseMove && command is IPositionable)
                        {
                            IPositionable pos = command as IPositionable;
                            if (moveTo(pos.x, pos.y, command.delay.TotalMilliseconds))
                                break;
                        }
                        else if (cts.Token.WaitHandle.WaitOne(command.delay))
                            break;
                        command.execute();
                    }
                } while (executionSettings.loop);
                isRunning = false;
                onFinish?.Invoke();
            }, token);
        }

        public void stop()
        {
            if (cts != null)
                cts.Cancel();
        }
        private static List<Command> _takeFirstCommands(IEnumerable<Command> commands, double time)
        {
            double totalTime = 0;
            List<Command> res = new List<Command>();
            foreach (var command in commands)
            {
                totalTime += command.delay.TotalMilliseconds;
                if (totalTime >= time)
                    break;
                res.Add(command);
            }
            return res;
        }
        public List<Command> takeFirstCommands(double time)
        {
            return _takeFirstCommands(commands, time);
        }
        public List<Command> takeLastCommands(double time)
        {
            return _takeFirstCommands(commands.Reverse<Command>(), time);
        }
        private static List<Command> takeTillAllRemoved<T>(List<Keys> hotKeys, IEnumerable<Command> commands) where T : Command, IHavingKeyboardKey
        {
            HashSet<int> removedSet = new HashSet<int>();
            Func<bool> removedAll = () => hotKeys.All(k => removedSet.Contains((int)k));
            List<Command> res = new List<Command>();
            foreach (Command command in commands)
            {
                if (command is T && hotKeys.Contains((command as T).key))
                {
                    int key = (int)(command as T).key;
                    if (!removedSet.Contains(key))
                    {
                        removedSet.Add(key);
                        res.Add(command);
                    }
                }
                if (removedAll())
                    break;
            }
            return res;
        }
        public void removeHotKeyFromBeginAndEnd(List<Keys> hotKeys)
        {
            var test = commands.ToList();
            var beginning = takeTillAllRemoved<KeyUpCommand>(hotKeys, commands);
            var ending = takeTillAllRemoved<KeyDownCommand>(hotKeys, commands.Reverse<Command>());
            commands.RemoveAll(a => beginning.Contains(a) || ending.Contains(a));
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
