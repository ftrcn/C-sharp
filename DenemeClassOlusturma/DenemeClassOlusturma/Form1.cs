using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DenemeClassOlusturma
{
    public partial class Form1 : Form
    {
        #region Form tanımı
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region  Şehir Butonu
        private void button2_Click(object sender, EventArgs e)
        {
            DeneClass dene = new DeneClass();
            dene.yer = "samsun";
            dene.zaman = 12;
            MessageBox.Show(dene.yer);
        }
        #endregion

        #region Hoşgeldiniz Butonu
        private void btnHosgeldiniz_Click(object sender, EventArgs e)
        {
            DeneClass mysinif = new DeneClass();
            string sonuc = mysinif.hosgeldiniz("Ayşe", "Demir");
            label1.Text = sonuc;
        }
        #endregion

        #region  Yazı Butonu
        private void button3_Click(object sender, EventArgs e)
        {
            DeneClass mysinif = new DeneClass();
            mysinif.Yaz();
        }
        #endregion

        #region  Çıkış Butonu
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        
       
    }
}
