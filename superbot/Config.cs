using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using superbot.Models;

namespace superbot
{
    static class Config
    {
        public static readonly string extension = ".sbot";
        public static readonly string extensionName = "Makro SuperBot";
        public static HotKey recordingHotKey = new HotKey(new List<Keys>(){ Keys.F7 });
        public static HotKey executeHotKey = new HotKey(new List<Keys>() { Keys.F8 });
    }
}
