using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Personel prs1=new Personel(adTxt.Text,adresTxt.Text) Convert.ToInt32 (yasTxt.Text));

           /* Personel prs1 = new Personel();
            prs1.Ad = adTxt.Text;
            prs1.Adres = adresTxt.Text;
            prs1.Yas = Convert.ToInt32(yasTxt.Text);
           */

            MessageBox.Show("Ad=" + prs1.Ad +
                "\nAdres=" + prs1.Adres +
                "\nYaş=" + prs1.Yas
                );

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    // ücret hesaplama method yap. Githuba atılır maybe. method this.mesai*100 şeklinde. 
}
