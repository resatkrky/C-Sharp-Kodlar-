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

namespace Veritabanı_Arama_Komutu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("server=.; Initial Catalog=Bilgi;Integrated Security=SSPI");

        private void verigoster()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from Kisiler", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ad"].ToString();
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["yas"].ToString());
                ekle.SubItems.Add(oku["ilce"].ToString());
                ekle.SubItems.Add(oku["meslek"].ToString());

                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verigoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from Kisiler where ad like '%" + textBox1.Text+"%'", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ad"].ToString();
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["yas"].ToString());
                ekle.SubItems.Add(oku["ilce"].ToString());
                ekle.SubItems.Add(oku["meslek"].ToString());

                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }
    }
}
