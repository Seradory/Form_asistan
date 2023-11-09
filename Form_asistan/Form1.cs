using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Form_asistan
{
    public partial class Form1 : Form
    {
        gpt_api api = new gpt_api();
        Kisit_Form f1;
        Image rec_on=Image.FromFile("rec_on.png");
        Image rec_off = Image.FromFile("rec_off.png");
        bool kayit_butonu=false;
        ses_kayit s1 = new ses_kayit("kayit.wav");

        speech_to_text stt;

        
        public Form1()
        {
            InitializeComponent();
            f1 = new Kisit_Form(api);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox_kisit_gir_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_kisit_gir.Checked)
            {
                f1.Show();
            }
            else { 
                f1.Hide();
                api.kısıt_gir("Normal Cevaplar vermeni istiyorum, kısıtsız davranabilirsin");
                
                
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button_Record_Start_Stop_Click(object sender, EventArgs e)
        {
            kayit_butonu=!kayit_butonu;
            
            
            if (kayit_butonu)
            {
                Button_Record_Start_Stop.Text = "Durdur";
                s1.kayit(kayit_butonu);
                pictureBox1.Image = rec_on;
            }
            else
            {
                Button_Record_Start_Stop.Text = "Kaydet";
                s1.kayit(kayit_butonu);
                pictureBox1.Image = rec_off;
            }

            
        }

        private void Button_Kaydi_Dinle_Click(object sender, EventArgs e)
        {
            SoundPlayer oynat = new SoundPlayer("kayit.wav");
            oynat.Play();
        }

        private void Button_farkli_kaydet_Click(object sender, EventArgs e)
        {
            //folderBrowserDialog1.ShowDialog();
            //var r1 = folderBrowserDialog1.SelectedPath;

            //File.Copy("kayit.wav", r1+"\\kayit.wav");
            saveFileDialog1.Filter = "Ses|*.wav"; // Filtreleri ayarlayın (isteğe bağlı).

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = saveFileDialog1.FileName;

                // Dosya yoluna verilerinizi kaydedin.
                // Örnek olarak, bir metin dosyasına veri yazalım:
                System.IO.File.Copy("kayit.wav", dosyaYolu);
            }

        }

        private void button_convert_Text_Click(object sender, EventArgs e)
        {
            stt = new speech_to_text("kayit.wav");
            stt.ses_gonder_text_cevir();
            richTextBox_Gonderilecek.Text =stt.sonuc_dondur(false);

        }

        private void button_giden_temizle_Click(object sender, EventArgs e)
        {
           // richTextBox_Gonderilecek.Clear();
        }

        private void button_gelen_temizle_Click(object sender, EventArgs e)
        {
            richTextBox_Gelen_Data.Clear();
        }

        private async void Button_Send_Data_Click(object sender, EventArgs e)
        {

            string cevap = await api.soru_sor_cevap_alAsync(richTextBox_Gonderilecek.Text, false);
            richTextBox_Gelen_Data.Text = richTextBox_Gelen_Data.Text + "\n" + cevap;
            
            if (checkBox_sesli_sonuc.Checked)
            {
                text_to_speech tts = new text_to_speech("sonuc.wav");
                tts.string_gonder_sese_cevir(cevap);
                tts.oynat();


            }
            /*if (!checkBox_kisit_gir.Checked) 
            { 
                string cevap =await api.soru_sor_cevap_alAsync(richTextBox_Gonderilecek.Text, false);
                richTextBox_Gelen_Data.Text = richTextBox_Gelen_Data.Text + "\n" + cevap;
            }
            else
            {

                if (f1.richTextBox1.Text!=string.Empty) { 
                if (f1.textBox_ornek_soru_1.Text != string.Empty && f1.textBox_Ornek_cevap_1.Text != string.Empty)
                {
                    if(f1.textBox_ornek_soru_2.Text != string.Empty && f1.textBox_Ornek_cevap_2.Text != string.Empty)
                    {
                        if (f1.textBox_ornek_soru_3.Text != string.Empty && f1.textBox_Ornek_cevap_3.Text != string.Empty)
                        {

                            api.kısıt_gir(f1.richTextBox1.Text, f1.textBox_ornek_soru_1.Text, f1.textBox_Ornek_cevap_1.Text, f1.textBox_ornek_soru_2.Text, f1.textBox_Ornek_cevap_2.Text, f1.textBox_ornek_soru_3.Text, f1.textBox_Ornek_cevap_3.Text);
                        }
                        else
                        {
                            api.kısıt_gir(f1.richTextBox1.Text, f1.textBox_ornek_soru_1.Text, f1.textBox_Ornek_cevap_1.Text, f1.textBox_ornek_soru_2.Text, f1.textBox_Ornek_cevap_2.Text);
                        }

                    }
                    else
                    {
                        api.kısıt_gir(f1.richTextBox1.Text, f1.textBox_ornek_soru_1.Text, f1.textBox_Ornek_cevap_1.Text);
                    }

                }

                else
                {
                    api.kısıt_gir(f1.richTextBox1.Text);
                }

                    string cevap = await api.soru_sor_cevap_alAsync(richTextBox_Gonderilecek.Text, false);
                    richTextBox_Gelen_Data.Text = richTextBox_Gelen_Data.Text + "\n" + cevap;
                }
               
                
                else
                {
                    MessageBox.Show("Kısıt Girilmedi");
                }
            }*/
        }

        private void richTextBox_Gonderilecek_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_sesli_sonuc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Ses|*.wav"; // Filtreleri ayarlayın (isteğe bağlı).

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = saveFileDialog1.FileName;

                // Dosya yoluna verilerinizi kaydedin.
                // Örnek olarak, bir metin dosyasına veri yazalım:
                System.IO.File.Copy("sonuc.wav", dosyaYolu);
            }
        }
    }
}
