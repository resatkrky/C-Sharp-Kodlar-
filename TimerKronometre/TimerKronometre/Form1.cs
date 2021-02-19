using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerKronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        int saniye = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            int salise = Convert.ToInt32(label1.Text);
            salise++;

            label1.Text = salise.ToString();

            if(salise == 99)
            {
                salise = 0;
                label1.Text = salise.ToString();
                saniye++;
                label2.Text = saniye.ToString();
            }
        }
    }
}
