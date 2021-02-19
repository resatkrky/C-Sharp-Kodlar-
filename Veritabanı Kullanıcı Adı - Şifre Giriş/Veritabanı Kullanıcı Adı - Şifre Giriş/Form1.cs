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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("server=.; Initial Catalog=guvenlik;Integrated Security=SSPI");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string sql="select * from parola where ad=@adi AND sifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("adi", textBox1.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", textBox2.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglan);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    Form2 fr = new Form2();
                    fr.Show();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hatali giriş");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();

        }
    }
}
