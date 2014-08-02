using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kullanıcı_girisi
{
    public partial class frgirisekrani : Form
    {
        public frgirisekrani()
        {
            InitializeComponent();
        }
        //public static string _kullanici;
        //public static string _seviye;

       private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       private void btngiris_Click(object sender, EventArgs e)
       {
           string kadi = "fatma";
           string sifre = "12345";
           int seviye = 2;
           string kad = txtkadi.Text;
           string sif = txtsifre.Text;
           if (kadi == kad && sifre == sif)
           {
               //_kullanici = kad;
               //_seviye = seviye.ToString();
               Global classAdimiz = new Global();
               Global._kullanici = kad;
               Global._seviye = seviye.ToString();
               frAnamenu frAnamenu = new frAnamenu();
               frAnamenu.Show();
               this.Visible = false;
           }
           else
           {
               MessageBox.Show("Kullanıcı veya şifre yanlış !");
               txtkadi.Clear();
               txtsifre.Clear();

           }
       }

       public static string _kullanici { get; set; }

       public static string _seviye { get; set; }
    }
}
