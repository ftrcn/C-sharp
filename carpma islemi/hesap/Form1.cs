﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hesap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = (Convert.ToInt32(textBox2.Text)) * (Convert.ToInt32(textBox1.Text));
            label3.Text =sayi.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
