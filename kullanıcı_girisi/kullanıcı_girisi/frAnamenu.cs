using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kullanıcı_girisi
{
    public partial class frAnamenu : Form
    {
        public frAnamenu()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void girişEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frgirisekrani frgirisekrani = new frgirisekrani();
            frgirisekrani.Visible = true;
            this.Close();
        }

        private void frAnamenu_Load(object sender, EventArgs e)
        {
            this.Text = "Ana Menu";
            //Global classAdi = new Global();
            //string kadi=frgirisekrani.
            Global classAdi = new Global();
            string kadi = frgirisekrani._kullanici;
            string seviye = frgirisekrani._seviye;
            //string  kadi = frgirisekrani._kullanici;
            //string seviye = frgirisekrani._seviye.ToString();
            stattext.Text = "kullanici: " + kadi + " Seviye: " + seviye;

        }
    }
}
