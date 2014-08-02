using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataLayer;
using Entities;

namespace Katmanli_Mimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CategoryService catService = new CategoryService();
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryId";
            comboBox1.DataSource=catService.kategorileriGetir();

            SupplierService supService = new SupplierService();
            comboBox2.DisplayMember = "CompanyName";
            comboBox2.ValueMember = "SupplierId";
            comboBox2.DataSource = supService.TedarikcileriGetir();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductService srvc = new ProductService();
            Urun urn = new Urun()
            {
                CategoryID=int.Parse(comboBox1.SelectedValue.ToString()),
                SupplierId=int.Parse(comboBox2.SelectedValue.ToString()),
                ProductName=textBox1.Text
            };
            MessageBox.Show(srvc.UrunEkle(urn) ? "Ürün başarıyla eklendi" : "Ürün ekleme başarısız");
            textBox1.Text = "";
         
        }
    }
}
