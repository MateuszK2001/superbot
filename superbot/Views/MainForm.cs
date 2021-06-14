using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using superbot.Models;
using superbot.Models.Commands;
using superbot.Presenters;

namespace superbot.Views
{
    public partial class MainForm : Form, IMainForm
    {
        MainFormPresenter presenter;
        public MainForm()
        {
            InitializeComponent();

            listBoxCommands.DataSource = commands;
            //selectedItemsListBox.DataSource = selectedItems;
            //listBoxCommands.DataBindings.Add(new Binding( commands);
            presenter = new MainFormPresenter(this);
            isRecordingRunning = false;
            isMacroRunning = false;
            dispatcher = Dispatcher.CurrentDispatcher;
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
                this.checkBoxClickInsteadOfUpDown.Checked = recordingSettings.clickInsteadOfUpDown;
                this.checkBoxPressInsteadOfUpDown.Checked = recordingSettings.pressInsteadOfUpDown;
                this.checkBoxIgnoreMouseMove.Checked = recordingSettings.ignoreMouseMove;
            }
        }
        private void updateRecordingSettings(object sender, EventArgs e)
        {
            recordingSettings.clickInsteadOfUpDown = this.checkBoxClickInsteadOfUpDown.Checked;
            recordingSettings.pressInsteadOfUpDown = this.checkBoxPressInsteadOfUpDown.Checked;
            recordingSettings.ignoreMouseMove = this.checkBoxIgnoreMouseMove.Checked;
        }

        private ExecutionSettings _executionSettings = new ExecutionSettings();
        public ExecutionSettings executionSettings
        {
            get
            {
                return _executionSettings;
            }
            set
            {
                _executionSettings = value;
                this.checkBoxLoop.Checked = executionSettings.loop;
                this.checkBoxHumanMouseMove.Checked = executionSettings.humanMouseMove;
            }
        }
        private void updateExecutionSettings(object sender, EventArgs e)
        {
            this.checkBoxClickInsteadOfUpDown.Checked = recordingSettings.clickInsteadOfUpDown;
            this.checkBoxPressInsteadOfUpDown.Checked = recordingSettings.pressInsteadOfUpDown;
            this.checkBoxIgnoreMouseMove.Checked = recordingSettings.ignoreMouseMove;
        }

        public BindingList<Command> commands { get; } = new BindingList<Command>();

        public BindingList<Command> selectedCommands { get; } = new BindingList<Command>();

        private bool _isMacroRunning;
        public bool isMacroRunning
        {
            get
            {
                return _isMacroRunning;
            }
            set
            {
                _isMacroRunning = value;
                if (isMacroRunning)
                {
                    panelBot.BackColor = Color.Green;
                    labelBot.Text = "ON";
                    labelBot.ForeColor = Color.Chartreuse;
                    groupBoxBotSettings.Enabled = false;
                }
                else
                {
                    panelBot.BackColor = Color.FromArgb(215, 30, 20);
                    labelBot.Text = "OFF";
                    labelBot.ForeColor = Color.Gold;
                    groupBoxBotSettings.Enabled = true;
                }
            }
        }
        private bool _isRecordingRunning;

        public bool isRecordingRunning
        {
            get 
            { 
                return _isRecordingRunning; 
            }
            set 
            { 
                _isRecordingRunning = value;
                if (isRecordingRunning)
                {
                    panelRecord.BackColor = Color.Green;
                    labelRecord.Text = "ON";
                    labelRecord.ForeColor = Color.Chartreuse;
                    groupBoxRecordSettings.Enabled = false;
                }
                else
                {
                    panelRecord.BackColor = Color.FromArgb(215, 30, 20);
                    labelRecord.Text = "OFF";
                    labelRecord.ForeColor = Color.Gold;
                    groupBoxRecordSettings.Enabled = true;
                }
            }
        }

        public Dispatcher dispatcher { get; private set; }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            presenter.Dispose();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.saveMacro();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.saveMacro(true);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.loadMacro();
        }
    }
}
