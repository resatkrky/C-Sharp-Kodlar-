using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("server=.; Initial Catalog=sorularım;Integrated Security=SSPI");
        int sayac = 0;
        int puan1 = 0;
        int zaman = 21;
        private void button1_Click(object sender, EventArgs e)
        {
            btnbasla.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            if (button1.Text== lbldogru.Text)
            {
                puan1 = puan1 + 10;
                lblpuan.Text = puan1.ToString();
                button1.BackColor = Color.Green;
            }
            else
            {
                button1.BackColor = Color.Red;
            }
        }

        private void btnbasla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            zaman = 21;

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            btnbasla.Enabled = false;
            
            btnbasla.Text = "Sonraki";
            sayac++;
            textBox1.Text = sayac.ToString();
            
            if (sayac == 1)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("select * from soru1 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
            if (sayac == 2)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("select * from soru2 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    button1.Text = (oku["a"].ToString());
                    button2.Text = (oku["b"].ToString());
                    button3.Text = (oku["c"].ToString());
                    button4.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogru.Text = (oku["dogru"].ToString());
                }
                baglan.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            btnbasla.Enabled = false;
            if (button2.Text == lbldogru.Text)
            {
                puan1 = puan1 + 10;
                lblpuan.Text = puan1.ToString();
                button2.BackColor = Color.Green;
            }
            else
            {
                button2.BackColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            btnbasla.Enabled = false;
            if (button3.Text == lbldogru.Text)
            {
                puan1 = puan1 + 10;
                lblpuan.Text = puan1.ToString();
                button3.BackColor = Color.Green;
            }
            else
            {
                button3.BackColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            btnbasla.Enabled = false;
            if (button3.Text == lbldogru.Text)
            {
                puan1 = puan1 + 10;
                lblpuan.Text = puan1.ToString();
                button4.BackColor = Color.Green;
            }
            else
            {
                button4.BackColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Başarılar";
            lbldogru.Visible = false;
            lblsoru.Text = sayac.ToString();
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman = zaman - zaman;
            lblzaman.Text = zaman.ToString();
            if(zaman == 0)
            {
                timer1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                btnbasla.Enabled = true;
            }
        }
    }
}
