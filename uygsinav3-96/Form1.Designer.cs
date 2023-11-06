namespace uygsinav3_96
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
            this.btnRastgele = new System.Windows.Forms.Button();
            this.lblSayilar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRastgele
            // 
            this.btnRastgele.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRastgele.Location = new System.Drawing.Point(29, 40);
            this.btnRastgele.Name = "btnRastgele";
            this.btnRastgele.Size = new System.Drawing.Size(177, 47);
            this.btnRastgele.TabIndex = 0;
            this.btnRastgele.Text = "Rastgele Sayı";
            this.btnRastgele.UseVisualStyleBackColor = true;
            this.btnRastgele.Click += new System.EventHandler(this.btnRastgele_Click);
            // 
            // lblSayilar
            // 
            this.lblSayilar.AutoSize = true;
            this.lblSayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayilar.Location = new System.Drawing.Point(95, 129);
            this.lblSayilar.Name = "lblSayilar";
            this.lblSayilar.Size = new System.Drawing.Size(50, 31);
            this.lblSayilar.TabIndex = 1;
            this.lblSayilar.Text = "***";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(243, 214);
            this.Controls.Add(this.lblSayilar);
            this.Controls.Add(this.btnRastgele);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRastgele;
        private System.Windows.Forms.Label lblSayilar;
    }
}

