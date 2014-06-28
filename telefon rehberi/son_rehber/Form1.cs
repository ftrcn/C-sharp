using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;

namespace son_rehber
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da, da1;
        DataSet ds, ds1;
        public static string yol;

        public Form1()
        {
            InitializeComponent();
        }
 
        //bağlan metodu
        private void baglan()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.ConnectionString = "Server=.;Initial Catalog=rehber;Trusted_Connection=True;";
                    con.Open();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }


        private void baglanti(string txt)
        {
            try
            {
                da1 = new SqlDataAdapter(txt, con);
                ds1 = new DataSet();
                baglan();
                da1.Fill(ds1, "kisi");
                con.Close();
                grdkisi.DataSource = ds1.Tables["kisi"];
            }
            catch
            {
            }

        }


        //Form1 Load
        private void Form1_Load(object sender, EventArgs e)
        {

            yol = "server=.;Data Source=rehber;Integrated Security= True";
            try
            {
                con = new SqlConnection(yol);
            }
            catch
            {
                MessageBox.Show("veritabanına bağlanmadı");
            }
            baglan();
            griddoldur();
            bolumdoldur();
        }

       
        private void bolumdoldur()
        {
            string txtbolum = "select * from bolum";
            da = new SqlDataAdapter(txtbolum, con);
            ds = new DataSet();
            baglan();
            da.Fill(ds, "bolum");
            con.Close();

            cmbbolum.DataSource = ds.Tables["bolum"];
            cmbbolum.DisplayMember = "bolum_ad";
            cmbbolum.ValueMember = "bolum_id";
        }

        //Gridi doldurduğumuz kısım
        private void griddoldur()
        {
            string txtkisi = "select * from kisi order by id_kisi, bolum_id";
            da1 = new SqlDataAdapter(txtkisi, con);
            ds1 = new DataSet();
            baglan();
            da1.Fill(ds1, "kisi");
            con.Close();
            grdkisi.DataSource = ds1.Tables["kisi"];
        }
        int ID;
        string dosya_yolu;
        private void grdkisi_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = e.RowIndex;

                lblid.Text = ds1.Tables["kisi"].Rows[ID]["id_kisi"].ToString();
                lblad.Text = ds1.Tables["kisi"].Rows[ID]["ad_soyad"].ToString();
               // lblbolum.Text = ds1.Tables["kisi"].Rows[ID]["bolum_id"].ToString();
                int grups=Convert.ToInt32(ds1.Tables["kisi"].Rows[ID]["bolum_id"].ToString());
                lblbolum.Text=gruplama(grups);
                lbltel.Text = ds1.Tables["kisi"].Rows[ID]["telefon"].ToString();
                lblmail.Text = ds1.Tables["kisi"].Rows[ID]["e_mail"].ToString();
                lblmeslek.Text = ds1.Tables["kisi"].Rows[ID]["meslek"].ToString();
                dosya_yolu = ds1.Tables["kisi"].Rows[ID]["resim"].ToString();
                pictureBox1.Load(dosya_yolu);
               
                //pictureBox1.Load("..\\..\\resimler\\cocuk.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public string gruplama(int grups)
        {
            string txtbolum = "select * from bolum where bolum_id="+grups;
            da=new SqlDataAdapter(txtbolum,con);
            ds = new DataSet();
            baglan();
            da.Fill(ds,"bolum");
            con.Close();

            string gruplama=ds.Tables["bolum"].Rows[0]["bolum_ad"].ToString();

            return gruplama;
        }


        // txtad_TextChanged kısmında btnara butonunun işlevi  yapılıyor.Ama diğer yolu da aşağıda btnara butonu içinde  yazdığım gibidir.
        //private void btnara_Click(object sender, EventArgs e)
        //{
        //    string arama ="select * from kisi where ad_soyad like'"+txtad.Text+"%'";
        //    baglanti(arama);
        //}

        int grupid;
        private void cmbbolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                grupid = Convert.ToInt32(cmbbolum.SelectedValue.ToString());
                string grup = "select * from kisi where bolum_id=" + grupid;
                baglanti(grup);
            }
            catch
            {
            }
         }

        private void btnTum_Click(object sender, EventArgs e)
        {
            
            string hepsi= "select * from  kisi";
            baglanti(hepsi);
            txtad.Clear();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult cevap;
                cevap = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel);
                if (cevap == DialogResult.Yes)
                {

                    int seciliID = Convert.ToInt32(grdkisi.SelectedRows[0].Cells[0].Value);
                    string sorgu = "delete from kisi where id_kisi =" + seciliID;
                    SqlCommand cmd1 = new SqlCommand(sorgu, con);
                    if (con.State == ConnectionState.Open)
                    {
                        cmd.ExecuteNonQuery();
                        con.Close();
                        griddoldur();
                    }
                    else
                    {
                        con.Open();
                        cmd1.ExecuteNonQuery();
                        con.Close();
                        griddoldur();
                    }
                    MessageBox.Show("Kaydınız başarıyla silindi.");
                }
            }
            catch
            {
                //Silme işlemi başarısızsa aşağıdaki mesaj ekrana gelecek.
                MessageBox.Show("Silme İşlemi Başarısız");
            }

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Form2 eklemeFormu = new Form2();
            eklemeFormu.Show();
            this.Visible = false; 
        }

        private void btnduzen_Click(object sender, EventArgs e)
        {
            Global.c_id = grdkisi.SelectedRows[0].Cells[0].Value.ToString();
            Form3 duzenleFormu = new Form3();
            duzenleFormu.Show();
            this.Visible = false; 
        }

        private void txtad_TextChanged(object sender, EventArgs e)
        {
            string arama = "select * from kisi where ad_soyad like'" + txtad.Text + "%'";
            baglanti(arama);
        }

        //Çıkış Butonu
        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    

       







    }
}
