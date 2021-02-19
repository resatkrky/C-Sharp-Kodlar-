using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Şampiyonlar_Ligi_Kura_Çekimi
{
    public partial class Form1 : Form
    {
        List<Takim> takimlar;

        List<ListBox> torbalar = new List<ListBox>();

        List<ListBox> gruplar = new List<ListBox>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Takim yenitakim = null;

            takimlar = new List<Takim>();

            yenitakim = new Takim("Bayern Münih", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Barcelona", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Chelsea", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Real Madrid", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Atletico Madrid", "İspanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Beşiktaş", "Türkiye");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Liverpool", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Manchester City", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Manchester United", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Tottenham", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Borussia Dortmund", "Almanya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Paris Saint Germain", "Fransa");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Olympique Lyonnais", "Fransa");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Juventus", "İtalya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("İnter", "İtalya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Roma", "İtalya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Napoli", "İtalya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Porto", "Portekiz");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Benfica", "Portekiz");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Arsenal", "İngiltere");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Olympiacos", "Yunanistan");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Milan", "İtalya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Ajax", "Hollanda");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("PSV", "Hollanda");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("CSKA Moskova", "Rusya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Spartak Moskova", "Rusya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Dynamo Kiev", "Ukrayna");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Shaktar Donetsk", "Ukrayna");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Anderlecht", "Belçika");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Club Brugge", "Belçika");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Galatasaray", "Türkiye");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Fenerbahçe", "Türkiye");
            takimlar.Add(yenitakim);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            List<int> secilentakimlar = new List<int>();
            for(int i = 0; i<4; i++)
            {
                secilentakimlar.Clear();
                for(int j = 0; j < 8; j++)
                {
                    int secilentakim = rastgele.Next(0, takimlar.Count / 4);

                    if (secilentakimlar.Contains(secilentakim))
                    {
                        i--;
                    }
                    else
                    {
                        secilentakimlar.Add(secilentakim);
                    }
                }
                bool ayniulkedentakimvar = false;
                for(int k = 0; k < 8; k++)
                {
                    ayniulkedentakimvar = Ayniulkedentakimvarmi(gruplar[k], torbalar[i].Items[secilentakimlar[k]] as Takim);
                    if (ayniulkedentakimvar)
                    {
                        break;
                    }
                }
                if (!ayniulkedentakimvar)
                {
                    listBox1.Items.Add(torbalar[i].Items[secilentakimlar[0]] as Takim);
                    listBox2.Items.Add(torbalar[i].Items[secilentakimlar[1]] as Takim);
                    listBox3.Items.Add(torbalar[i].Items[secilentakimlar[2]] as Takim);
                    listBox4.Items.Add(torbalar[i].Items[secilentakimlar[3]] as Takim);
                    listBox5.Items.Add(torbalar[i].Items[secilentakimlar[4]] as Takim);
                    listBox6.Items.Add(torbalar[i].Items[secilentakimlar[5]] as Takim);
                    listBox7.Items.Add(torbalar[i].Items[secilentakimlar[6]] as Takim);
                    listBox8.Items.Add(torbalar[i].Items[secilentakimlar[7]] as Takim);
                }
                else
                {
                    i--;
                }
            }
        }
        private bool Ayniulkedentakimvarmi(ListBox grup,Takim takim)
        {
            bool durum = false;
            for(int i = 0; i < grup.Items.Count; i++)
            {
                Takim gruptakim = grup.Items[i] as Takim;
                if(gruptakim.TeamCountry == takim.TeamCountry)
                {
                    durum = true;
                    break;
                }
            }
            return durum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            List<int> secilentakimlar = new List<int>();
            for(int i = 0; i < takimlar.Count; i++)
            {
                int secilentakim = rastgele.Next(0,takimlar.Count);
                if (secilentakimlar.Contains(secilentakim))
                {
                    i--;
                }
                else
                {
                    secilentakimlar.Add(secilentakim);
                }
            }
            for(int j = 0; j < secilentakimlar.Count; j++)
            {
                if (j< 8)
                {
                    Torba1.Items.Add(takimlar[secilentakimlar[j]]);
                }
                else if (j < 16)
                {
                    Torba1.Items.Add(takimlar[secilentakimlar[j]]);
                }
                else if (j < 24)
                {
                    Torba1.Items.Add(takimlar[secilentakimlar[j]]);
                }
                else
                {
                    Torba1.Items.Add(takimlar[secilentakimlar[j]]);
                }
            }
            torbalar.Add(Torba1);
            torbalar.Add(Torba2);
            torbalar.Add(Torba3);
            torbalar.Add(Torba4);

            gruplar.Add(listBox1);
            gruplar.Add(listBox2);
            gruplar.Add(listBox3);
            gruplar.Add(listBox4);
            gruplar.Add(listBox5);
            gruplar.Add(listBox6);
            gruplar.Add(listBox7);
            gruplar.Add(listBox8);
        }
    }
}
