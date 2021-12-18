
namespace Calısma
{
    partial class ucgen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_taban = new System.Windows.Forms.TextBox();
            this.textBox_yukseklik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_ucgen_alan_hesapla = new System.Windows.Forms.Button();
            this.label_alan_sonuc = new System.Windows.Forms.Label();
            this.button_alan_sıfırla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_cevre_sonuc = new System.Windows.Forms.Label();
            this.textBox_1_kenar = new System.Windows.Forms.TextBox();
            this.textBox_2_kenar = new System.Windows.Forms.TextBox();
            this.textBox_3_kenar = new System.Windows.Forms.TextBox();
            this.button_sıfırla_cevre = new System.Windows.Forms.Button();
            this.button_cevre = new System.Windows.Forms.Button();
            this.button_ucgen_kapat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_alan_sıfırla);
            this.groupBox1.Controls.Add(this.label_alan_sonuc);
            this.groupBox1.Controls.Add(this.button_ucgen_alan_hesapla);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_yukseklik);
            this.groupBox1.Controls.Add(this.textBox_taban);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üçgenin Alanı";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_sıfırla_cevre);
            this.groupBox2.Controls.Add(this.textBox_3_kenar);
            this.groupBox2.Controls.Add(this.button_cevre);
            this.groupBox2.Controls.Add(this.textBox_2_kenar);
            this.groupBox2.Controls.Add(this.textBox_1_kenar);
            this.groupBox2.Controls.Add(this.label_cevre_sonuc);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(27, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Üçgenin Çevresi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Taban :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yükseklik :";
            // 
            // textBox_taban
            // 
            this.textBox_taban.Location = new System.Drawing.Point(109, 43);
            this.textBox_taban.Name = "textBox_taban";
            this.textBox_taban.Size = new System.Drawing.Size(181, 20);
            this.textBox_taban.TabIndex = 2;
            // 
            // textBox_yukseklik
            // 
            this.textBox_yukseklik.Location = new System.Drawing.Point(109, 85);
            this.textBox_yukseklik.Name = "textBox_yukseklik";
            this.textBox_yukseklik.Size = new System.Drawing.Size(181, 20);
            this.textBox_yukseklik.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Girilen bilgilere göre üçgeninizin alanı :";
            // 
            // button_ucgen_alan_hesapla
            // 
            this.button_ucgen_alan_hesapla.BackColor = System.Drawing.Color.PeachPuff;
            this.button_ucgen_alan_hesapla.Location = new System.Drawing.Point(283, 188);
            this.button_ucgen_alan_hesapla.Name = "button_ucgen_alan_hesapla";
            this.button_ucgen_alan_hesapla.Size = new System.Drawing.Size(100, 34);
            this.button_ucgen_alan_hesapla.TabIndex = 5;
            this.button_ucgen_alan_hesapla.Text = "Alan Hesapla";
            this.button_ucgen_alan_hesapla.UseVisualStyleBackColor = false;
            this.button_ucgen_alan_hesapla.Click += new System.EventHandler(this.button_ucgen_alan_hesapla_Click);
            // 
            // label_alan_sonuc
            // 
            this.label_alan_sonuc.AutoSize = true;
            this.label_alan_sonuc.Location = new System.Drawing.Point(232, 130);
            this.label_alan_sonuc.Name = "label_alan_sonuc";
            this.label_alan_sonuc.Size = new System.Drawing.Size(0, 13);
            this.label_alan_sonuc.TabIndex = 6;
            // 
            // button_alan_sıfırla
            // 
            this.button_alan_sıfırla.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_alan_sıfırla.Location = new System.Drawing.Point(177, 188);
            this.button_alan_sıfırla.Name = "button_alan_sıfırla";
            this.button_alan_sıfırla.Size = new System.Drawing.Size(100, 34);
            this.button_alan_sıfırla.TabIndex = 7;
            this.button_alan_sıfırla.Text = "Formu Sıfırla";
            this.button_alan_sıfırla.UseVisualStyleBackColor = false;
            this.button_alan_sıfırla.Click += new System.EventHandler(this.button_alan_sıfırla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "1.Kenar :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "2.Kenar :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "3.Kenar : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Girilen bilgilere göre üçgeninizin çevresi :";
            // 
            // label_cevre_sonuc
            // 
            this.label_cevre_sonuc.AutoSize = true;
            this.label_cevre_sonuc.Location = new System.Drawing.Point(235, 174);
            this.label_cevre_sonuc.Name = "label_cevre_sonuc";
            this.label_cevre_sonuc.Size = new System.Drawing.Size(0, 13);
            this.label_cevre_sonuc.TabIndex = 4;
            // 
            // textBox_1_kenar
            // 
            this.textBox_1_kenar.Location = new System.Drawing.Point(109, 56);
            this.textBox_1_kenar.Name = "textBox_1_kenar";
            this.textBox_1_kenar.Size = new System.Drawing.Size(168, 20);
            this.textBox_1_kenar.TabIndex = 5;
            // 
            // textBox_2_kenar
            // 
            this.textBox_2_kenar.Location = new System.Drawing.Point(109, 93);
            this.textBox_2_kenar.Name = "textBox_2_kenar";
            this.textBox_2_kenar.Size = new System.Drawing.Size(168, 20);
            this.textBox_2_kenar.TabIndex = 6;
            // 
            // textBox_3_kenar
            // 
            this.textBox_3_kenar.Location = new System.Drawing.Point(109, 132);
            this.textBox_3_kenar.Name = "textBox_3_kenar";
            this.textBox_3_kenar.Size = new System.Drawing.Size(168, 20);
            this.textBox_3_kenar.TabIndex = 7;
            // 
            // button_sıfırla_cevre
            // 
            this.button_sıfırla_cevre.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_sıfırla_cevre.Location = new System.Drawing.Point(169, 218);
            this.button_sıfırla_cevre.Name = "button_sıfırla_cevre";
            this.button_sıfırla_cevre.Size = new System.Drawing.Size(100, 34);
            this.button_sıfırla_cevre.TabIndex = 9;
            this.button_sıfırla_cevre.Text = "Formu Sıfırla";
            this.button_sıfırla_cevre.UseVisualStyleBackColor = false;
            this.button_sıfırla_cevre.Click += new System.EventHandler(this.button_sıfırla_cevre_Click);
            // 
            // button_cevre
            // 
            this.button_cevre.BackColor = System.Drawing.Color.PeachPuff;
            this.button_cevre.Location = new System.Drawing.Point(275, 218);
            this.button_cevre.Name = "button_cevre";
            this.button_cevre.Size = new System.Drawing.Size(100, 34);
            this.button_cevre.TabIndex = 8;
            this.button_cevre.Text = "Çevre Hesapla";
            this.button_cevre.UseVisualStyleBackColor = false;
            this.button_cevre.Click += new System.EventHandler(this.button_cevre_Click);
            // 
            // button_ucgen_kapat
            // 
            this.button_ucgen_kapat.BackColor = System.Drawing.Color.Brown;
            this.button_ucgen_kapat.Location = new System.Drawing.Point(340, 599);
            this.button_ucgen_kapat.Name = "button_ucgen_kapat";
            this.button_ucgen_kapat.Size = new System.Drawing.Size(127, 37);
            this.button_ucgen_kapat.TabIndex = 2;
            this.button_ucgen_kapat.Text = "Geri dön";
            this.button_ucgen_kapat.UseVisualStyleBackColor = false;
            this.button_ucgen_kapat.Click += new System.EventHandler(this.button_ucgen_kapat_Click);
            // 
            // ucgen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(479, 659);
            this.Controls.Add(this.button_ucgen_kapat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucgen";
            this.Text = "ucgen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_alan_sonuc;
        private System.Windows.Forms.Button button_ucgen_alan_hesapla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_yukseklik;
        private System.Windows.Forms.TextBox textBox_taban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_alan_sıfırla;
        private System.Windows.Forms.Button button_sıfırla_cevre;
        private System.Windows.Forms.TextBox textBox_3_kenar;
        private System.Windows.Forms.Button button_cevre;
        private System.Windows.Forms.TextBox textBox_2_kenar;
        private System.Windows.Forms.TextBox textBox_1_kenar;
        private System.Windows.Forms.Label label_cevre_sonuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_ucgen_kapat;
    }
}