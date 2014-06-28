using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace son_rehber
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string byol = "Data Source=.; Initial Catalog=rehber; Integrated Security=true";
            SqlConnection baglanti = new SqlConnection(byol);
            SqlCommand kmt=new SqlCommand();
            baglanti.Open();
            kmt.Connection=baglanti;
            kmt.CommandText = " insert into kisi(bolum_id,ad_soyad,telefon,e_mail,meslek) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"+ textBox5.Text+"')";
            kmt.ExecuteNonQuery();
            baglanti.Close();

            for (int i=0;i<this.Controls.Count;i++)
            {
                if (Controls[i] is TextBox) Controls[i].Text="";
            } 
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            Form1 anasayfa = new Form1();
            anasayfa.Show();
            this.Visible = false; 
        }

        
        private void btnResimEkle_Click(object sender, EventArgs e)
        {

        }

        
    }
}
