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

namespace Kayıt_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("server=.; Initial Catalog=Kayıtlar;Integrated Security=SSPI");

        private void verilerigoster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From Gelenler2",baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Firma"].ToString());
                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert Into Gelenler(Id,Ad,Soyad,Firma) Values ('" + textBox1.Text.ToString() + " ' , ' " + textBox2.Text.ToString() + " ' , ' " + textBox3.Text.ToString()+ " ' , ' " + textBox4.Text.ToString() + " ')",baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        //int id = 0;
        //private void button3_Click(object sender, EventArgs e)
        //{
        //    baglan.Open();
        //    SqlCommand komut = new SqlCommand("Delete From Gelenler Where Ad=(" + id + ")", baglan);
        //    komut.ExecuteNonQuery();
        //    baglan.Close();
        //    verilerigoster();
        //}

        //private void button3_MouseDoubleClick(object sender, MouseEventArgs e)
        //{
        //    id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
        //    textBox4.Text = listView1.SelectedItems[0].SubItems[0].Text;
        //    textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
        //    textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
        //    textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
            
        //}
    }
    }

