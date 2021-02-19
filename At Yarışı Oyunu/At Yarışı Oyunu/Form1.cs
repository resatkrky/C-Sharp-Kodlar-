using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarışı_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birsoluzaklik, ikisoluzaklik, ucsoluzaklik;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(label7.Text);
            sayi++;
            label7.Text = sayi.ToString();

            int biratgenislik = pictureBox1.Width;
            int ikiatgenislik = pictureBox2.Width;
            int ucatgenislik = pictureBox3.Width;

            int bitisuzaklik = label5.Left;

            pictureBox1.Left += rastgele.Next(5, 15);
            pictureBox2.Left += rastgele.Next(5, 15);
            pictureBox3.Left += rastgele.Next(5, 15);

            if(pictureBox1.Left > pictureBox2.Left +5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "1 Numarali At Önde!!";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "2 Numarali At Önde!!";
            }
            if (pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox1.Left + 5)
            {
                label6.Text = "3 Numarali At Önde!!";
            }

            if (biratgenislik + pictureBox1.Left >= bitisuzaklik)
            {
                timer1.Enabled = false;
                MessageBox.Show("1 Numarali At Kazandi !!!!");
            }
            if (ikiatgenislik + pictureBox2.Left >= bitisuzaklik)
            {
                timer1.Enabled = false;
                MessageBox.Show("2 Numarali At Kazandi !!!!");
            }
            if (ucatgenislik + pictureBox3.Left >= bitisuzaklik)
            {
                timer1.Enabled = false;
                MessageBox.Show("3 Numarali At Kazandi !!!!");
            }
        }

        Random rastgele = new Random();
        private int biratgenislik;
        private int ikiatgenislik;
        private int ucatgenislik;
        private int bitisuzaklik;
        private int sayi;

        private void Form1_Load(object sender, EventArgs e)
        {
            birsoluzaklik = pictureBox1.Left;
            ikisoluzaklik = pictureBox2.Left;
            ucsoluzaklik = pictureBox3.Left;
        }
    }
}
