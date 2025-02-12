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
            GB_Rate = new GroupBox();
            TrB_VoiceRate = new TrackBar();
            GB_Volume = new GroupBox();
            TrB_VoiceVolume = new TrackBar();
            groupBox3 = new GroupBox();
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
            GB_Rate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrB_VoiceRate).BeginInit();
            GB_Volume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrB_VoiceVolume).BeginInit();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BT_PlayAudio
            // 
            BT_PlayAudio.Dock = DockStyle.Fill;
            BT_PlayAudio.Location = new System.Drawing.Point(0, 0);
            BT_PlayAudio.Name = "BT_PlayAudio";
            BT_PlayAudio.Size = new System.Drawing.Size(119, 24);
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
            BT_StopAudio.Size = new System.Drawing.Size(129, 24);
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
            BT_SaveAudio.Size = new System.Drawing.Size(256, 24);
            BT_SaveAudio.TabIndex = 3;
            BT_SaveAudio.Text = "Save Audio File...";
            BT_SaveAudio.UseVisualStyleBackColor = true;
            BT_SaveAudio.Click += BT_SaveAudio_Click;
            // 
            // RTB_Lines
            // 
            RTB_Lines.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RTB_Lines.Location = new System.Drawing.Point(6, 6);
            RTB_Lines.Name = "RTB_Lines";
            RTB_Lines.Size = new System.Drawing.Size(247, 313);
            RTB_Lines.TabIndex = 0;
            RTB_Lines.Text = "";
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
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
            splitContainer2.BorderStyle = BorderStyle.Fixed3D;
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
            qualityToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            qualityToolStripMenuItem.Text = "Export Quality";
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
            splitContainer3.Size = new System.Drawing.Size(535, 326);
            splitContainer3.SplitterDistance = 253;
            splitContainer3.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(GB_Rate);
            groupBox2.Controls.Add(GB_Volume);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new System.Drawing.Point(2, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(270, 218);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Settings";
            // 
            // GB_Rate
            // 
            GB_Rate.Controls.Add(TrB_VoiceRate);
            GB_Rate.Location = new System.Drawing.Point(6, 146);
            GB_Rate.Name = "GB_Rate";
            GB_Rate.Size = new System.Drawing.Size(258, 66);
            GB_Rate.TabIndex = 17;
            GB_Rate.TabStop = false;
            GB_Rate.Text = "Rate: 0";
            // 
            // TrB_VoiceRate
            // 
            TrB_VoiceRate.LargeChange = 1;
            TrB_VoiceRate.Location = new System.Drawing.Point(6, 14);
            TrB_VoiceRate.Minimum = -10;
            TrB_VoiceRate.Name = "TrB_VoiceRate";
            TrB_VoiceRate.Size = new System.Drawing.Size(246, 45);
            TrB_VoiceRate.TabIndex = 12;
            TrB_VoiceRate.TickStyle = TickStyle.Both;
            TrB_VoiceRate.ValueChanged += TrB_VoiceRate_ValueChanged;
            // 
            // GB_Volume
            // 
            GB_Volume.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            GB_Volume.Controls.Add(TrB_VoiceVolume);
            GB_Volume.Location = new System.Drawing.Point(6, 76);
            GB_Volume.Name = "GB_Volume";
            GB_Volume.Size = new System.Drawing.Size(258, 66);
            GB_Volume.TabIndex = 16;
            GB_Volume.TabStop = false;
            GB_Volume.Text = "Volume: 100";
            // 
            // TrB_VoiceVolume
            // 
            TrB_VoiceVolume.LargeChange = 10;
            TrB_VoiceVolume.Location = new System.Drawing.Point(6, 14);
            TrB_VoiceVolume.Maximum = 100;
            TrB_VoiceVolume.Name = "TrB_VoiceVolume";
            TrB_VoiceVolume.Size = new System.Drawing.Size(246, 45);
            TrB_VoiceVolume.TabIndex = 7;
            TrB_VoiceVolume.TickStyle = TickStyle.Both;
            TrB_VoiceVolume.Value = 100;
            TrB_VoiceVolume.ValueChanged += TrB_VoiceVolume_ValueChanged;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(CbB_SelectedVoice);
            groupBox3.Location = new System.Drawing.Point(6, 20);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(258, 52);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Voice";
            // 
            // CbB_SelectedVoice
            // 
            CbB_SelectedVoice.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CbB_SelectedVoice.AutoCompleteSource = AutoCompleteSource.ListItems;
            CbB_SelectedVoice.FormattingEnabled = true;
            CbB_SelectedVoice.Location = new System.Drawing.Point(6, 22);
            CbB_SelectedVoice.Name = "CbB_SelectedVoice";
            CbB_SelectedVoice.Size = new System.Drawing.Size(246, 23);
            CbB_SelectedVoice.TabIndex = 8;
            CbB_SelectedVoice.SelectedIndexChanged += TS_Voices_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(splitContainer2);
            groupBox1.Location = new System.Drawing.Point(2, 229);
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
            ClientSize = new System.Drawing.Size(535, 350);
            Controls.Add(splitContainer3);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new System.Drawing.Size(551, 389);
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
            GB_Rate.ResumeLayout(false);
            GB_Rate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrB_VoiceRate).EndInit();
            GB_Volume.ResumeLayout(false);
            GB_Volume.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrB_VoiceVolume).EndInit();
            groupBox3.ResumeLayout(false);
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
        private TrackBar TrB_VoiceRate;
        private ToolStripMenuItem qualityToolStripMenuItem;
        private ToolStripMenuItem TS_QualityLow;
        private ToolStripMenuItem TS_QualityMedium;
        private ToolStripMenuItem TS_QualityHigh;
        private GroupBox groupBox3;
        private GroupBox GB_Volume;
        private GroupBox GB_Rate;
    }
}
