using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superbot.Models
{
    public static class DialogHelper
    {
        public static readonly string macroFilter;
        static DialogHelper()
        {
            macroFilter = $"{Config.extensionName} | *{Config.extension}";
        }
        public static string SaveMacroDialog()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Podaj gdzie zapisać plik";
            saveDialog.Filter = macroFilter;
            saveDialog.ValidateNames = true;
            saveDialog.OverwritePrompt = true;
            saveDialog.RestoreDirectory = true;

            saveDialog.ShowDialog();

            return saveDialog.FileName;
        }
        public static string OpenMacroDialog()
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Podaj gdzie zapisać plik";
            openDialog.Filter = macroFilter;
            openDialog.ValidateNames = true;
            openDialog.RestoreDirectory = true;
            openDialog.Multiselect = false;

            openDialog.ShowDialog();

            return openDialog.FileName;
        }
    }
}
