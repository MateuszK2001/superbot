using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using superbot.Models;
using superbot.Models.Commands;
using superbot.Views;

namespace superbot.Presenters
{
    class MainFormPresenter : IDisposable
    {
        IMainForm view;
        Macro macro = new Macro();
        Recorder recorder;
        string currentFilename = null;
        List<Command> clipboard = new List<Command>();

        public MainFormPresenter(IMainForm view)
        {
            this.view = view;
            recorder = new Recorder(view.recordingSettings);
            macro.executionSettings = view.executionSettings;

            Config.recordingHotKey.onKeysDown += RecordingHotKey_onKeysDown;
            Config.executeHotKey.onKeysDown += ExecuteHotKey_onKeysDown;
            Config.recordingHotKey.startListening();
            Config.executeHotKey.startListening();
            macro.onFinish += Macro_onFinish;
            recorder.onNewCommand += Recorder_onNewCommand;

        }

        private void Recorder_onNewCommand(Command command)
        {
            view.dispatcher.Invoke(() =>
            {
                macro.commands.Add(command);
                view.commands.Add(command);
            });
        }

        private void Macro_onFinish()
        {
            view.dispatcher.Invoke(() =>
            {
                view.isMacroRunning = false;
            });
        }

        private void ExecuteHotKey_onKeysDown()
        {
            view.isMacroRunning = !view.isMacroRunning;
            if (view.isMacroRunning)
            {
                if (view.isRecordingRunning)
                {
                    stopRecording();
                }
                macro.run();
            }
            else
            {
                macro.stop();
            }
        }

        private void stopRecording()
        {
            recorder.stopRecording();
            macro.removeHotKeyFromBeginAndEnd(Config.recordingHotKey.keysDown);
            reloadMacroToView();
            view.isRecordingRunning = false;
        }

        private void RecordingHotKey_onKeysDown()
        {
            view.isRecordingRunning = !view.isRecordingRunning;
            if (view.isRecordingRunning)
            {
                if (view.isMacroRunning)
                    macro.stop();

                recorder.startRecording();
            }
            else
            {
                stopRecording();
            }
        }
        public void deleteSelectedCommands()
        {
            macro.commands.RemoveAll(command => view.selectedCommands.Contains(command));

            var toRemove = view.selectedCommands.ToList();
            foreach (var command in toRemove)
            {
                view.commands.Remove(command);
            }
        }
        public void copySelectedCommands()
        {
            clipboard = view.selectedCommands.Select(a => (Command)a.Clone()).ToList();
        }
        public void paste()
        {
            var toPaste = clipboard.Select(a => a.Clone() as Command).ToList();
            if (view.selectedCommands.Count == 0)
            {
                macro.commands.AddRange(toPaste);
                foreach (var command in toPaste)
                    view.commands.Add(command);
            }
            else
            {
                int pastePos = view.commands.IndexOf(view.selectedCommands.First());
                macro.commands.InsertRange(pastePos, toPaste);
                for(int i = pastePos; i<pastePos+toPaste.Count(); i++)
                {
                    view.commands.Insert(i, toPaste[i - pastePos]);
                }
            }

        }
        public void saveMacro(bool saveAs = false)
        {
            if(currentFilename == null || saveAs)
                currentFilename = DialogHelper.SaveMacroDialog();
            if (!string.IsNullOrEmpty(currentFilename))
                macro.save(currentFilename);
        }
        void reloadMacroToView()
        {
            view.commands.Clear();
            view.executionSettings = macro.executionSettings;
            foreach (var command in macro.commands)
            {
                view.commands.Add(command);
            }
        }
        void reloadEditToView()
        {
            if(view.selectedCommands.Count == 0)
                return;
            Command firstCommands = view.selectedCommands.First();

            bool allHaveSameDelay = view.selectedCommands.All(a => a.delay == firstCommands.delay);
            view.currentCommandDelay = allHaveSameDelay ? (decimal)firstCommands.delay.TotalMilliseconds : -1;

            this.view.canChangePosition = view.selectedCommands.All(a => a is IPositionable);
            if (view.canChangePosition)
            {
                bool allHaveSameX = view.selectedCommands.All(a => (a as IPositionable).x == (firstCommands as IPositionable).x);
                bool allHaveSameY = view.selectedCommands.All(a => (a as IPositionable).y == (firstCommands as IPositionable).y);
                view.currentCommandX = allHaveSameX ? (firstCommands as IPositionable).x : -1;
                view.currentCommandY = allHaveSameY ? (firstCommands as IPositionable).y : -1;
            }

            /// TOdO dołożyć key
        }
        public void changeDelay()
        {
            foreach (var command in view.selectedCommands)
                command.delay = TimeSpan.FromMilliseconds((double)view.currentCommandDelay);
        }
        public void changeX()
        {
            foreach (var command in view.selectedCommands)
                if(command is IPositionable)
                    (command as IPositionable).x = (int)view.currentCommandX;
        }
        public void changeY()
        {
            foreach (var command in view.selectedCommands)
                if (command is IPositionable)
                    (command as IPositionable).y = (int)view.currentCommandY;
        }
        public void onSelectionChanged()
        {
            this.view.canEdit =  view.selectedCommands.Count > 0;
            if (this.view.canEdit)
                reloadEditToView();
        }

        public void loadMacro()
        {
            currentFilename = DialogHelper.OpenMacroDialog();
            if (!string.IsNullOrEmpty(currentFilename))
            {
                macro.load(currentFilename);
                reloadMacroToView();
            }
        }

        public void Dispose()
        {
            Config.recordingHotKey.onKeysDown -= RecordingHotKey_onKeysDown;
            Config.executeHotKey.onKeysDown -= ExecuteHotKey_onKeysDown;
            Config.recordingHotKey.stopListening();
            Config.executeHotKey.stopListening();
        }
    }
}
