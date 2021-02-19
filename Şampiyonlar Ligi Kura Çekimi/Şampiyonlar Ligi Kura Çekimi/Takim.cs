using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Şampiyonlar_Ligi_Kura_Çekimi
{
    class Takim
    {
        private string TakimIsmi;
        private string TakimUlke;

        public Takim(string isim,string ulke)
        {
            TakimIsmi = isim;
            TakimUlke = ulke;
        }
        public string TeamName
        {
            get
            {
                return TakimIsmi;
            }
            set
            {
                TakimIsmi = value;
            }
        }
        public string TeamCountry
        {
            get
            {
                return TakimUlke;
            }
            set
            {
                TakimUlke = value;
            }
        }
        public override string ToString()
        {
            return TakimIsmi + "-" + TakimUlke;
        }
    }
}
