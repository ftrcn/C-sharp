namespace denemesifre
{
    partial class frm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm1));
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.lblSifreGir = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(47, 122);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 32);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCıkıs.Location = new System.Drawing.Point(137, 122);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(75, 32);
            this.btnCıkıs.TabIndex = 1;
            this.btnCıkıs.Text = "Çıkış";
            this.btnCıkıs.UseVisualStyleBackColor = true;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // lblSifreGir
            // 
            this.lblSifreGir.AutoSize = true;
            this.lblSifreGir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifreGir.Location = new System.Drawing.Point(88, 42);
            this.lblSifreGir.Name = "lblSifreGir";
            this.lblSifreGir.Size = new System.Drawing.Size(81, 17);
            this.lblSifreGir.TabIndex = 2;
            this.lblSifreGir.Text = "Sifre Giriniz";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 3;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSifreGir);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.btnGiris);
            this.Name = "frm1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.Label lblSifreGir;
        private System.Windows.Forms.TextBox textBox1;
    }
}

