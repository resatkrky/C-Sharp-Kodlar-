using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesneleri_Hareket_Ettirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            if (e.KeyCode == Keys.Right && x<300)
            {
                x = x + 5;
            }
            if (e.KeyCode == Keys.Left && x>0)
            {
                x = x - 5;
            }
            if (e.KeyCode == Keys.Up && y>0)
            {
                y = y - 5;
            }
            if (e.KeyCode == Keys.Down && y<300)
            {
                y = y + 5;
            }
            pictureBox1.Location = new Point(x,y);
        }
    }
}
