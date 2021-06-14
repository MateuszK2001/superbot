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
                macro.run();
            }
            else
            {
                macro.stop();
            }
        }

        private void RecordingHotKey_onKeysDown()
        {
            view.isRecordingRunning = !view.isRecordingRunning;
            if (view.isRecordingRunning)
            {
                recorder.startRecording();
            }
            else
            {
                recorder.stopRecording();
                macro.removeHotKeyFromBeginAndEnd(Config.recordingHotKey.keysDown);
                reloadMacroToView();
            }
        }
        public void deleteSelectedCommands()
        {
            macro.commands.RemoveAll(command => view.selectedCommands.Contains(command));
            foreach (var command in view.selectedCommands)
                view.commands.Remove(command);
            view.selectedCommands.Clear();
        }
        public void duplicateSelectedCommands()
        {
            var newCommands = view.selectedCommands.Select(a => (Command)a.Clone());
            macro.commands.AddRange(newCommands);
            foreach (var command in view.selectedCommands)
                view.commands.Add(command);
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
            view.selectedCommands.Clear();
            view.executionSettings = macro.executionSettings;
            foreach (var command in macro.commands)
            {
                view.commands.Add(command);
            }
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
