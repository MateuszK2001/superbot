using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using superbot.Models.Commands;
using superbot.Models.Hooks;

namespace superbot.Models
{
    class Recorder
    {
        public RecordingSettings settings { get; set; }

        private TimeSpan elapsedTime;

        public event Action<Command> onNewCommand;


        private bool _isRecording;

        public bool isRecording
        {
            get { return _isRecording; }
            private set 
            { 
                _isRecording = value; 
            }
        }

        public void startRecording()
        {
            isRecording = true;
            elapsedTime = DateTime.Now.TimeOfDay;
            
            MouseHook.MouseMove += MouseHook_MouseMove;
            MouseHook.MouseDown += MouseHook_MouseDown;
            MouseHook.MouseUp += MouseHook_MouseUp;
            MouseHook.MouseClick += MouseHook_MouseClick;

            KeyboardHook.KeyDown += KeyboardHook_KeyDown;
            KeyboardHook.KeyUp += KeyboardHook_KeyUp;
            KeyboardHook.KeyPress += KeyboardHook_KeyPress;
        }

        public void stopRecording()
        {
            isRecording = false;

            MouseHook.MouseMove -= MouseHook_MouseMove;
            MouseHook.MouseDown -= MouseHook_MouseDown;
            MouseHook.MouseUp -= MouseHook_MouseUp;
            MouseHook.MouseClick -= MouseHook_MouseClick;

            KeyboardHook.KeyDown -= KeyboardHook_KeyDown;
            KeyboardHook.KeyUp -= KeyboardHook_KeyUp;
            KeyboardHook.KeyPress -= KeyboardHook_KeyPress;
        }

        private void KeyboardHook_KeyUp(object sender, KeyEventArgs e)
        {
            if (settings.pressInsteadOfUpDown)
                return;
            Command newCommand = new KeyUpCommand(DateTime.Now.TimeOfDay - elapsedTime, e.KeyCode);
            elapsedTime = DateTime.Now.TimeOfDay;
            onNewCommand?.Invoke(newCommand);
        }

        private void KeyboardHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (settings.pressInsteadOfUpDown)
                return;
            Command newCommand = new KeyUpCommand(DateTime.Now.TimeOfDay - elapsedTime, e.KeyCode);
            elapsedTime = DateTime.Now.TimeOfDay;
            onNewCommand?.Invoke(newCommand);
        }
        private void KeyboardHook_KeyPress(object sender, KeyEventArgs e)
        {
            if (!settings.pressInsteadOfUpDown)
                return;
            Command newCommand = new KeyPressCommand(DateTime.Now.TimeOfDay - elapsedTime, e.KeyCode);
            elapsedTime = DateTime.Now.TimeOfDay;
            onNewCommand?.Invoke(newCommand);
        }

        private void MouseHook_MouseUp(object sender, MouseEventArgs e)
        {
            if (settings.clickInsteadOfUpDown)
                return;
            Command newCommand = new MouseUpCommand(DateTime.Now.TimeOfDay - elapsedTime, e.Location.X, e.Location.Y, e.Button);
            elapsedTime = DateTime.Now.TimeOfDay;
            onNewCommand?.Invoke(newCommand);
        }

        private void MouseHook_MouseDown(object sender, MouseEventArgs e)
        {
            if (settings.clickInsteadOfUpDown)
                return;
            Command newCommand = new MouseDownCommand(DateTime.Now.TimeOfDay - elapsedTime, e.Location.X, e.Location.Y, e.Button);
            elapsedTime = DateTime.Now.TimeOfDay;
            onNewCommand?.Invoke(newCommand);
        }

        private void MouseHook_MouseMove(object sender, MouseEventArgs e)
        {
            if (settings.clickInsteadOfUpDown)
                return;
            Command newCommand = new MouseMoveCommand(DateTime.Now.TimeOfDay - elapsedTime, e.Location.X, e.Location.Y);
            elapsedTime = DateTime.Now.TimeOfDay;
            onNewCommand?.Invoke(newCommand);
        }

        private void MouseHook_MouseClick(object sender, MouseEventArgs e)
        {
            if (!settings.clickInsteadOfUpDown)
                return;
            Command newCommand = new MouseClickCommand(DateTime.Now.TimeOfDay - elapsedTime, e.Location.X, e.Location.Y, e.Button);
            elapsedTime = DateTime.Now.TimeOfDay;
            onNewCommand?.Invoke(newCommand);
        }

    }
}
