using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaatDakikaMod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int deger;
            int dakika, saat;

            deger = Convert.ToInt32(textBox1.Text);

            saat = deger / 60;
            dakika = deger % 60;

            label2.Text = saat.ToString();
            label4.Text = dakika.ToString();
        }
    }
}
