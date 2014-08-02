using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kayıt_ekleeee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void ekle_Click(object sender, EventArgs e)
        {
               SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=Yordam; Integrated Security=true");
                SqlCommand cm = new SqlCommand();
                con.Open();
                cm.Connection = con;
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "kayitt_ekle";
                cm.Parameters.Add("@pogrenciID", SqlDbType.Int);
                cm.Parameters["@pogrenciID"].Value = textBox1.Text;
                cm.Parameters.Add("@pad", SqlDbType.NVarChar, 10);
                cm.Parameters["@pad"].Value = textBox12.Text;
                //            string str = "0123";

                //int a = Convert.ToInt32(str);
                cm.Parameters.Add("@psoyad", SqlDbType.NVarChar, 10);
                cm.Parameters["@psoyad"].Value = textBox11.Text;
                cm.Parameters.Add("@pdogumtarih", SqlDbType.Date);
                cm.Parameters["@pdogumtarih"].Value = textBox10.Text;
                cm.Parameters.Add("@padres", SqlDbType.NVarChar, 20);
                cm.Parameters["@padres"].Value = textBox9.Text;
                cm.Parameters.Add("@ptelefon", SqlDbType.Int);
                cm.Parameters["@ptelefon"].Value = textBox16.Text;
                cm.Parameters.Add("@pbolumID", SqlDbType.Int);
                cm.Parameters["@pbolumID"].Value = textBox15.Text;
                cm.Parameters.Add("@pvize_notu", SqlDbType.Int);
                cm.Parameters["@pvize_notu"].Value = textBox14.Text;
                cm.Parameters.Add("@pfinal_notu", SqlDbType.Int);
                cm.Parameters["@pfinal_notu"].Value = textBox13.Text;
                cm.ExecuteNonQuery();
                //if (cm.ExecuteNonQuery() != 1)
                //{
                //    MessageBox.Show("eklendi");
                //}
                con.Close();
            
           
        }
        public void Listele() 
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=Yordam; Integrated Security=true");
            SqlCommand cm = new SqlCommand();
            cm.Connection = con;
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "Kisi_Listelee";
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
