using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loto_Tahmini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_tahmin_Click(object sender, EventArgs e)
        {
            int[] loto = new int[6];
            Random rnd = new Random();
            lblSonuc.Text = "";
            for (int i = 0; i < 6; i++)
            {
                loto[i] = rnd.Next(1, 50);
                lblSonuc.Text = lblSonuc.Text + loto[i].ToString() + " ";
            } 

        }
    }
}
