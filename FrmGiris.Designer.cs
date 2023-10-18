namespace OkulProjesi
{
    partial class FrmGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            this.pcbOgrenci = new System.Windows.Forms.PictureBox();
            this.pcbOgretmen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOgrenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOgretmen)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbOgrenci
            // 
            this.pcbOgrenci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbOgrenci.Image = ((System.Drawing.Image)(resources.GetObject("pcbOgrenci.Image")));
            this.pcbOgrenci.Location = new System.Drawing.Point(55, 70);
            this.pcbOgrenci.Name = "pcbOgrenci";
            this.pcbOgrenci.Size = new System.Drawing.Size(127, 115);
            this.pcbOgrenci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbOgrenci.TabIndex = 0;
            this.pcbOgrenci.TabStop = false;
            this.pcbOgrenci.Click += new System.EventHandler(this.pcbOgrenci_Click);
            // 
            // pcbOgretmen
            // 
            this.pcbOgretmen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbOgretmen.Image = ((System.Drawing.Image)(resources.GetObject("pcbOgretmen.Image")));
            this.pcbOgretmen.Location = new System.Drawing.Point(265, 70);
            this.pcbOgretmen.Name = "pcbOgretmen";
            this.pcbOgretmen.Size = new System.Drawing.Size(127, 115);
            this.pcbOgretmen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbOgretmen.TabIndex = 1;
            this.pcbOgretmen.TabStop = false;
            this.pcbOgretmen.Click += new System.EventHandler(this.pcbOgretmen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(80, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(286, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğretmen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(52, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numara: ";
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(116, 242);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(276, 20);
            this.txtNumara.TabIndex = 5;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(446, 317);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbOgretmen);
            this.Controls.Add(this.pcbOgrenci);
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pcbOgrenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOgretmen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbOgrenci;
        private System.Windows.Forms.PictureBox pcbOgretmen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumara;
    }
}

