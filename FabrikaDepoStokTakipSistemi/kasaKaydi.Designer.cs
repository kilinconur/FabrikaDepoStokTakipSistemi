namespace FabrikaStokTakipSistemi
{
    partial class kasaKaydi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maliyetLabel = new System.Windows.Forms.Label();
            this.urunSayisi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alınan Toplam Ürün Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toplam Maliyet:";
            // 
            // maliyetLabel
            // 
            this.maliyetLabel.AutoSize = true;
            this.maliyetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maliyetLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.maliyetLabel.Location = new System.Drawing.Point(340, 58);
            this.maliyetLabel.Name = "maliyetLabel";
            this.maliyetLabel.Size = new System.Drawing.Size(32, 25);
            this.maliyetLabel.TabIndex = 3;
            this.maliyetLabel.Text = " 0";
            // 
            // urunSayisi
            // 
            this.urunSayisi.AutoSize = true;
            this.urunSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urunSayisi.ForeColor = System.Drawing.Color.Red;
            this.urunSayisi.Location = new System.Drawing.Point(340, 20);
            this.urunSayisi.Name = "urunSayisi";
            this.urunSayisi.Size = new System.Drawing.Size(32, 25);
            this.urunSayisi.TabIndex = 2;
            this.urunSayisi.Text = " 0";
            // 
            // kasaKaydi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 125);
            this.Controls.Add(this.maliyetLabel);
            this.Controls.Add(this.urunSayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "kasaKaydi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Bilgisi";
            this.Load += new System.EventHandler(this.kasaKaydi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label maliyetLabel;
        private System.Windows.Forms.Label urunSayisi;
    }
}