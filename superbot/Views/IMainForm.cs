using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using superbot.Models;
using superbot.Models.Commands;

namespace superbot.Views
{
    interface IMainForm
    {
        RecordingSettings recordingSettings { get; set; }
        ExecutionSettings executionSettings { get; set; }
        List<Command> commands { get; }
        List<Command> selectedCommands { get; }
        bool isMacroRunning { get; set; }
        bool isRecordingRunning { get; set; }

        void refreshCommands();
        void addCommands(List<Command> commands);
        void removeCommands(List<Command> commands);
    }
}
