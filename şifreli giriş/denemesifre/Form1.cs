    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    namespace denemesifre
    {
    public partial class frm1 : Form
    {
        public frm2 frm2;
        public frm1()
        {
            InitializeComponent();
            frm2 = new frm2();
            frm2.frm= this;
         } 

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frm1_Load(object sender, EventArgs e)
        {
        }

        

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(textBox1.Text)) == 123)
            {

                frm2.Show();
                this.Hide();

                //frm2 bagla = new frm2();
                //bagla.Show();
            }

            else
            {

                MessageBox.Show("Yanlış Şifre ");

            }
        }

        

        
    }
    }