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
            BT_PlayAudio = new Button();
            BT_StopAudio = new Button();
            BT_SaveAudio = new Button();
            RTB_Lines = new RichTextBox();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            menuStrip1 = new MenuStrip();
            TS_File = new ToolStripMenuItem();
            reloadVoicesToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            TS_QualityLow = new ToolStripMenuItem();
            TS_QualityMedium = new ToolStripMenuItem();
            TS_QualityHigh = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // BT_PlayAudio
            // 
            BT_PlayAudio.Dock = DockStyle.Fill;
            BT_PlayAudio.Location = new System.Drawing.Point(0, 0);
            BT_PlayAudio.Name = "BT_PlayAudio";
            BT_PlayAudio.Size = new System.Drawing.Size(113, 26);
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
            BT_StopAudio.Size = new System.Drawing.Size(119, 26);
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
            BT_SaveAudio.Size = new System.Drawing.Size(238, 26);
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
            RTB_Lines.Size = new System.Drawing.Size(240, 187);
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
            splitContainer1.Size = new System.Drawing.Size(240, 28);
            splitContainer1.SplitterDistance = 115;
            splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            splitContainer2.BorderStyle = BorderStyle.FixedSingle;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new System.Drawing.Point(0, 0);
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
            splitContainer2.Size = new System.Drawing.Size(240, 60);
            splitContainer2.SplitterDistance = 28;
            splitContainer2.TabIndex = 5;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.FixedPanel = FixedPanel.Panel2;
            splitContainer3.IsSplitterFixed = true;
            splitContainer3.Location = new System.Drawing.Point(0, 24);
            splitContainer3.MinimumSize = new System.Drawing.Size(240, 250);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(RTB_Lines);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(splitContainer2);
            splitContainer3.Panel2MinSize = 60;
            splitContainer3.Size = new System.Drawing.Size(240, 251);
            splitContainer3.SplitterDistance = 187;
            splitContainer3.TabIndex = 6;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { TS_File });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(240, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // TS_File
            // 
            TS_File.DropDownItems.AddRange(new ToolStripItem[] { reloadVoicesToolStripMenuItem, toolStripMenuItem1, toolStripSeparator1, exitToolStripMenuItem });
            TS_File.Name = "TS_File";
            TS_File.Size = new System.Drawing.Size(37, 20);
            TS_File.Text = "File";
            // 
            // reloadVoicesToolStripMenuItem
            // 
            reloadVoicesToolStripMenuItem.Name = "reloadVoicesToolStripMenuItem";
            reloadVoicesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            reloadVoicesToolStripMenuItem.Text = "Reload Voices";
            reloadVoicesToolStripMenuItem.Click += reloadVoicesToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { TS_QualityLow, TS_QualityMedium, TS_QualityHigh });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            toolStripMenuItem1.Text = "Quality";
            // 
            // TS_QualityLow
            // 
            TS_QualityLow.Name = "TS_QualityLow";
            TS_QualityLow.Size = new System.Drawing.Size(180, 22);
            TS_QualityLow.Tag = "1";
            TS_QualityLow.Text = "Low";
            TS_QualityLow.Click += AudioQuality_ToolStripMenuItem_Click;
            // 
            // TS_QualityMedium
            // 
            TS_QualityMedium.Name = "TS_QualityMedium";
            TS_QualityMedium.Size = new System.Drawing.Size(180, 22);
            TS_QualityMedium.Tag = "2";
            TS_QualityMedium.Text = "Medium";
            TS_QualityMedium.Click += AudioQuality_ToolStripMenuItem_Click;
            // 
            // TS_QualityHigh
            // 
            TS_QualityHigh.Checked = true;
            TS_QualityHigh.CheckState = CheckState.Checked;
            TS_QualityHigh.Name = "TS_QualityHigh";
            TS_QualityHigh.Size = new System.Drawing.Size(180, 22);
            TS_QualityHigh.Tag = "3";
            TS_QualityHigh.Text = "High";
            TS_QualityHigh.Click += AudioQuality_ToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(240, 275);
            Controls.Add(splitContainer3);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new System.Drawing.Size(256, 314);
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
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private SplitContainer splitContainer3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem TS_File;
        private ToolStripMenuItem reloadVoicesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem TS_QualityLow;
        private ToolStripMenuItem TS_QualityMedium;
        private ToolStripMenuItem TS_QualityHigh;
    }
}
