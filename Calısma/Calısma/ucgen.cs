using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calısma
{
    public partial class ucgen : Form
    {
        public ucgen()
        {
            InitializeComponent();
        }

        private void button_ucgen_alan_hesapla_Click(object sender, EventArgs e)
        {
            double sonuc;


            sonuc = (Convert.ToDouble(textBox_taban.Text)*Convert.ToDouble(textBox_yukseklik.Text))/2;


            label_alan_sonuc.Text = sonuc.ToString();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_alan_sıfırla_Click(object sender, EventArgs e)
        {
            textBox_taban.Text = "";
            textBox_yukseklik.Text = "";
            label_alan_sonuc.Text = "";
        }

        private void button_cevre_Click(object sender, EventArgs e)
        {
            int cevre = Convert.ToInt32(textBox_1_kenar.Text) + Convert.ToInt32(textBox_2_kenar.Text) + Convert.ToInt32(textBox_3_kenar.Text);


            label_cevre_sonuc.Text = cevre.ToString();

        
        }

        private void button_sıfırla_cevre_Click(object sender, EventArgs e)
        {
            textBox_1_kenar.Text = "";
            textBox_2_kenar.Text = "";
            textBox_3_kenar.Text = "";
            label_cevre_sonuc.Text = "";
        }

        private void button_ucgen_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
