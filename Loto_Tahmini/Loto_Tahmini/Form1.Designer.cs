namespace Loto_Tahmini
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
            this.btn_tahmin = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_tahmin
            // 
            this.btn_tahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tahmin.Location = new System.Drawing.Point(90, 63);
            this.btn_tahmin.Name = "btn_tahmin";
            this.btn_tahmin.Size = new System.Drawing.Size(109, 31);
            this.btn_tahmin.TabIndex = 0;
            this.btn_tahmin.Text = "Tahmin Et";
            this.btn_tahmin.UseVisualStyleBackColor = true;
            this.btn_tahmin.Click += new System.EventHandler(this.btn_tahmin_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSonuc.Location = new System.Drawing.Point(87, 116);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(48, 17);
            this.lblSonuc.TabIndex = 1;
            this.lblSonuc.Text = "Sonuç";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btn_tahmin);
            this.Name = "Form1";
            this.Text = "LOTO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tahmin;
        private System.Windows.Forms.Label lblSonuc;
    }
}

