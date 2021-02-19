﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trafik_Lambaları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(label1.Text);
            sayi++;

            label1.Text = sayi.ToString();

            if(sayi == 30)
            {
                button2.BackColor = Color.Yellow;
            }
            if(sayi == 40)
            {
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Green;
            }
            if(sayi == 70)
            {
                sayi = 0;
                label1.Text = sayi.ToString();
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Gray;
            }
        }
    }
}
