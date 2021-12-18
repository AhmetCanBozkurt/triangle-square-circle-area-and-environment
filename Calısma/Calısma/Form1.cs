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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucgen ucgen = new ucgen();


            this.Hide();

            ucgen.ShowDialog();

            this.Show();


        }

        private void button_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            daire dr = new daire();

            this.Hide();

            dr.ShowDialog();

            this.Show();



        }
    }
}
