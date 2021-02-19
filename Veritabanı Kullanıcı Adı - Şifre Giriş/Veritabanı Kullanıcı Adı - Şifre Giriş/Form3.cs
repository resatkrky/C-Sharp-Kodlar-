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

namespace Veritabanı_Kullanıcı_Adı___Şifre_Giriş
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("server=.; Initial Catalog=guvenlik;Integrated Security=SSPI");

        private void veriler()
        {
            SqlCommand komut = new SqlCommand("select * from parola", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["ad"].ToString());
                ekle.SubItems.Add(oku["sifre"].ToString());
                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }
        int id = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("", baglan);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            veriler();
        }
    }
}
