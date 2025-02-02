using System.Windows.Forms;
using TTS_generator.FormAddons;

namespace TTS_generator
{
    public partial class Form1 : Form
    {
        private TtsSystem _tts;
        private ToolStripSpringComboBox TS_Voices;
        public Form1()
        {
            _tts = new TtsSystem();
            InitializeComponent();
            AddComboBox();
            menuStrip1.Items.Add(TS_Voices);
            SetTtsNames(false);
        }

        private void BT_PlayAudio_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RTB_Lines.Text))
            { return; }
            _tts.Speak(RTB_Lines.Text);
        }

        private void BT_StopAudio_Click(object sender, System.EventArgs e)
        {
            _tts.Stop();
        }

        private void BT_SaveAudio_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RTB_Lines.Text))
            {
                Alert("No Text to synthesize.", "No text");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Wave audio file (*.wav)|*.wav";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    _tts.WriteSynthToFile(RTB_Lines.Text, sfd.FileName);
                    MessageBox.Show($"Saved To \"{System.IO.Path.GetFileNameWithoutExtension(sfd.FileName)}\"", "Saved Succesfully", MessageBoxButtons.OK);
                }
            }
        }

        #region Toolstrip events
        private void TS_Voices_SelectedIndexChanged(object? sender, System.EventArgs e)
        {
            _tts.Stop();
            if (!_tts.TrySetVoice((string)TS_Voices.SelectedItem))
            {
                Alert($"could not set voice to \"{(string)TS_Voices.SelectedItem}\"", "error setting voice");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            _tts.Stop();
            this.Close();
        }

        private void reloadVoicesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            SetTtsNames(true);
        }
        #endregion


        private void AddComboBox()
        {
            TS_Voices = new ToolStripSpringComboBox();
            TS_Voices.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TS_Voices.AutoCompleteSource = AutoCompleteSource.ListItems;
            TS_Voices.SelectedIndexChanged += TS_Voices_SelectedIndexChanged;
        }

        private void SetTtsNames(bool resetVoices)
        {
            TS_Voices.Items.Clear();
            string[] names = _tts.GetVoiceNames(resetVoices);
            if (names.Length == 0)
            {
                Alert("No voices were found.", "Error getting voices");
                return;
            }
            for (int i = 0; i < names.Length; i++)
            {
                TS_Voices.Items.Add(names[i]);
            }
            TS_Voices.SelectedIndex = 0;
        }

        private void Alert(string? message, string? title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK);
        }

        private void AudioQuality_ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ToolStripMenuItem item = ((ToolStripMenuItem)sender);
            VoiceQuality qual;
            if (!int.TryParse(item.Tag?.ToString(), out int val))
            {
                qual = VoiceQuality.HIGH;
            }
            else
            {//TODO: handle "incorrect values"
                qual = (VoiceQuality)val;
            }
            _tts.Quality = qual;
            TS_QualityLow.Checked = false;
            TS_QualityMedium.Checked = false;
            TS_QualityHigh.Checked = false;
            item.Checked = true;
        }
    }
}
