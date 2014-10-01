using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;

namespace EntityDeneme
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            
            derslerEntities dersler = new derslerEntities();// derslerEntitiesin bir instance(örnek)ını alıyoruz.
            kullanicilar kullanici = new kullanicilar();// derslerEntitiesin içindeki kullanicilar tablomuzun da bir instanceını alıyoruz.

            // Ad, Soyad ve Email alanlarının değerlerini atıyoruz.
            kullanici.Ad = txtAd.Text;
            kullanici.Soyad = txtSoyad.Text;
            kullanici.Email = txtEmail.Text;

            dersler.AddTokullanicilar(kullanici);// Değerleri atadıktan sonra entity frameworkun oluşturduğu AddTokullanicilar metodunu kullanıyoruz.
            dersler.SaveChanges(); // Değişiklikleri kaydediyoruz.
        }
    }
}