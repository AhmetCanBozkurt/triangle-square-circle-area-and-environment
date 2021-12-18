
namespace Calısma
{
    partial class daire
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
            this.button_ucgen_kapat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_sıfırla_cevre = new System.Windows.Forms.Button();
            this.button_cevre_daire = new System.Windows.Forms.Button();
            this.textBox_yarıcap_cevre = new System.Windows.Forms.TextBox();
            this.label_cevre_sonuc_daire = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_daire_sıfırla = new System.Windows.Forms.Button();
            this.label_alan_sonuc = new System.Windows.Forms.Label();
            this.button_daire_alan_hesapla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_yarıcap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_daire_alan = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_ucgen_kapat
            // 
            this.button_ucgen_kapat.BackColor = System.Drawing.Color.Brown;
            this.button_ucgen_kapat.Location = new System.Drawing.Point(316, 402);
            this.button_ucgen_kapat.Name = "button_ucgen_kapat";
            this.button_ucgen_kapat.Size = new System.Drawing.Size(127, 37);
            this.button_ucgen_kapat.TabIndex = 5;
            this.button_ucgen_kapat.Text = "Geri dön";
            this.button_ucgen_kapat.UseVisualStyleBackColor = false;
            this.button_ucgen_kapat.Click += new System.EventHandler(this.button_ucgen_kapat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_sıfırla_cevre);
            this.groupBox2.Controls.Add(this.button_cevre_daire);
            this.groupBox2.Controls.Add(this.textBox_yarıcap_cevre);
            this.groupBox2.Controls.Add(this.label_cevre_sonuc_daire);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 193);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dairenin Çevresi";
            // 
            // button_sıfırla_cevre
            // 
            this.button_sıfırla_cevre.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_sıfırla_cevre.Location = new System.Drawing.Point(177, 125);
            this.button_sıfırla_cevre.Name = "button_sıfırla_cevre";
            this.button_sıfırla_cevre.Size = new System.Drawing.Size(100, 34);
            this.button_sıfırla_cevre.TabIndex = 9;
            this.button_sıfırla_cevre.Text = "Formu Sıfırla";
            this.button_sıfırla_cevre.UseVisualStyleBackColor = false;
            this.button_sıfırla_cevre.Click += new System.EventHandler(this.button_sıfırla_cevre_Click);
            // 
            // button_cevre_daire
            // 
            this.button_cevre_daire.BackColor = System.Drawing.Color.PeachPuff;
            this.button_cevre_daire.Location = new System.Drawing.Point(283, 125);
            this.button_cevre_daire.Name = "button_cevre_daire";
            this.button_cevre_daire.Size = new System.Drawing.Size(100, 34);
            this.button_cevre_daire.TabIndex = 8;
            this.button_cevre_daire.Text = "Çevre Hesapla";
            this.button_cevre_daire.UseVisualStyleBackColor = false;
            this.button_cevre_daire.Click += new System.EventHandler(this.button_cevre_daire_Click);
            // 
            // textBox_yarıcap_cevre
            // 
            this.textBox_yarıcap_cevre.Location = new System.Drawing.Point(101, 53);
            this.textBox_yarıcap_cevre.Name = "textBox_yarıcap_cevre";
            this.textBox_yarıcap_cevre.Size = new System.Drawing.Size(168, 20);
            this.textBox_yarıcap_cevre.TabIndex = 5;
            // 
            // label_cevre_sonuc_daire
            // 
            this.label_cevre_sonuc_daire.AutoSize = true;
            this.label_cevre_sonuc_daire.Location = new System.Drawing.Point(232, 95);
            this.label_cevre_sonuc_daire.Name = "label_cevre_sonuc_daire";
            this.label_cevre_sonuc_daire.Size = new System.Drawing.Size(0, 13);
            this.label_cevre_sonuc_daire.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Girilen bilgilere göre dairenizin çevresi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yarıçap (r)  :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_daire_alan);
            this.groupBox1.Controls.Add(this.button_daire_sıfırla);
            this.groupBox1.Controls.Add(this.label_alan_sonuc);
            this.groupBox1.Controls.Add(this.button_daire_alan_hesapla);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_yarıcap);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 185);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dairenin Alanı";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_daire_sıfırla
            // 
            this.button_daire_sıfırla.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_daire_sıfırla.Location = new System.Drawing.Point(177, 130);
            this.button_daire_sıfırla.Name = "button_daire_sıfırla";
            this.button_daire_sıfırla.Size = new System.Drawing.Size(100, 34);
            this.button_daire_sıfırla.TabIndex = 7;
            this.button_daire_sıfırla.Text = "Formu Sıfırla";
            this.button_daire_sıfırla.UseVisualStyleBackColor = false;
            this.button_daire_sıfırla.Click += new System.EventHandler(this.button_daire_sıfırla_Click);
            // 
            // label_alan_sonuc
            // 
            this.label_alan_sonuc.AutoSize = true;
            this.label_alan_sonuc.Location = new System.Drawing.Point(232, 130);
            this.label_alan_sonuc.Name = "label_alan_sonuc";
            this.label_alan_sonuc.Size = new System.Drawing.Size(0, 13);
            this.label_alan_sonuc.TabIndex = 6;
            // 
            // button_daire_alan_hesapla
            // 
            this.button_daire_alan_hesapla.BackColor = System.Drawing.Color.PeachPuff;
            this.button_daire_alan_hesapla.Location = new System.Drawing.Point(283, 130);
            this.button_daire_alan_hesapla.Name = "button_daire_alan_hesapla";
            this.button_daire_alan_hesapla.Size = new System.Drawing.Size(100, 34);
            this.button_daire_alan_hesapla.TabIndex = 5;
            this.button_daire_alan_hesapla.Text = "Alan Hesapla";
            this.button_daire_alan_hesapla.UseVisualStyleBackColor = false;
            this.button_daire_alan_hesapla.Click += new System.EventHandler(this.button_daire_alan_hesapla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Girilen bilgilere göre dairenizin alanı :";
            // 
            // textBox_yarıcap
            // 
            this.textBox_yarıcap.Location = new System.Drawing.Point(96, 48);
            this.textBox_yarıcap.Name = "textBox_yarıcap";
            this.textBox_yarıcap.Size = new System.Drawing.Size(181, 20);
            this.textBox_yarıcap.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yarıçap (r) :";
            // 
            // label_daire_alan
            // 
            this.label_daire_alan.AutoSize = true;
            this.label_daire_alan.Location = new System.Drawing.Point(223, 90);
            this.label_daire_alan.Name = "label_daire_alan";
            this.label_daire_alan.Size = new System.Drawing.Size(0, 13);
            this.label_daire_alan.TabIndex = 8;
            // 
            // daire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(447, 451);
            this.Controls.Add(this.button_ucgen_kapat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "daire";
            this.Text = "daire";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_ucgen_kapat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_sıfırla_cevre;
        private System.Windows.Forms.Button button_cevre_daire;
        private System.Windows.Forms.TextBox textBox_yarıcap_cevre;
        private System.Windows.Forms.Label label_cevre_sonuc_daire;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_daire_sıfırla;
        private System.Windows.Forms.Label label_alan_sonuc;
        private System.Windows.Forms.Button button_daire_alan_hesapla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_yarıcap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_daire_alan;
    }
}