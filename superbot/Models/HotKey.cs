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
        Dictionary<int, bool> keysDownDict = new Dictionary<int, bool>();
        public List<Keys> keysDown { get; private set; } = new List<Keys>();
        public event Action onKeysDown;

        public HotKey(List<Keys> keysDown)
        {
            this.keysDown = keysDown;
            foreach (var key in keysDown)
                keysDownDict.Add((int)key, false);
        }


        private void KeyboardHook_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (keysDown.Contains(e.KeyCode))
            {
                keysDownDict[(int)e.KeyCode] = true;

                if (areKeysDown())
                    onKeysDown?.Invoke();
            }
        }
        private void KeyboardHook_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (keysDown.Contains(e.KeyCode))
                keysDownDict[(int)e.KeyCode] = false;
        }
        private bool areKeysDown()
        {
            //foreach (var key in keysDown)
            //{
            //    Console.Error.Write($"{key}: {keysDownDict[(int)key]}\t");
            //}
            //Console.Error.WriteLine();

            return keysDown.All(a => keysDownDict[(int)a]);
        }

        public bool isListening { get; private set; } = false;
        public void startListening()
        {
            if (!isListening)
            {
                foreach(var key in keysDown)
                {
                    keysDownDict[(int)key] = false;
                }
                KeyboardHook.KeyDown += KeyboardHook_KeyDown;
                KeyboardHook.KeyUp += KeyboardHook_KeyUp;
                isListening = true;
            }
        }

        public void stopListening()
        {
            if (isListening)
            {
                KeyboardHook.KeyDown -= KeyboardHook_KeyDown;
                KeyboardHook.KeyUp -= KeyboardHook_KeyUp;
                isListening = false;
            }
        }

    }
}
