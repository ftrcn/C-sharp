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
    class DeneClass
    {
        #region değişkenlerim
        public string yer;
        public int zaman;
        #endregion

        #region yaz metodum
        public void Yaz()
        {
            MessageBox.Show("DeneClass'ın 'Yaz' methodu çağrıldı");
        }
        #endregion

        public string hosgeldiniz(string Ad,string Soyad)
        {
            return Ad + " " + Soyad;

        }

    }
}
