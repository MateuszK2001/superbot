using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using superbot.Models;
using superbot.Models.Commands;

namespace superbot.Views
{
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private RecordingSettings _recordingSettings = new RecordingSettings();
        public RecordingSettings recordingSettings 
        { 
            get
            {
                return _recordingSettings;
            }
            set
            {
                _recordingSettings = value;
            }
        }
        public ExecutionSettings executionSettings { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public List<Command> commands => throw new NotImplementedException();

        public List<Command> selectedCommands => throw new NotImplementedException();

        public bool isMacroRunning { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool isRecordingRunning { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void addCommands(List<Command> commands)
        {
            throw new NotImplementedException();
        }

        public void refreshCommands()
        {
            throw new NotImplementedException();
        }

        public void removeCommands(List<Command> commands)
        {
            throw new NotImplementedException();
        }
    }
}
