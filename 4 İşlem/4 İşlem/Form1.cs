using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_İşlem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2;
            double toplam, fark, carpma, bolum;

            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);

            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            carpma = sayi1 * sayi2;
            bolum = sayi1 / sayi2;

            label7.Text = toplam.ToString();
            label10.Text = fark.ToString();
            label13.Text = carpma.ToString();
            label14.Text = bolum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
