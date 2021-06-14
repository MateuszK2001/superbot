using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        Dispatcher dispatcher { get; }
    }
}
