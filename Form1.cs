using System.Windows.Forms;

namespace TTS_generator
{
    public partial class Form1 : Form
    {
        private TtsSystem _tts;
        public Form1()
        {
            _tts = new TtsSystem();
            InitializeComponent();
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
            if (!_tts.TrySetVoice((string)CbB_SelectedVoice.SelectedItem))
            {
                Alert($"could not set voice to \"{(string)CbB_SelectedVoice.SelectedItem}\"", "error setting voice");
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

        private void SetTtsNames(bool resetVoices)
        {
            CbB_SelectedVoice.Items.Clear();
            string[] names = _tts.GetVoiceNames(resetVoices);
            if (names.Length == 0)
            {
                Alert("No voices were found.", "Error getting voices");
                return;
            }
            for (int i = 0; i < names.Length; i++)
            {

                CbB_SelectedVoice.Items.Add(names[i]);
            }
            CbB_SelectedVoice.SelectedIndex = 0;
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

        private void TrB_VoiceVolume_ValueChanged(object sender, System.EventArgs e)
        {
            GB_Volume.Text = "Volume: " + TrB_VoiceVolume.Value.ToString();
            _tts.Volume = TrB_VoiceVolume.Value;
        }

        private void TrB_VoiceRate_ValueChanged(object sender, System.EventArgs e)
        {
            //LB_VoiceRate.Text = TrB_VoiceRate.Value.ToString();
            GB_Rate.Text = "Rate: " + TrB_VoiceRate.Value.ToString();
            _tts.Rate = TrB_VoiceRate.Value;
        }
    }
}
