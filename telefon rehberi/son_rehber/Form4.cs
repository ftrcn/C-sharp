using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace son_rehber
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        //Anasayfa yani ilk görmek isteğimiz formu görmek için program.cs sayfasından Application.Run(new Form4()); kısmına istediğimiz form ismini yazmamız yeterli.
        private void button1_Click(object sender, EventArgs e)
        {
            string kullanici_adi=textBox1.Text;
            string sifre = textBox2.Text;
          

            if ((textBox1.Text == "") && (textBox2.Text == ""))
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre Girmediniz");
            }

            //şifre gözükmemesi için textBox2.Text'nin özelliklerinden PassWordChar kısmına * koymak yeterli.
            else if (kullanici_adi=="fatma" &  sifre=="1234")
            {                                
                Form1 anasayfa = new Form1();
                anasayfa.Show();
                this.Visible = false;
            }

            else if (kullanici_adi != "fatma" || sifre != "1234")
            {
                MessageBox.Show("Kullanıcı adı veya şifreyi yanlış girdiniz.Lütfen tekrar deneyiniz.");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
