using Google.Cloud.TextToSpeech.V1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Form_asistan
{
    public class text_to_speech
    {
        TextToSpeechClient text_client;
        string WAV_FILE;

        public text_to_speech(string wav_file)
        {
            System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "texttospeech.json");
            text_client = TextToSpeechClient.Create();
            WAV_FILE = wav_file;
        }






        public void string_gonder_sese_cevir(string speech_text)
        {
            SynthesisInput input = new SynthesisInput { Text = speech_text };
            VoiceSelectionParams voice_selection_params = new VoiceSelectionParams
            {
                LanguageCode = "tr",
                SsmlGender = SsmlVoiceGender.Neutral
            };
            AudioConfig ac = new AudioConfig();
            ac.AudioEncoding = AudioEncoding.Linear16;

            var response = text_client.SynthesizeSpeech(input, voice_selection_params, ac);
            using (Stream output = File.Create(WAV_FILE))
            {
                // response.AudioContent is a ByteString. This can easily be converted into
                // a byte array or written to a stream.
                response.AudioContent.WriteTo(output);
                output.Close();
            }

        }

        public void oynat()
        {
            SoundPlayer oynat = new SoundPlayer(WAV_FILE);
            oynat.Play();
            //oynat.Play();

        }



    }
}
