using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aaaa
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog rs = new OpenFileDialog();
            rs.Filter = " Resim Dosyaları |*.jpg| Bütün Dosyalar|*.*";
            rs.Title = "1yada0.com";
            rs.ShowDialog();
            pictureBox1.ImageLocation = rs.FileName.ToString();
        }
    }
}
