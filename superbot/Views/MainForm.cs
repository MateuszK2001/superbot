using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using superbot.Models;
using superbot.Models.Commands;
using superbot.Presenters;

namespace superbot.Views
{
    public partial class MainForm : Form, IMainForm, INotifyPropertyChanged
    {
        MainFormPresenter presenter;
        public MainForm()
        {
            InitializeComponent();

            listBoxCommands.DataSource = commands;
            numericUpDownDelay.DataBindings.Add("Value", this, "currentCommandDelay", false, DataSourceUpdateMode.OnPropertyChanged);
            numericUpDownX.DataBindings.Add("Value", this, "currentCommandX", false, DataSourceUpdateMode.OnPropertyChanged);
            numericUpDownY.DataBindings.Add("Value", this, "currentCommandY", false, DataSourceUpdateMode.OnPropertyChanged);
            groupBoxPosition.DataBindings.Add("Enabled", this, "canChangePosition", false, DataSourceUpdateMode.OnPropertyChanged);
            groupBoxEdit.DataBindings.Add("Enabled", this, "canEdit", false, DataSourceUpdateMode.OnPropertyChanged);


            var groupBoxRecordSettingsEnabledBinding = new Binding("Enabled", this, "isRecordingRunning");
            groupBoxRecordSettingsEnabledBinding.Parse += switchBool;
            groupBoxRecordSettingsEnabledBinding.Format += switchBool;
            groupBoxRecordSettings.DataBindings.Add(groupBoxRecordSettingsEnabledBinding);

            
            var groupBoxExecutionSettingsEnabledBinding = new Binding("Enabled", this, "isMacroRunning");
            groupBoxExecutionSettingsEnabledBinding.Parse += switchBool;
            groupBoxExecutionSettingsEnabledBinding.Format += switchBool;
            groupBoxExecutionSettings.DataBindings.Add(groupBoxExecutionSettingsEnabledBinding);



            presenter = new MainFormPresenter(this);
            isRecordingRunning = false;
            isMacroRunning = false;
            dispatcher = Dispatcher.CurrentDispatcher;
        }

        private void switchBool(object sender, ConvertEventArgs e)
        {
            e.Value = !((bool)e.Value);
        }


        private bool _canEdit;
        public bool canEdit
        {
            get => _canEdit;
            set
            {
                SetProp(ref _canEdit, value);
            }
        }
        private bool _canChangePosition;
        public bool canChangePosition
        {
            get => _canChangePosition;
            set
            {
                SetProp(ref _canChangePosition, value);
            }
        }
        private decimal _currentCommandDelay;
        public decimal currentCommandDelay 
        {
            get => _currentCommandDelay;
            set
            {
                SetProp(ref _currentCommandDelay, value);
                if (value != -1)
                    presenter.changeDelay();
            }
        }
        private decimal _currentCommandX;

        public decimal currentCommandX
        {
            get { return _currentCommandX; }
            set 
            { 
                SetProp(ref _currentCommandX, value); 
                if(value != -1)
                    presenter.changeX(); 
            }
        }


        private decimal _currentCommandY;

        public decimal currentCommandY
        {
            get { return _currentCommandY; }
            set 
            { 
                SetProp(ref _currentCommandY, value); 
                if(value != -1)
                    presenter.changeY(); 
            }
        }

        private Keys _currentCommandKey;

        public Keys currentCommandKey
        {
            get { return _currentCommandKey; }
            set { _currentCommandKey = value; }
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
            executionSettings.loop = this.checkBoxLoop.Checked;
            executionSettings.humanMouseMove = this.checkBoxHumanMouseMove.Checked;
        }

        public BindingList<Command> commands { get; } = new BindingList<Command>();

        public BindingList<Command> selectedCommands { get; private set; } = new BindingList<Command>();

        private bool _isMacroRunning;
        public bool isMacroRunning
        {
            get
            {
                return _isMacroRunning;
            }
            set
            {
                SetProp(ref _isMacroRunning, value);
                if (isMacroRunning)
                {
                    panelBot.BackColor = Color.Green;
                    labelBot.Text = "ON";
                    labelBot.ForeColor = Color.Chartreuse;
                }
                else
                {
                    panelBot.BackColor = Color.FromArgb(215, 30, 20);
                    labelBot.Text = "OFF";
                    labelBot.ForeColor = Color.Gold;
                }
            }
        }
        private bool _isRecordingRunning;

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        } 
        private void SetProp<T>(ref T field, T value, [CallerMemberName]  string propertyName = null)
        {
            if (field.Equals(value))
                return;
            field = value;
            OnPropertyChanged(propertyName);
        }


        public bool isRecordingRunning
        {
            get 
            { 
                return _isRecordingRunning; 
            }
            set 
            { 
                SetProp(ref _isRecordingRunning, value);
                if (isRecordingRunning)
                {
                    panelRecord.BackColor = Color.Green;
                    labelRecord.Text = "ON";
                    labelRecord.ForeColor = Color.Chartreuse;
                }
                else
                {
                    panelRecord.BackColor = Color.FromArgb(215, 30, 20);
                    labelRecord.Text = "OFF";
                    labelRecord.ForeColor = Color.Gold;
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            presenter.deleteSelectedCommands();
        }
    

        private void RefreshSelectedList()
        {
            selectedCommands.Clear();
            foreach(int id in listBoxCommands.SelectedIndices)
            {
                if (id >= commands.Count) // form robi event ze starym i nowym indeksem, a potem robi drugi juz poprawiony 
                    continue;
                selectedCommands.Add(commands[id]);
            }
        }

        private void listBoxCommands_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSelectedList();
            presenter.onSelectionChanged();
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            presenter.paste();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            presenter.copySelectedCommands();
        }
    }
}
