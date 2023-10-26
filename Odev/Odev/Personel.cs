using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    internal class Personel
    {
        private string text1;
        private string text2;

        public Personel(string text1, string text2)
        {
            this.text1 = text1;
            this.text2 = text2;
        }
    }

    public Personel(string gAd, string gAdres, int Gyas)
    {
        this.Ad = gAd;
        this.Adres = gAdres;
        this.Yas = Gyas;
    }
        string ad;
        public string Ad
        {
            get => ad;
            set => ad = value;

        }
        string adres;
        public string Adres
        {
            get => adres;
            set => adres = value;

        }

        int yas;
        public int Yas
        {
            get => yas;
            set => yas = value;




        }
    }


