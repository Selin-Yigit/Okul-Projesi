namespace OkulProjesi
{
    partial class FrmOgretmen
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
            this.btnDersIslemleri = new System.Windows.Forms.Button();
            this.btnKlupIslemleri = new System.Windows.Forms.Button();
            this.btnSinavNotlari = new System.Windows.Forms.Button();
            this.btnOgretmenler = new System.Windows.Forms.Button();
            this.btnOgrenciIslemleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDersIslemleri
            // 
            this.btnDersIslemleri.BackColor = System.Drawing.Color.IndianRed;
            this.btnDersIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDersIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersIslemleri.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDersIslemleri.Location = new System.Drawing.Point(51, 27);
            this.btnDersIslemleri.Name = "btnDersIslemleri";
            this.btnDersIslemleri.Size = new System.Drawing.Size(139, 41);
            this.btnDersIslemleri.TabIndex = 0;
            this.btnDersIslemleri.Text = "Ders İşlemleri";
            this.btnDersIslemleri.UseVisualStyleBackColor = false;
            this.btnDersIslemleri.Click += new System.EventHandler(this.btnDersIslemleri_Click);
            // 
            // btnKlupIslemleri
            // 
            this.btnKlupIslemleri.BackColor = System.Drawing.Color.IndianRed;
            this.btnKlupIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKlupIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKlupIslemleri.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKlupIslemleri.Location = new System.Drawing.Point(51, 96);
            this.btnKlupIslemleri.Name = "btnKlupIslemleri";
            this.btnKlupIslemleri.Size = new System.Drawing.Size(139, 41);
            this.btnKlupIslemleri.TabIndex = 1;
            this.btnKlupIslemleri.Text = "Klüp İşlemleri";
            this.btnKlupIslemleri.UseVisualStyleBackColor = false;
            this.btnKlupIslemleri.Click += new System.EventHandler(this.btnKlupIslemleri_Click);
            // 
            // btnSinavNotlari
            // 
            this.btnSinavNotlari.BackColor = System.Drawing.Color.IndianRed;
            this.btnSinavNotlari.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSinavNotlari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSinavNotlari.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSinavNotlari.Location = new System.Drawing.Point(51, 169);
            this.btnSinavNotlari.Name = "btnSinavNotlari";
            this.btnSinavNotlari.Size = new System.Drawing.Size(139, 41);
            this.btnSinavNotlari.TabIndex = 2;
            this.btnSinavNotlari.Text = "Sınav Notları";
            this.btnSinavNotlari.UseVisualStyleBackColor = false;
            this.btnSinavNotlari.Click += new System.EventHandler(this.btnSinavNotlari_Click);
            // 
            // btnOgretmenler
            // 
            this.btnOgretmenler.BackColor = System.Drawing.Color.IndianRed;
            this.btnOgretmenler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOgretmenler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgretmenler.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOgretmenler.Location = new System.Drawing.Point(51, 242);
            this.btnOgretmenler.Name = "btnOgretmenler";
            this.btnOgretmenler.Size = new System.Drawing.Size(139, 41);
            this.btnOgretmenler.TabIndex = 3;
            this.btnOgretmenler.Text = "Öğretmenler";
            this.btnOgretmenler.UseVisualStyleBackColor = false;
            // 
            // btnOgrenciIslemleri
            // 
            this.btnOgrenciIslemleri.BackColor = System.Drawing.Color.IndianRed;
            this.btnOgrenciIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOgrenciIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciIslemleri.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOgrenciIslemleri.Location = new System.Drawing.Point(51, 314);
            this.btnOgrenciIslemleri.Name = "btnOgrenciIslemleri";
            this.btnOgrenciIslemleri.Size = new System.Drawing.Size(139, 41);
            this.btnOgrenciIslemleri.TabIndex = 4;
            this.btnOgrenciIslemleri.Text = "Öğrenci İşlemleri";
            this.btnOgrenciIslemleri.UseVisualStyleBackColor = false;
            this.btnOgrenciIslemleri.Click += new System.EventHandler(this.btnOgrenciIslemleri_Click);
            // 
            // FrmOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(239, 400);
            this.Controls.Add(this.btnOgrenciIslemleri);
            this.Controls.Add(this.btnOgretmenler);
            this.Controls.Add(this.btnSinavNotlari);
            this.Controls.Add(this.btnKlupIslemleri);
            this.Controls.Add(this.btnDersIslemleri);
            this.Name = "FrmOgretmen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOgretmen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDersIslemleri;
        private System.Windows.Forms.Button btnKlupIslemleri;
        private System.Windows.Forms.Button btnSinavNotlari;
        private System.Windows.Forms.Button btnOgretmenler;
        private System.Windows.Forms.Button btnOgrenciIslemleri;
    }
}