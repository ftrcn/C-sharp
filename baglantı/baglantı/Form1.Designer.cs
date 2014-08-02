namespace baglantı
{
    partial class Form1
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
            this.btnAc = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAc
            // 
            this.btnAc.Location = new System.Drawing.Point(45, 47);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(114, 46);
            this.btnAc.TabIndex = 0;
            this.btnAc.Text = "Bağlantı Aç";
            this.btnAc.UseVisualStyleBackColor = true;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click_1);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(234, 47);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(114, 46);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "Bağlantı Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(427, 262);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnAc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.Button btnKapat;
    }
}

