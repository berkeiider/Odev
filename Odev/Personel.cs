using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    internal class Personel
    {
        public Personel ( string gAd, string gAdres , int gYas,int gMesai, string gUnvan )
        {
            this.ad = gAd;
            this.adres = gAdres;
            this.yas = gYas;
            this.mesai = gMesai;
            this.unvan = gUnvan;
        }

        public Personel()
        {
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
        string unvan;
        public string Unvan
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
        int mesai;
        public int Mesai
        {
            get
            {  return mesai; }
            set => mesai = value;



        }
       public int ucretHesapla()
        {
            return this.Mesai * 100;

        }
        public void ucretHesapla(int EkUcret)
        {
            MessageBox.Show((this.Mesai * 100 + EkUcret).ToString());
        }





        
    }
}
