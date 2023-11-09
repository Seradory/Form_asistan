namespace Form_asistan
{
    partial class Form1
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
            this.checkBox_kisit_gir = new System.Windows.Forms.CheckBox();
            this.Button_Record_Start_Stop = new System.Windows.Forms.Button();
            this.richTextBox_Gelen_Data = new System.Windows.Forms.RichTextBox();
            this.checkBox_sesli_sonuc = new System.Windows.Forms.CheckBox();
            this.richTextBox_Gonderilecek = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_Kaydi_Dinle = new System.Windows.Forms.Button();
            this.Button_Send_Data = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_farkli_kaydet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button_convert_Text = new System.Windows.Forms.Button();
            this.button_gelen_temizle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_kisit_gir
            // 
            this.checkBox_kisit_gir.AutoSize = true;
            this.checkBox_kisit_gir.Location = new System.Drawing.Point(649, 12);
            this.checkBox_kisit_gir.Name = "checkBox_kisit_gir";
            this.checkBox_kisit_gir.Size = new System.Drawing.Size(61, 17);
            this.checkBox_kisit_gir.TabIndex = 0;
            this.checkBox_kisit_gir.Text = "Kısıt Gir";
            this.checkBox_kisit_gir.UseVisualStyleBackColor = true;
            this.checkBox_kisit_gir.CheckedChanged += new System.EventHandler(this.checkBox_kisit_gir_CheckedChanged);
            // 
            // Button_Record_Start_Stop
            // 
            this.Button_Record_Start_Stop.Location = new System.Drawing.Point(297, 12);
            this.Button_Record_Start_Stop.Name = "Button_Record_Start_Stop";
            this.Button_Record_Start_Stop.Size = new System.Drawing.Size(75, 23);
            this.Button_Record_Start_Stop.TabIndex = 1;
            this.Button_Record_Start_Stop.Text = "Kaydet";
            this.Button_Record_Start_Stop.UseVisualStyleBackColor = true;
            this.Button_Record_Start_Stop.Click += new System.EventHandler(this.Button_Record_Start_Stop_Click);
            // 
            // richTextBox_Gelen_Data
            // 
            this.richTextBox_Gelen_Data.Location = new System.Drawing.Point(449, 200);
            this.richTextBox_Gelen_Data.Name = "richTextBox_Gelen_Data";
            this.richTextBox_Gelen_Data.Size = new System.Drawing.Size(280, 201);
            this.richTextBox_Gelen_Data.TabIndex = 4;
            this.richTextBox_Gelen_Data.Text = "";
            // 
            // checkBox_sesli_sonuc
            // 
            this.checkBox_sesli_sonuc.AutoSize = true;
            this.checkBox_sesli_sonuc.Location = new System.Drawing.Point(649, 35);
            this.checkBox_sesli_sonuc.Name = "checkBox_sesli_sonuc";
            this.checkBox_sesli_sonuc.Size = new System.Drawing.Size(82, 17);
            this.checkBox_sesli_sonuc.TabIndex = 5;
            this.checkBox_sesli_sonuc.Text = "Sesli Sonuc";
            this.checkBox_sesli_sonuc.UseVisualStyleBackColor = true;
            this.checkBox_sesli_sonuc.CheckedChanged += new System.EventHandler(this.checkBox_sesli_sonuc_CheckedChanged);
            // 
            // richTextBox_Gonderilecek
            // 
            this.richTextBox_Gonderilecek.Location = new System.Drawing.Point(12, 200);
            this.richTextBox_Gonderilecek.Name = "richTextBox_Gonderilecek";
            this.richTextBox_Gonderilecek.Size = new System.Drawing.Size(280, 201);
            this.richTextBox_Gonderilecek.TabIndex = 6;
            this.richTextBox_Gonderilecek.Text = "";
            this.richTextBox_Gonderilecek.TextChanged += new System.EventHandler(this.richTextBox_Gonderilecek_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gonderilen Veri";
            // 
            // Button_Kaydi_Dinle
            // 
            this.Button_Kaydi_Dinle.Location = new System.Drawing.Point(297, 41);
            this.Button_Kaydi_Dinle.Name = "Button_Kaydi_Dinle";
            this.Button_Kaydi_Dinle.Size = new System.Drawing.Size(75, 23);
            this.Button_Kaydi_Dinle.TabIndex = 8;
            this.Button_Kaydi_Dinle.Text = "Kaydı Dinle";
            this.Button_Kaydi_Dinle.UseVisualStyleBackColor = true;
            this.Button_Kaydi_Dinle.Click += new System.EventHandler(this.Button_Kaydi_Dinle_Click);
            // 
            // Button_Send_Data
            // 
            this.Button_Send_Data.Location = new System.Drawing.Point(297, 99);
            this.Button_Send_Data.Name = "Button_Send_Data";
            this.Button_Send_Data.Size = new System.Drawing.Size(75, 23);
            this.Button_Send_Data.TabIndex = 9;
            this.Button_Send_Data.Text = "Gönder";
            this.Button_Send_Data.UseVisualStyleBackColor = true;
            this.Button_Send_Data.Click += new System.EventHandler(this.Button_Send_Data_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Gelen Veri";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Button_farkli_kaydet
            // 
            this.Button_farkli_kaydet.Location = new System.Drawing.Point(388, 41);
            this.Button_farkli_kaydet.Name = "Button_farkli_kaydet";
            this.Button_farkli_kaydet.Size = new System.Drawing.Size(167, 23);
            this.Button_farkli_kaydet.TabIndex = 11;
            this.Button_farkli_kaydet.Text = "Mevcut Kaydi Farklı Kaydet";
            this.Button_farkli_kaydet.UseVisualStyleBackColor = true;
            this.Button_farkli_kaydet.Click += new System.EventHandler(this.Button_farkli_kaydet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Form_asistan.Properties.Resources.rec_off;
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_convert_Text
            // 
            this.button_convert_Text.Location = new System.Drawing.Point(297, 70);
            this.button_convert_Text.Name = "button_convert_Text";
            this.button_convert_Text.Size = new System.Drawing.Size(75, 23);
            this.button_convert_Text.TabIndex = 13;
            this.button_convert_Text.Text = "Yazıya Çevir";
            this.button_convert_Text.UseVisualStyleBackColor = true;
            this.button_convert_Text.Click += new System.EventHandler(this.button_convert_Text_Click);
            // 
            // button_gelen_temizle
            // 
            this.button_gelen_temizle.Location = new System.Drawing.Point(449, 415);
            this.button_gelen_temizle.Name = "button_gelen_temizle";
            this.button_gelen_temizle.Size = new System.Drawing.Size(75, 23);
            this.button_gelen_temizle.TabIndex = 15;
            this.button_gelen_temizle.Text = "Temizle";
            this.button_gelen_temizle.UseVisualStyleBackColor = true;
            this.button_gelen_temizle.Click += new System.EventHandler(this.button_gelen_temizle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Gelen Cevabı Farklı Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog2_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_gelen_temizle);
            this.Controls.Add(this.button_convert_Text);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Button_farkli_kaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Button_Send_Data);
            this.Controls.Add(this.Button_Kaydi_Dinle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox_Gonderilecek);
            this.Controls.Add(this.checkBox_sesli_sonuc);
            this.Controls.Add(this.richTextBox_Gelen_Data);
            this.Controls.Add(this.Button_Record_Start_Stop);
            this.Controls.Add(this.checkBox_kisit_gir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_kisit_gir;
        private System.Windows.Forms.Button Button_Record_Start_Stop;
        private System.Windows.Forms.RichTextBox richTextBox_Gelen_Data;
        private System.Windows.Forms.CheckBox checkBox_sesli_sonuc;
        private System.Windows.Forms.RichTextBox richTextBox_Gonderilecek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button_Kaydi_Dinle;
        private System.Windows.Forms.Button Button_Send_Data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_farkli_kaydet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button_convert_Text;
        private System.Windows.Forms.Button button_gelen_temizle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    }
}

