using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Speech.AudioFormat;
using System.Collections;
using System.Reflection;

namespace TTS_generator
{
    public class TtsSystem
    {
        private SpeechSynthesizer? _synth;
        private SpeechAudioFormatInfo _formatInfoHigh, _formatInfoMedium, _formatInfoLow;
        private List<InstalledVoice> _allVoices;
        private InstalledVoice _selectedVoice;
        private VoiceQuality _selectedQuality;
        private int _volume, _rate;
        public TtsSystem(VoiceQuality quality = VoiceQuality.HIGH, int volume = 100, int rate = 0)
        {
            //sixteen bit. clearer, but larger files.
            _formatInfoHigh = new SpeechAudioFormatInfo(44100, AudioBitsPerSample.Sixteen, AudioChannel.Mono);
            _formatInfoMedium = new SpeechAudioFormatInfo(16000, AudioBitsPerSample.Sixteen, AudioChannel.Mono);
            _formatInfoLow = new SpeechAudioFormatInfo(11025, AudioBitsPerSample.Sixteen, AudioChannel.Mono);
            //eight bit. smaller files, but has "background hiss" when speaking.
            //_formatInfoHigh = new SpeechAudioFormatInfo(44100, AudioBitsPerSample.Eight, AudioChannel.Mono);
            //_formatInfoMedium = new SpeechAudioFormatInfo(16000, AudioBitsPerSample.Eight, AudioChannel.Mono);
            //_formatInfoLow = new SpeechAudioFormatInfo(11025, AudioBitsPerSample.Eight, AudioChannel.Mono);
            _volume = volume;
            _rate = rate;
            _selectedQuality = quality;
            CreateSynthIfNeeded();
            _allVoices = new List<InstalledVoice>();
            GetVoices();
        }

        public void GetVoices()
        {
            CreateSynthIfNeeded();
            //get all voices, sort by name, then by culture
            _allVoices = _synth.GetInstalledVoices().OrderBy(x => x.VoiceInfo.Name).OrderBy(x => x.VoiceInfo.Culture.Name).ToList();
            //remove duplicate names; some voices have a version that is "<name> Desktop" and a version that is "<name>"
            _allVoices.RemoveAll(x => x.VoiceInfo.Name.EndsWith("Desktop"));
        }

        public string[] GetVoiceNames(bool resetVoices = false)
        {
            if (resetVoices)
            {
                _allVoices.Clear();
                GetVoices();
            }
            string[] res = new string[_allVoices.Count];
            for (int i = 0; i < _allVoices.Count; i++)
            {
                res[i] = $"{_allVoices[i].VoiceInfo.Name} ({_allVoices[i].VoiceInfo.Culture})";
            }
            return res;
        }

        public bool TrySetVoice(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            { return false; }
            if (name.EndsWith(')'))
            {
                name = name.Substring(0, name.LastIndexOf('(')).Trim();
            }
            for (int i = 0; i < _allVoices.Count; i++)
            {
                if (_allVoices[i].VoiceInfo.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    _selectedVoice = _allVoices[i];
                    return true;
                }
            }
            return false;
        }

        public void Speak(string text)
        {
            if (_selectedVoice == null)
            { return; }
            if (string.IsNullOrWhiteSpace(text))
            { return; }
            CreateSynthIfNeeded();
            SetVoiceAndSpeak(BuildVoicePrompt(text));
        }

        public void Stop()
        {
            if (_synth == null)
            { return; }
            if (_synth.State == SynthesizerState.Speaking)
            {
                _synth.SpeakAsyncCancelAll();
            }
        }

        public bool WriteSynthToFile(string text, string filePath)
        {
            if (_selectedVoice == null)
            { return false; }
            if (string.IsNullOrWhiteSpace(text))
            { return false; }
            CreateSynthIfNeeded();
            _synth.SetOutputToWaveFile(filePath, GetSelectedQuality());
            SetVoiceAndSpeak(BuildVoicePrompt(text));
            return true;
        }

        public SpeechAudioFormatInfo GetSelectedQuality()
        {
            switch (_selectedQuality)
            {
                case VoiceQuality.LOW:
                    return _formatInfoLow;
                case VoiceQuality.MEDIUM:
                    return _formatInfoMedium;
                case VoiceQuality.HIGH:
                default:
                    return _formatInfoHigh;
            }
        }

        private PromptBuilder BuildVoicePrompt(string text)
        {
            PromptBuilder builder = new PromptBuilder();
            builder.StartVoice(_selectedVoice.VoiceInfo.Culture);
            builder.AppendText(text);
            builder.EndVoice();
            return builder;
        }

        private void CreateSynthIfNeeded()
        {
            if (_synth != null)
            { return; }
            _synth = new SpeechSynthesizer();
            _synth.SetOutputToDefaultAudioDevice();
            _synth.Rate = _rate;
            _synth.Volume = _volume;
            InjectOneCoreVoices(_synth);
            _synth.StateChanged += _synth_StateChanged;
        }

        private void SetVoiceAndSpeak(PromptBuilder prompt)
        {
            _synth.SelectVoice(_selectedVoice.VoiceInfo.Name);
            _synth.SpeakAsync(prompt);
        }

        private void _synth_StateChanged(object? sender, StateChangedEventArgs e)
        {
            if (e.State == SynthesizerState.Ready && e.PreviousState == SynthesizerState.Speaking)
            {//finished speaking
                System.Diagnostics.Debug.WriteLine("Finished speaking");
                DisposeSynth();
            }
        }

        private void DisposeSynth()
        {//band-aid fix for memory leak present in the synthesizer            
            if (_synth != null)
            {
                _synth.Dispose();
                _synth = null;
            }
        }
        private void InjectOneCoreVoices(SpeechSynthesizer synthesizer)
        {
            //https://github.com/rampaa/JL/blob/master/JL.Windows/SpeechSynthesis/SpeechSynthesisReflectionUtils.cs
            //Microsoft decided to separate speech synthesis voice into two registry keys,
            //but only access one when performing "SpeechSynthesizer.GetInstalledVoices()".
            //This tries to Inject the other registy's voices into the installed voices.
            string voiceSynthesizerProperty = "VoiceSynthesizer";
            string installedVoicesField = "_installedVoices";
            string oneCoreVoiceRegistry = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Speech_OneCore\Voices";
            try
            {
                Assembly speechSynthesizerAssembly = Assembly.GetAssembly(typeof(SpeechSynthesizer))!;

                Type objectTokenCategoryType = speechSynthesizerAssembly.GetType("System.Speech.Internal.ObjectTokens.ObjectTokenCategory")!;
                Type voiceInfoType = speechSynthesizerAssembly.GetType("System.Speech.Synthesis.VoiceInfo")!;
                Type installedVoiceType = speechSynthesizerAssembly.GetType("System.Speech.Synthesis.InstalledVoice")!;

                object voiceSynthesizer = GetProperty(synthesizer, voiceSynthesizerProperty)!;
                List<InstalledVoice> installedVoices = (List<InstalledVoice>?)GetField(voiceSynthesizer, installedVoicesField)!;

                using IDisposable objectTokenCategory = (IDisposable?)objectTokenCategoryType
                    .GetMethod("Create", BindingFlags.Static | BindingFlags.NonPublic)?
                    .Invoke(null, [oneCoreVoiceRegistry])!;

                IEnumerable<object?> tokens = (IEnumerable<object?>?)objectTokenCategoryType
                    .GetMethod("FindMatchingTokens", BindingFlags.Instance | BindingFlags.NonPublic)?
                    .Invoke(objectTokenCategory, [null, null])!;

                foreach (object? token in tokens)
                {
                    if (token is null || GetProperty(token, "Attributes") is null)
                    {
                        continue;
                    }

                    VoiceInfo voiceInfo = (VoiceInfo)Activator.CreateInstance(voiceInfoType.Assembly.FullName!, voiceInfoType.FullName!, true, BindingFlags.Instance | BindingFlags.NonPublic, null, [token], null, null)!.Unwrap()!;
                    InstalledVoice installedVoice = (InstalledVoice)Activator.CreateInstance(installedVoiceType.Assembly.FullName!, installedVoiceType.FullName!, true, BindingFlags.Instance | BindingFlags.NonPublic, null, [voiceSynthesizer, voiceInfo], null, null)!.Unwrap()!;

                    installedVoices.Add(installedVoice);
                }
            }

            catch (Exception ex)
            {
            }

            object? GetProperty(object target, string propName)
            {
                return target.GetType().GetProperty(propName, BindingFlags.Instance | BindingFlags.NonPublic)?.GetValue(target);
            }

            object? GetField(object target, string propName)
            {
                return target.GetType().GetField(propName, BindingFlags.Instance | BindingFlags.NonPublic)?.GetValue(target);
            }
        }


        public SynthesizerState? CurrentState => _synth?.State;
        public VoiceQuality Quality { get => _selectedQuality; set => _selectedQuality = value; }
        public int Volume { get => _volume; set => _volume = value; }
        public int Rate { get => _rate; set => _rate = value; }

    }

    public enum VoiceQuality
    {
        //VERY_LOW = 0,//not used yet
        LOW = 1,
        MEDIUM = 2,
        HIGH = 3,
        //VERY_HIGH = 4,//not used yet
    }
}
