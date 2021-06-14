using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace superbot.Models
{
    public static class ExtentionsManager
    {
        public static void addExtension(string extension, string nameExtension, string pathProgram)
        {
            using (var globalClasses = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Classes", true))
            {
                globalClasses.CreateSubKey(extension).SetValue("", nameExtension);
                using (var superBotDir = globalClasses.CreateSubKey(nameExtension))
                {
                    superBotDir.CreateSubKey("shell").CreateSubKey("open").CreateSubKey("command").SetValue("", string.Format("\"{0}\" \"%1\"", pathProgram));
                    superBotDir.CreateSubKey("DefaultIcon").SetValue("", pathProgram + ",0");
                }
            }
        }
    }
}
