using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_asistan
{
    public partial class Kisit_Form : Form
    {
        gpt_api api_f = null;
        public Kisit_Form(gpt_api api)
        {
            InitializeComponent();
            api_f=api;
        }

        private void button_kisit_kapat_Click(object sender, EventArgs e)
        {
            this.Hide();


                if (richTextBox1.Text != string.Empty)
                {
                    if (textBox_ornek_soru_1.Text != string.Empty && textBox_Ornek_cevap_1.Text != string.Empty)
                    {
                        if (textBox_ornek_soru_2.Text != string.Empty && textBox_Ornek_cevap_2.Text != string.Empty)
                        {
                            if (textBox_ornek_soru_3.Text != string.Empty && textBox_Ornek_cevap_3.Text != string.Empty)
                            {

                            api_f.kısıt_gir(richTextBox1.Text, textBox_ornek_soru_1.Text, textBox_Ornek_cevap_1.Text, textBox_ornek_soru_2.Text, textBox_Ornek_cevap_2.Text, textBox_ornek_soru_3.Text, textBox_Ornek_cevap_3.Text);
                           
                            }
                            else
                            {
                            api_f.kısıt_gir(richTextBox1.Text, textBox_ornek_soru_1.Text, textBox_Ornek_cevap_1.Text, textBox_ornek_soru_2.Text, textBox_Ornek_cevap_2.Text);
                           
                        }

                        }
                        else
                        {
                        api_f.kısıt_gir(richTextBox1.Text, textBox_ornek_soru_1.Text, textBox_Ornek_cevap_1.Text);
                      
                    }

                    }

                    else
                    {
                    api_f.kısıt_gir(richTextBox1.Text);
                    
                }

                }


                else
                {
                    MessageBox.Show("Kısıt Girilmedi");
                }
         }

        



        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_kisit_temizle_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
            this.textBox_ornek_soru_1.Clear();
            this.textBox_Ornek_cevap_1.Clear();
            this.textBox_ornek_soru_2.Clear();
            this.textBox_Ornek_cevap_2.Clear();
            this.textBox_ornek_soru_3.Clear();
            this.textBox_Ornek_cevap_3.Clear();
        }
    }
}
