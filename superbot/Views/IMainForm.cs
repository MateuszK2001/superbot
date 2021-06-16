using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using superbot.Models;
using superbot.Models.Commands;

namespace superbot.Views
{
    interface IMainForm
    {
        RecordingSettings recordingSettings { get; set; }
        ExecutionSettings executionSettings { get; set; }
        BindingList<Command> commands { get; }
        BindingList<Command> selectedCommands { get; }
        bool isMacroRunning { get; set; }
        bool isRecordingRunning { get; set; }
        decimal currentCommandDelay { get; set; }
        decimal currentCommandX { get; set; }
        decimal currentCommandY { get; set; }
        Keys currentCommandKey { get; set; }
        bool canChangePosition { get; set; }
        bool canChangeKey { get; set; }
        bool canEdit { get; set; }
        Dispatcher dispatcher { get; }
    }
}
