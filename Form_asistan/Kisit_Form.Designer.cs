namespace Form_asistan
{
    partial class Kisit_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_kisit_kapat = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ornek_soru_1 = new System.Windows.Forms.TextBox();
            this.textBox_Ornek_cevap_1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Ornek_cevap_2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ornek_soru_2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Ornek_cevap_3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_ornek_soru_3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_kisit_temizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_kisit_kapat
            // 
            this.button_kisit_kapat.Location = new System.Drawing.Point(652, 357);
            this.button_kisit_kapat.Name = "button_kisit_kapat";
            this.button_kisit_kapat.Size = new System.Drawing.Size(75, 23);
            this.button_kisit_kapat.TabIndex = 0;
            this.button_kisit_kapat.Text = "Kabul Et";
            this.button_kisit_kapat.UseVisualStyleBackColor = true;
            this.button_kisit_kapat.Click += new System.EventHandler(this.button_kisit_kapat_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(274, 373);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Sadece evet ya da hayır olarak cevap ver.";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kısıt Tanımı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Örnek Soru 1";
            // 
            // textBox_ornek_soru_1
            // 
            this.textBox_ornek_soru_1.Location = new System.Drawing.Point(375, 50);
            this.textBox_ornek_soru_1.Name = "textBox_ornek_soru_1";
            this.textBox_ornek_soru_1.Size = new System.Drawing.Size(413, 20);
            this.textBox_ornek_soru_1.TabIndex = 4;
            this.textBox_ornek_soru_1.Text = "2 + 2 = 4 müdür?";
            // 
            // textBox_Ornek_cevap_1
            // 
            this.textBox_Ornek_cevap_1.Location = new System.Drawing.Point(375, 76);
            this.textBox_Ornek_cevap_1.Name = "textBox_Ornek_cevap_1";
            this.textBox_Ornek_cevap_1.Size = new System.Drawing.Size(413, 20);
            this.textBox_Ornek_cevap_1.TabIndex = 6;
            this.textBox_Ornek_cevap_1.Text = "Evet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Örnek Cevap 1";
            // 
            // textBox_Ornek_cevap_2
            // 
            this.textBox_Ornek_cevap_2.Location = new System.Drawing.Point(375, 166);
            this.textBox_Ornek_cevap_2.Name = "textBox_Ornek_cevap_2";
            this.textBox_Ornek_cevap_2.Size = new System.Drawing.Size(413, 20);
            this.textBox_Ornek_cevap_2.TabIndex = 10;
            this.textBox_Ornek_cevap_2.Text = "Hayır";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Örnek Cevap 2";
            // 
            // textBox_ornek_soru_2
            // 
            this.textBox_ornek_soru_2.Location = new System.Drawing.Point(375, 140);
            this.textBox_ornek_soru_2.Name = "textBox_ornek_soru_2";
            this.textBox_ornek_soru_2.Size = new System.Drawing.Size(413, 20);
            this.textBox_ornek_soru_2.TabIndex = 8;
            this.textBox_ornek_soru_2.Text = "Araba bir hayvan mıdır?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Örnek Soru 2";
            // 
            // textBox_Ornek_cevap_3
            // 
            this.textBox_Ornek_cevap_3.Location = new System.Drawing.Point(375, 261);
            this.textBox_Ornek_cevap_3.Name = "textBox_Ornek_cevap_3";
            this.textBox_Ornek_cevap_3.Size = new System.Drawing.Size(413, 20);
            this.textBox_Ornek_cevap_3.TabIndex = 14;
            this.textBox_Ornek_cevap_3.Text = "Evet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(292, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Örnek Cevap 1";
            // 
            // textBox_ornek_soru_3
            // 
            this.textBox_ornek_soru_3.Location = new System.Drawing.Point(375, 235);
            this.textBox_ornek_soru_3.Name = "textBox_ornek_soru_3";
            this.textBox_ornek_soru_3.Size = new System.Drawing.Size(413, 20);
            this.textBox_ornek_soru_3.TabIndex = 12;
            this.textBox_ornek_soru_3.Text = "Su sıvı mıdır?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Örnek Soru 1";
            // 
            // button_kisit_temizle
            // 
            this.button_kisit_temizle.Location = new System.Drawing.Point(549, 357);
            this.button_kisit_temizle.Name = "button_kisit_temizle";
            this.button_kisit_temizle.Size = new System.Drawing.Size(75, 23);
            this.button_kisit_temizle.TabIndex = 15;
            this.button_kisit_temizle.Text = "Temizle";
            this.button_kisit_temizle.UseVisualStyleBackColor = true;
            this.button_kisit_temizle.Click += new System.EventHandler(this.button_kisit_temizle_Click);
            // 
            // Kisit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button_kisit_temizle);
            this.Controls.Add(this.textBox_Ornek_cevap_3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_ornek_soru_3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Ornek_cevap_2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_ornek_soru_2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Ornek_cevap_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_ornek_soru_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button_kisit_kapat);
            this.Name = "Kisit_Form";
            this.Text = "Kisit_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button_kisit_kapat;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox_ornek_soru_1;
        public System.Windows.Forms.TextBox textBox_Ornek_cevap_1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBox_Ornek_cevap_2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox_ornek_soru_2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBox_Ornek_cevap_3;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBox_ornek_soru_3;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button button_kisit_temizle;
    }
}