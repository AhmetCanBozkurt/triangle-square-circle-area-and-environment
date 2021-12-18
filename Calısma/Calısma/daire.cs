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
    public partial class daire : Form
    {
        public daire()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_daire_alan_hesapla_Click(object sender, EventArgs e)
        {

            double yarıcap =Convert.ToDouble( textBox_yarıcap.Text);


            double sonuc= Math.PI * Math.Pow(yarıcap, 2); //pi*r2

            label_daire_alan.Text =Math.Round( sonuc,2).ToString();


        }

        private void button_daire_sıfırla_Click(object sender, EventArgs e)
        {
            textBox_yarıcap.Text = "";
            label_daire_alan.Text = "";
        }

        private void button_cevre_daire_Click(object sender, EventArgs e)
        {
            double yarıcap = Int32.Parse(textBox_yarıcap_cevre.Text);

            double sonuc = 2 * Math.PI * yarıcap ;//2*pi*r




            label_cevre_sonuc_daire.Text = Math.Round(sonuc,2).ToString();
        }

        private void button_sıfırla_cevre_Click(object sender, EventArgs e)
        {
            label_cevre_sonuc_daire.Text = "";
            textBox_yarıcap_cevre.Text = "";
        
        
        }

        private void button_ucgen_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
