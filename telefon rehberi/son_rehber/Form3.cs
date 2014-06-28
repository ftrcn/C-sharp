using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace son_rehber
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
       
        
        SqlDataAdapter da;
        DataSet ds;


        SqlConnection baglan = new SqlConnection("Data Source=.; Initial Catalog=rehber; Integrated Security=true");

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            /*Öncelikle sorgu isminde string tipinde bir değişken oluşturduk ve bu değişkene 
        veritabanındaki kaydı güncellemek için kullandığımız update set sorgu ifadesini kullandık.
        Bunu yaparken de Kisi tablosundaki alanları uygulamamızdaki Text kutularına eşitledik.
        Kayıt Güncelleme sorgumuz sorgu değişkenimizin içerisinde*/
            
              
                string sorgu = "update kisi set bolum_id='" + textBox1.Text + "',ad_soyad='" + textBox2.Text + "',telefon='" + textBox3.Text + "',e_mail='" + textBox4.Text + "',meslek='" + textBox5.Text + "' where id_kisi='" + Global.c_id + "'";
                //Burda ise en üstte tanımlamış olduğumuz 
                //komut ismindeki SqlCommand nesnesine sorgu değişkenindeki update set ifadesine eşitledik.
                SqlCommand komut = new SqlCommand(sorgu, baglan);
                //Bağlantımızı açtık.
                baglan.Open();
                //Komutumuzu Çalıştırdık.
                if (komut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt güncellendi.", "Güncelleme");
                
                //En son olarak bağlantımızı kapattık.Her zaman açtığımız bağlantıyı kapatmamız gereklidir.
                baglan.Close();
                //Daha Önceden Oluşturduğumuz Alt Programın Çalışmasını Sağlar.
                //yukle();
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            string sorgu = "select * from kisi where id_kisi='" + Global.c_id + "'";
            da = new SqlDataAdapter(sorgu,baglan);
            ds = new DataSet();
            da.Fill(ds, "kisi");
            baglan.Close();
            textBox1.Text = ds.Tables[0].Rows[0]["bolum_id"].ToString();
            textBox2.Text=ds.Tables[0].Rows[0]["ad_soyad"].ToString();
            textBox3.Text = ds.Tables[0].Rows[0]["telefon"].ToString();
            textBox4.Text = ds.Tables[0].Rows[0]["e_mail"].ToString();
            textBox5.Text = ds.Tables[0].Rows[0]["meslek"].ToString();
           
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Visible = false; 
        }


     

      
      
    }
}
