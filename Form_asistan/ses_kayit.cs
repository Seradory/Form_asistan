using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Form_asistan
{
    public class ses_kayit
    {
        string WAV_FILE;
        string outputFilePath;
        WaveInEvent waveIn;
        WaveFileWriter writer = null;
        public ses_kayit(string wav_file)
        {
            WAV_FILE = wav_file;

            var outputFolder = Directory.GetCurrentDirectory();
            outputFilePath = Path.Combine(outputFolder, WAV_FILE);


        }

        public void kayit(bool baslat)
        {

            if (baslat)
            {
                waveIn = new WaveInEvent();


                writer = new WaveFileWriter(outputFilePath, waveIn.WaveFormat);
                SoundPlayer oynat = new SoundPlayer("start.wav");
                oynat.PlaySync();
                waveIn.StartRecording();
                waveIn.DataAvailable += (s, a) =>
                {
                    writer.Write(a.Buffer, 0, a.BytesRecorded);
                    if (writer.Position > waveIn.WaveFormat.AverageBytesPerSecond * 30)
                    {
                        waveIn.StopRecording();
                    }
                };

            }
            else
            {
                waveIn.StopRecording();
                SoundPlayer oynat = new SoundPlayer("stop.wav");
                oynat.PlaySync();
                writer?.Dispose();
                // writer.Close();
                writer = null;
                waveIn?.Dispose();

            }
        }





    }
}
