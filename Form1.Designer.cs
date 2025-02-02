using System;
using System.Windows.Forms;
namespace TTS_generator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BT_PlayAudio = new Button();
            BT_StopAudio = new Button();
            BT_SaveAudio = new Button();
            RTB_Lines = new RichTextBox();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            menuStrip1 = new MenuStrip();
            TS_File = new ToolStripMenuItem();
            reloadVoicesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            qualityToolStripMenuItem = new ToolStripMenuItem();
            TS_QualityLow = new ToolStripMenuItem();
            TS_QualityMedium = new ToolStripMenuItem();
            TS_QualityHigh = new ToolStripMenuItem();
            splitContainer3 = new SplitContainer();
            groupBox2 = new GroupBox();
            LB_VoiceRate = new Label();
            label4 = new Label();
            TrB_VoiceRate = new TrackBar();
            LB_VoiceVolume = new Label();
            label2 = new Label();
            label1 = new Label();
            TrB_VoiceVolume = new TrackBar();
            CbB_SelectedVoice = new ComboBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrB_VoiceRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrB_VoiceVolume).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BT_PlayAudio
            // 
            BT_PlayAudio.Dock = DockStyle.Fill;
            BT_PlayAudio.Location = new System.Drawing.Point(0, 0);
            BT_PlayAudio.Name = "BT_PlayAudio";
            BT_PlayAudio.Size = new System.Drawing.Size(121, 26);
            BT_PlayAudio.TabIndex = 1;
            BT_PlayAudio.Text = "Play.";
            BT_PlayAudio.UseVisualStyleBackColor = true;
            BT_PlayAudio.Click += BT_PlayAudio_Click;
            // 
            // BT_StopAudio
            // 
            BT_StopAudio.Dock = DockStyle.Fill;
            BT_StopAudio.Location = new System.Drawing.Point(0, 0);
            BT_StopAudio.Name = "BT_StopAudio";
            BT_StopAudio.Size = new System.Drawing.Size(131, 26);
            BT_StopAudio.TabIndex = 2;
            BT_StopAudio.Text = "Stop.";
            BT_StopAudio.UseVisualStyleBackColor = true;
            BT_StopAudio.Click += BT_StopAudio_Click;
            // 
            // BT_SaveAudio
            // 
            BT_SaveAudio.Dock = DockStyle.Fill;
            BT_SaveAudio.FlatStyle = FlatStyle.System;
            BT_SaveAudio.Location = new System.Drawing.Point(0, 0);
            BT_SaveAudio.Name = "BT_SaveAudio";
            BT_SaveAudio.Size = new System.Drawing.Size(258, 26);
            BT_SaveAudio.TabIndex = 3;
            BT_SaveAudio.Text = "Save Audio File...";
            BT_SaveAudio.UseVisualStyleBackColor = true;
            BT_SaveAudio.Click += BT_SaveAudio_Click;
            // 
            // RTB_Lines
            // 
            RTB_Lines.Dock = DockStyle.Fill;
            RTB_Lines.Location = new System.Drawing.Point(0, 0);
            RTB_Lines.Name = "RTB_Lines";
            RTB_Lines.Size = new System.Drawing.Size(253, 253);
            RTB_Lines.TabIndex = 0;
            RTB_Lines.Text = "";
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.FixedSingle;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(BT_PlayAudio);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(BT_StopAudio);
            splitContainer1.Size = new System.Drawing.Size(260, 28);
            splitContainer1.SplitterDistance = 123;
            splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            splitContainer2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer2.BorderStyle = BorderStyle.FixedSingle;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new System.Drawing.Point(5, 24);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(BT_SaveAudio);
            splitContainer2.Size = new System.Drawing.Size(260, 60);
            splitContainer2.SplitterDistance = 28;
            splitContainer2.TabIndex = 5;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { TS_File, qualityToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(535, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // TS_File
            // 
            TS_File.DropDownItems.AddRange(new ToolStripItem[] { reloadVoicesToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            TS_File.Name = "TS_File";
            TS_File.Size = new System.Drawing.Size(37, 20);
            TS_File.Text = "File";
            // 
            // reloadVoicesToolStripMenuItem
            // 
            reloadVoicesToolStripMenuItem.Name = "reloadVoicesToolStripMenuItem";
            reloadVoicesToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            reloadVoicesToolStripMenuItem.Text = "Reload Voices";
            reloadVoicesToolStripMenuItem.Click += reloadVoicesToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // qualityToolStripMenuItem
            // 
            qualityToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { TS_QualityLow, TS_QualityMedium, TS_QualityHigh });
            qualityToolStripMenuItem.Name = "qualityToolStripMenuItem";
            qualityToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            qualityToolStripMenuItem.Text = "Quality";
            // 
            // TS_QualityLow
            // 
            TS_QualityLow.Name = "TS_QualityLow";
            TS_QualityLow.Size = new System.Drawing.Size(119, 22);
            TS_QualityLow.Tag = "1";
            TS_QualityLow.Text = "Low";
            TS_QualityLow.Click += AudioQuality_ToolStripMenuItem_Click;
            // 
            // TS_QualityMedium
            // 
            TS_QualityMedium.Name = "TS_QualityMedium";
            TS_QualityMedium.Size = new System.Drawing.Size(119, 22);
            TS_QualityMedium.Tag = "2";
            TS_QualityMedium.Text = "Medium";
            TS_QualityMedium.Click += AudioQuality_ToolStripMenuItem_Click;
            // 
            // TS_QualityHigh
            // 
            TS_QualityHigh.Checked = true;
            TS_QualityHigh.CheckState = CheckState.Checked;
            TS_QualityHigh.Name = "TS_QualityHigh";
            TS_QualityHigh.Size = new System.Drawing.Size(119, 22);
            TS_QualityHigh.Tag = "3";
            TS_QualityHigh.Text = "High";
            TS_QualityHigh.Click += AudioQuality_ToolStripMenuItem_Click;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.FixedPanel = FixedPanel.Panel2;
            splitContainer3.IsSplitterFixed = true;
            splitContainer3.Location = new System.Drawing.Point(0, 24);
            splitContainer3.MinimumSize = new System.Drawing.Size(240, 250);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(RTB_Lines);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(groupBox2);
            splitContainer3.Panel2.Controls.Add(groupBox1);
            splitContainer3.Panel2MinSize = 278;
            splitContainer3.Size = new System.Drawing.Size(535, 253);
            splitContainer3.SplitterDistance = 253;
            splitContainer3.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(LB_VoiceRate);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(TrB_VoiceRate);
            groupBox2.Controls.Add(LB_VoiceVolume);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(TrB_VoiceVolume);
            groupBox2.Controls.Add(CbB_SelectedVoice);
            groupBox2.Location = new System.Drawing.Point(2, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(270, 145);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Settings";
            // 
            // LB_VoiceRate
            // 
            LB_VoiceRate.Location = new System.Drawing.Point(6, 110);
            LB_VoiceRate.Name = "LB_VoiceRate";
            LB_VoiceRate.Size = new System.Drawing.Size(50, 15);
            LB_VoiceRate.TabIndex = 14;
            LB_VoiceRate.Text = "0";
            LB_VoiceRate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(23, 95);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(33, 15);
            label4.TabIndex = 13;
            label4.Text = "Rate:";
            // 
            // TrB_VoiceRate
            // 
            TrB_VoiceRate.LargeChange = 1;
            TrB_VoiceRate.Location = new System.Drawing.Point(62, 95);
            TrB_VoiceRate.Minimum = -10;
            TrB_VoiceRate.Name = "TrB_VoiceRate";
            TrB_VoiceRate.Size = new System.Drawing.Size(202, 45);
            TrB_VoiceRate.TabIndex = 12;
            TrB_VoiceRate.TickStyle = TickStyle.Both;
            TrB_VoiceRate.ValueChanged += TrB_VoiceRate_ValueChanged;
            // 
            // LB_VoiceVolume
            // 
            LB_VoiceVolume.Location = new System.Drawing.Point(6, 66);
            LB_VoiceVolume.Name = "LB_VoiceVolume";
            LB_VoiceVolume.Size = new System.Drawing.Size(50, 15);
            LB_VoiceVolume.TabIndex = 11;
            LB_VoiceVolume.Text = "100";
            LB_VoiceVolume.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 51);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 15);
            label2.TabIndex = 10;
            label2.Text = "Volume:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 15);
            label1.TabIndex = 9;
            label1.Text = "Voice:";
            // 
            // TrB_VoiceVolume
            // 
            TrB_VoiceVolume.LargeChange = 10;
            TrB_VoiceVolume.Location = new System.Drawing.Point(62, 51);
            TrB_VoiceVolume.Maximum = 100;
            TrB_VoiceVolume.Name = "TrB_VoiceVolume";
            TrB_VoiceVolume.Size = new System.Drawing.Size(202, 45);
            TrB_VoiceVolume.TabIndex = 7;
            TrB_VoiceVolume.TickStyle = TickStyle.Both;
            TrB_VoiceVolume.Value = 100;
            TrB_VoiceVolume.ValueChanged += TrB_VoiceVolume_ValueChanged;
            // 
            // CbB_SelectedVoice
            // 
            CbB_SelectedVoice.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CbB_SelectedVoice.AutoCompleteSource = AutoCompleteSource.ListItems;
            CbB_SelectedVoice.FormattingEnabled = true;
            CbB_SelectedVoice.Location = new System.Drawing.Point(62, 22);
            CbB_SelectedVoice.Name = "CbB_SelectedVoice";
            CbB_SelectedVoice.Size = new System.Drawing.Size(202, 23);
            CbB_SelectedVoice.TabIndex = 8;
            CbB_SelectedVoice.SelectedIndexChanged += TS_Voices_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(splitContainer2);
            groupBox1.Location = new System.Drawing.Point(2, 156);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(270, 90);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Playback";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(535, 277);
            Controls.Add(splitContainer3);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new System.Drawing.Size(551, 316);
            Name = "Form1";
            Text = "Voice Synthesizer";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrB_VoiceRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrB_VoiceVolume).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BT_PlayAudio;
        private Button BT_StopAudio;
        private Button BT_SaveAudio;
        private RichTextBox RTB_Lines;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem TS_File;
        private ToolStripMenuItem reloadVoicesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private SplitContainer splitContainer3;
        private ComboBox CbB_SelectedVoice;
        private TrackBar TrB_VoiceVolume;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private Label LB_VoiceVolume;
        private Label LB_VoiceRate;
        private Label label4;
        private TrackBar TrB_VoiceRate;
        private ToolStripMenuItem qualityToolStripMenuItem;
        private ToolStripMenuItem TS_QualityLow;
        private ToolStripMenuItem TS_QualityMedium;
        private ToolStripMenuItem TS_QualityHigh;
    }
}
