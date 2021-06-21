
using System;

namespace superbot.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxExecutionSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxHumanMouseMove = new System.Windows.Forms.CheckBox();
            this.checkBoxLoop = new System.Windows.Forms.CheckBox();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.groupBoxKey = new System.Windows.Forms.GroupBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.buttonPaste = new System.Windows.Forms.Button();
            this.numericUpDownDelay = new System.Windows.Forms.NumericUpDown();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxPosition = new System.Windows.Forms.GroupBox();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxRecordSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxPressInsteadOfUpDown = new System.Windows.Forms.CheckBox();
            this.checkBoxClickInsteadOfUpDown = new System.Windows.Forms.CheckBox();
            this.checkBoxIgnoreMouseMove = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelBot = new System.Windows.Forms.Panel();
            this.labelBot = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelRecord = new System.Windows.Forms.Panel();
            this.labelRecord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCommands = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.groupBoxExecutionSettings.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            this.groupBoxKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).BeginInit();
            this.groupBoxPosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            this.groupBoxRecordSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelBot.SuspendLayout();
            this.panelRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.InfoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1107, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.openToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.saveToolStripMenuItem.Text = "Zapisz";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.saveAsToolStripMenuItem.Text = "Zapisz jako";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.openToolStripMenuItem.Text = "Otwórz";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // InfoToolStripMenuItem
            // 
            this.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            this.InfoToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.InfoToolStripMenuItem.Text = "Informacje";
            this.InfoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // groupBoxExecutionSettings
            // 
            this.groupBoxExecutionSettings.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxExecutionSettings.Controls.Add(this.checkBoxHumanMouseMove);
            this.groupBoxExecutionSettings.Controls.Add(this.checkBoxLoop);
            this.groupBoxExecutionSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxExecutionSettings.Location = new System.Drawing.Point(24, 556);
            this.groupBoxExecutionSettings.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxExecutionSettings.Name = "groupBoxExecutionSettings";
            this.groupBoxExecutionSettings.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxExecutionSettings.Size = new System.Drawing.Size(333, 165);
            this.groupBoxExecutionSettings.TabIndex = 13;
            this.groupBoxExecutionSettings.TabStop = false;
            this.groupBoxExecutionSettings.Text = "Bot settings";
            // 
            // checkBoxHumanMouseMove
            // 
            this.checkBoxHumanMouseMove.AutoSize = true;
            this.checkBoxHumanMouseMove.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxHumanMouseMove.Location = new System.Drawing.Point(17, 69);
            this.checkBoxHumanMouseMove.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxHumanMouseMove.Name = "checkBoxHumanMouseMove";
            this.checkBoxHumanMouseMove.Size = new System.Drawing.Size(188, 27);
            this.checkBoxHumanMouseMove.TabIndex = 3;
            this.checkBoxHumanMouseMove.Text = "Human mouse move";
            this.checkBoxHumanMouseMove.UseVisualStyleBackColor = true;
            this.checkBoxHumanMouseMove.CheckedChanged += new System.EventHandler(this.updateExecutionSettings);
            // 
            // checkBoxLoop
            // 
            this.checkBoxLoop.AutoSize = true;
            this.checkBoxLoop.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxLoop.Location = new System.Drawing.Point(17, 34);
            this.checkBoxLoop.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxLoop.Name = "checkBoxLoop";
            this.checkBoxLoop.Size = new System.Drawing.Size(67, 27);
            this.checkBoxLoop.TabIndex = 2;
            this.checkBoxLoop.Text = "Loop";
            this.checkBoxLoop.UseVisualStyleBackColor = true;
            this.checkBoxLoop.CheckedChanged += new System.EventHandler(this.updateExecutionSettings);
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxEdit.Controls.Add(this.groupBoxKey);
            this.groupBoxEdit.Controls.Add(this.buttonPaste);
            this.groupBoxEdit.Controls.Add(this.numericUpDownDelay);
            this.groupBoxEdit.Controls.Add(this.buttonCopy);
            this.groupBoxEdit.Controls.Add(this.buttonDelete);
            this.groupBoxEdit.Controls.Add(this.groupBoxPosition);
            this.groupBoxEdit.Controls.Add(this.label7);
            this.groupBoxEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxEdit.Location = new System.Drawing.Point(383, 32);
            this.groupBoxEdit.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxEdit.Size = new System.Drawing.Size(333, 689);
            this.groupBoxEdit.TabIndex = 14;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Edit";
            // 
            // groupBoxKey
            // 
            this.groupBoxKey.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxKey.Controls.Add(this.textBoxKey);
            this.groupBoxKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxKey.Location = new System.Drawing.Point(33, 269);
            this.groupBoxKey.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxKey.Name = "groupBoxKey";
            this.groupBoxKey.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxKey.Size = new System.Drawing.Size(267, 116);
            this.groupBoxKey.TabIndex = 12;
            this.groupBoxKey.TabStop = false;
            this.groupBoxKey.Text = "Key";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxKey.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxKey.Location = new System.Drawing.Point(37, 46);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.ReadOnly = true;
            this.textBoxKey.Size = new System.Drawing.Size(193, 29);
            this.textBoxKey.TabIndex = 13;
            this.textBoxKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxKey_KeyChanged);
            // 
            // buttonPaste
            // 
            this.buttonPaste.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonPaste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPaste.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPaste.Location = new System.Drawing.Point(171, 412);
            this.buttonPaste.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(129, 58);
            this.buttonPaste.TabIndex = 11;
            this.buttonPaste.Text = "Paste";
            this.buttonPaste.UseVisualStyleBackColor = false;
            this.buttonPaste.Click += new System.EventHandler(this.buttonPaste_Click);
            // 
            // numericUpDownDelay
            // 
            this.numericUpDownDelay.DecimalPlaces = 2;
            this.numericUpDownDelay.Location = new System.Drawing.Point(129, 42);
            this.numericUpDownDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownDelay.Name = "numericUpDownDelay";
            this.numericUpDownDelay.Size = new System.Drawing.Size(134, 29);
            this.numericUpDownDelay.TabIndex = 10;
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCopy.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCopy.Location = new System.Drawing.Point(34, 412);
            this.buttonCopy.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(129, 58);
            this.buttonCopy.TabIndex = 9;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(99, 480);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(129, 58);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxPosition
            // 
            this.groupBoxPosition.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPosition.Controls.Add(this.numericUpDownY);
            this.groupBoxPosition.Controls.Add(this.numericUpDownX);
            this.groupBoxPosition.Controls.Add(this.label4);
            this.groupBoxPosition.Controls.Add(this.label5);
            this.groupBoxPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxPosition.Location = new System.Drawing.Point(33, 95);
            this.groupBoxPosition.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxPosition.Name = "groupBoxPosition";
            this.groupBoxPosition.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxPosition.Size = new System.Drawing.Size(267, 151);
            this.groupBoxPosition.TabIndex = 6;
            this.groupBoxPosition.TabStop = false;
            this.groupBoxPosition.Text = "Position";
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Location = new System.Drawing.Point(65, 90);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(165, 26);
            this.numericUpDownY.TabIndex = 12;
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(65, 49);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(165, 26);
            this.numericUpDownX.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(33, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(33, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(29, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Delay(ms):";
            // 
            // groupBoxRecordSettings
            // 
            this.groupBoxRecordSettings.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxRecordSettings.Controls.Add(this.checkBoxPressInsteadOfUpDown);
            this.groupBoxRecordSettings.Controls.Add(this.checkBoxClickInsteadOfUpDown);
            this.groupBoxRecordSettings.Controls.Add(this.checkBoxIgnoreMouseMove);
            this.groupBoxRecordSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxRecordSettings.Location = new System.Drawing.Point(24, 375);
            this.groupBoxRecordSettings.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxRecordSettings.Name = "groupBoxRecordSettings";
            this.groupBoxRecordSettings.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxRecordSettings.Size = new System.Drawing.Size(333, 165);
            this.groupBoxRecordSettings.TabIndex = 12;
            this.groupBoxRecordSettings.TabStop = false;
            this.groupBoxRecordSettings.Text = "Record settings";
            // 
            // checkBoxPressInsteadOfUpDown
            // 
            this.checkBoxPressInsteadOfUpDown.AutoSize = true;
            this.checkBoxPressInsteadOfUpDown.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxPressInsteadOfUpDown.Location = new System.Drawing.Point(17, 104);
            this.checkBoxPressInsteadOfUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxPressInsteadOfUpDown.Name = "checkBoxPressInsteadOfUpDown";
            this.checkBoxPressInsteadOfUpDown.Size = new System.Drawing.Size(256, 27);
            this.checkBoxPressInsteadOfUpDown.TabIndex = 5;
            this.checkBoxPressInsteadOfUpDown.Text = "Press instead of key up/down";
            this.checkBoxPressInsteadOfUpDown.UseVisualStyleBackColor = true;
            this.checkBoxPressInsteadOfUpDown.CheckedChanged += new System.EventHandler(this.updateRecordingSettings);
            // 
            // checkBoxClickInsteadOfUpDown
            // 
            this.checkBoxClickInsteadOfUpDown.AutoSize = true;
            this.checkBoxClickInsteadOfUpDown.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxClickInsteadOfUpDown.Location = new System.Drawing.Point(17, 69);
            this.checkBoxClickInsteadOfUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxClickInsteadOfUpDown.Name = "checkBoxClickInsteadOfUpDown";
            this.checkBoxClickInsteadOfUpDown.Size = new System.Drawing.Size(249, 27);
            this.checkBoxClickInsteadOfUpDown.TabIndex = 4;
            this.checkBoxClickInsteadOfUpDown.Text = "Click instead of btn up/down";
            this.checkBoxClickInsteadOfUpDown.UseVisualStyleBackColor = true;
            this.checkBoxClickInsteadOfUpDown.CheckedChanged += new System.EventHandler(this.updateRecordingSettings);
            // 
            // checkBoxIgnoreMouseMove
            // 
            this.checkBoxIgnoreMouseMove.AutoSize = true;
            this.checkBoxIgnoreMouseMove.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxIgnoreMouseMove.Location = new System.Drawing.Point(17, 34);
            this.checkBoxIgnoreMouseMove.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxIgnoreMouseMove.Name = "checkBoxIgnoreMouseMove";
            this.checkBoxIgnoreMouseMove.Size = new System.Drawing.Size(183, 27);
            this.checkBoxIgnoreMouseMove.TabIndex = 3;
            this.checkBoxIgnoreMouseMove.Text = "Ignore mouse move";
            this.checkBoxIgnoreMouseMove.UseVisualStyleBackColor = true;
            this.checkBoxIgnoreMouseMove.CheckedChanged += new System.EventHandler(this.updateRecordingSettings);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.panelBot);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.panelRecord);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(24, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(333, 336);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hot keys";
            // 
            // panelBot
            // 
            this.panelBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(30)))), ((int)(((byte)(20)))));
            this.panelBot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBot.Controls.Add(this.labelBot);
            this.panelBot.Controls.Add(this.label6);
            this.panelBot.Location = new System.Drawing.Point(25, 226);
            this.panelBot.Margin = new System.Windows.Forms.Padding(4);
            this.panelBot.Name = "panelBot";
            this.panelBot.Size = new System.Drawing.Size(265, 72);
            this.panelBot.TabIndex = 4;
            // 
            // labelBot
            // 
            this.labelBot.AutoSize = true;
            this.labelBot.BackColor = System.Drawing.Color.Transparent;
            this.labelBot.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBot.ForeColor = System.Drawing.Color.Gold;
            this.labelBot.Location = new System.Drawing.Point(142, 24);
            this.labelBot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBot.Name = "labelBot";
            this.labelBot.Size = new System.Drawing.Size(36, 18);
            this.labelBot.TabIndex = 3;
            this.labelBot.Text = "Off";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(91, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Bot:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(21, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start/Stop Bot: F8";
            // 
            // panelRecord
            // 
            this.panelRecord.BackColor = System.Drawing.Color.Green;
            this.panelRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRecord.Controls.Add(this.labelRecord);
            this.panelRecord.Controls.Add(this.label3);
            this.panelRecord.Location = new System.Drawing.Point(25, 148);
            this.panelRecord.Margin = new System.Windows.Forms.Padding(4);
            this.panelRecord.Name = "panelRecord";
            this.panelRecord.Size = new System.Drawing.Size(265, 68);
            this.panelRecord.TabIndex = 2;
            // 
            // labelRecord
            // 
            this.labelRecord.AutoSize = true;
            this.labelRecord.BackColor = System.Drawing.Color.Transparent;
            this.labelRecord.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRecord.ForeColor = System.Drawing.Color.Chocolate;
            this.labelRecord.Location = new System.Drawing.Point(155, 24);
            this.labelRecord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Size = new System.Drawing.Size(42, 18);
            this.labelRecord.TabIndex = 3;
            this.labelRecord.Text = "OFF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(76, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Record:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(21, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start/Stop Record: F7";
            // 
            // listBoxCommands
            // 
            this.listBoxCommands.BackColor = System.Drawing.Color.DarkBlue;
            this.listBoxCommands.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxCommands.ForeColor = System.Drawing.Color.White;
            this.listBoxCommands.FormattingEnabled = true;
            this.listBoxCommands.ItemHeight = 23;
            this.listBoxCommands.Location = new System.Drawing.Point(743, 45);
            this.listBoxCommands.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxCommands.Name = "listBoxCommands";
            this.listBoxCommands.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxCommands.Size = new System.Drawing.Size(332, 671);
            this.listBoxCommands.TabIndex = 10;
            this.listBoxCommands.SelectedIndexChanged += new System.EventHandler(this.listBoxCommands_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1107, 743);
            this.Controls.Add(this.groupBoxExecutionSettings);
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.groupBoxRecordSettings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxCommands);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "SuperBot by Mateusz Kisiel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxExecutionSettings.ResumeLayout(false);
            this.groupBoxExecutionSettings.PerformLayout();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.groupBoxKey.ResumeLayout(false);
            this.groupBoxKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).EndInit();
            this.groupBoxPosition.ResumeLayout(false);
            this.groupBoxPosition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            this.groupBoxRecordSettings.ResumeLayout(false);
            this.groupBoxRecordSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelBot.ResumeLayout(false);
            this.panelBot.PerformLayout();
            this.panelRecord.ResumeLayout(false);
            this.panelRecord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxExecutionSettings;
        private System.Windows.Forms.CheckBox checkBoxLoop;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxRecordSettings;
        private System.Windows.Forms.CheckBox checkBoxIgnoreMouseMove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelBot;
        private System.Windows.Forms.Label labelBot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelRecord;
        private System.Windows.Forms.Label labelRecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxCommands;
        private System.Windows.Forms.CheckBox checkBoxPressInsteadOfUpDown;
        private System.Windows.Forms.CheckBox checkBoxClickInsteadOfUpDown;
        private System.Windows.Forms.CheckBox checkBoxHumanMouseMove;
        private System.Windows.Forms.NumericUpDown numericUpDownDelay;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Button buttonPaste;
        private System.Windows.Forms.GroupBox groupBoxKey;
        private System.Windows.Forms.TextBox textBoxKey;
    }
}