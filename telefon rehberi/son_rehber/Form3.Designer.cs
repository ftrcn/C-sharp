namespace son_rehber
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncıkıs = new System.Windows.Forms.Button();
            this.lblbolum = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblad = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbltel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblmail = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncıkıs
            // 
            this.btncıkıs.Location = new System.Drawing.Point(259, 271);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(75, 23);
            this.btncıkıs.TabIndex = 31;
            this.btncıkıs.Text = "Geri Dön";
            this.btncıkıs.UseVisualStyleBackColor = true;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // lblbolum
            // 
            this.lblbolum.AutoSize = true;
            this.lblbolum.Location = new System.Drawing.Point(91, 110);
            this.lblbolum.Name = "lblbolum";
            this.lblbolum.Size = new System.Drawing.Size(39, 13);
            this.lblbolum.TabIndex = 22;
            this.lblbolum.Text = "Bölüm:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(158, 271);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 30;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Location = new System.Drawing.Point(91, 135);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(56, 13);
            this.lblad.TabIndex = 23;
            this.lblad.Text = "Ad Soyad:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(182, 193);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(127, 20);
            this.textBox4.TabIndex = 29;
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.Location = new System.Drawing.Point(91, 167);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(46, 13);
            this.lbltel.TabIndex = 24;
            this.lbltel.Text = "Telefon:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(182, 167);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(127, 20);
            this.textBox3.TabIndex = 28;
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Location = new System.Drawing.Point(91, 193);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(39, 13);
            this.lblmail.TabIndex = 25;
            this.lblmail.Text = "E-Mail:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(182, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 20);
            this.textBox2.TabIndex = 27;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 20);
            this.textBox1.TabIndex = 26;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(182, 219);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(127, 20);
            this.textBox5.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Meslek:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 466);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncıkıs);
            this.Controls.Add(this.lblbolum);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblmail);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncıkıs;
        private System.Windows.Forms.Label lblbolum;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
    }
}