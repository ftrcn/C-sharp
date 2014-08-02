using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace basit_hesap_makinesi
{
    public partial class Form1 : Form
    {
        double sayi1, sayi2;
        string islec;
        string s;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //1 butonu
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            islec = "+";
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            islec= "-";
            sayi1= Convert.ToDouble(textBox1.Text);
            textBox1.Text =" ";

        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            islec= "*";
            textBox1.Text = " ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sayi1 = 0;
            sayi2= 0;
            islec= "";
            textBox1.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            islec= "/";
            textBox1.Text = " ";
        }

        private void button17_Click(object sender, EventArgs e)
        {

            sayi2 = Convert.ToDouble(textBox1.Text);
            //textBox1.Text=textBox1.Text.Replace(islec, sayi2.ToString());
            //string[] d= textBox1.Text.Split(',');

            if (islec== "+")
            {

                textBox1.Text = Convert.ToString(sayi1 + sayi2);
            }
            if (islec== "-")
            {
                textBox1.Text = Convert.ToString(sayi1- sayi2);
            }
            if (islec== "*")
            {
                textBox1.Text = Convert.ToString(sayi1 * sayi2);
            }
            if (islec == "/")
            {
                textBox1.Text = Convert.ToString(sayi1 / sayi2);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text.Trim() == "")
            {
                textBox1.Text = "0,";
            }
            else
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }
 
    }
}
