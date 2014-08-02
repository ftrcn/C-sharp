using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace baglantı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        SqlConnection myCon = new SqlConnection(@"Data Source= .; Initial Catalog=deneme_database;Integrated Security= True");


        private void btnAc_Click_1(object sender, EventArgs e)
        {

            myCon.Open();

            if (myCon.State == ConnectionState.Open)

                MessageBox.Show("bağlantı açıldı");
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            myCon.Close();

            if (myCon.State == ConnectionState.Closed)

                MessageBox.Show("Bağlantı sonlandırıldı");

        }

       

    }

}

