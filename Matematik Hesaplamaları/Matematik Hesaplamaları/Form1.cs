using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematik_Hesaplamaları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int birkenar;
            int çevre, alan;

            birkenar = Convert.ToInt32(textBox1.Text);

            alan = birkenar * birkenar;
            çevre = 4 * birkenar;

            label4.Text = alan.ToString();
            label8.Text = çevre.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
            textBox2.Visible = false;
            label1.Text = button1.Text;
            panel1.Visible = true;
            button5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = button2.Text;
            panel1.Visible = true;
            label9.Visible = true;
            textBox2.Visible = true;
            label2.Text = "Kısa Kenarı Giriniz";
            button4.Visible = false;
            button5.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int uzun, kısa;
            int dikçevre, dikalan;

            uzun = Convert.ToInt32(textBox1.Text);
            kısa = Convert.ToInt32(textBox2.Text);

            dikalan = uzun * kısa;
            dikçevre = 2 * uzun + 2 * kısa;

            label4.Text = dikalan.ToString();
            label8.Text = dikçevre.ToString();

        }
    }
}
