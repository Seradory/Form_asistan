using Google.Cloud.Speech.V1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_asistan
{
    public class speech_to_text
    {
        SpeechClient speechClient;
        string WAV_FILE;
        RecognizeResponse response1;
        public speech_to_text(string wav_file)
        {
            System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "handy-boulevard-401312-05fccb8b1cfa.json");
            speechClient = SpeechClient.Create();
            WAV_FILE = wav_file;

        }

        public void ses_gonder_text_cevir()
        {
            FileStream fileStream = new FileStream(WAV_FILE, FileMode.Open, FileAccess.Read);


            RecognitionAudio audio5 = RecognitionAudio.FromStream(fileStream);


            RecognitionConfig config = new RecognitionConfig
            {
                Encoding = RecognitionConfig.Types.AudioEncoding.Linear16,
                SampleRateHertz = 8000,
                LanguageCode = LanguageCodes.Turkish.Turkey
            };
            response1 = speechClient.Recognize(config, audio5);
            fileStream.Close();
        }
        public string sonuc_dondur(bool logla)
        {
            string transcript = null;
            foreach (var result in response1.Results)
            {
                foreach (var alternative in result.Alternatives)
                {
                    transcript = alternative.Transcript;
                    if (logla)
                    {
                        Console.WriteLine("\nRaw Data: " + response1.Results);
                        Console.WriteLine("\n\nTranscript: " + transcript + "\n");
                        return transcript;
                    }
                }
            }

            return transcript;
        }



    }
}
