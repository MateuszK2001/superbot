using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using superbot.Models.Hooks;

namespace superbot.Models
{
    class HotKey
    {
        List<Keys> keysDown = new List<Keys>();
        public event Action onKeysDown;

        public HotKey(List<Keys> keysDown)
        {
            this.keysDown = keysDown;
        }

        

        private void KeyboardHook_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (areKeysDown())
                onKeysDown?.Invoke();
        }
        private bool areKeysDown()
        {
            return keysDown.All(a => Keyboard.IsKeyDown(KeyInterop.KeyFromVirtualKey((int)a)));
        }

        public void startListening()
        {
            KeyboardHook.KeyDown += KeyboardHook_KeyDown;
        }
        public void stopListening()
        {
            KeyboardHook.KeyDown -= KeyboardHook_KeyDown;
        }

    }
}
