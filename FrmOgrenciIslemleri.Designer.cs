namespace OkulProjesi
{
    partial class FrmOgrenciIslemleri
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
            this.dgvOgrenciIslemleri = new System.Windows.Forms.DataGridView();
            this.İslemler = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOAra = new System.Windows.Forms.Button();
            this.txtOArama = new System.Windows.Forms.TextBox();
            this.btnOSil = new System.Windows.Forms.Button();
            this.btnOGuncelle = new System.Windows.Forms.Button();
            this.btnOEkle = new System.Windows.Forms.Button();
            this.btnOListele = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbErkek = new System.Windows.Forms.RadioButton();
            this.rdbKadın = new System.Windows.Forms.RadioButton();
            this.cmbOgrenciKulup = new System.Windows.Forms.ComboBox();
            this.txtOgrenciAd = new System.Windows.Forms.TextBox();
            this.txtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrenciId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciIslemleri)).BeginInit();
            this.İslemler.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOgrenciIslemleri
            // 
            this.dgvOgrenciIslemleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenciIslemleri.Location = new System.Drawing.Point(32, 64);
            this.dgvOgrenciIslemleri.Name = "dgvOgrenciIslemleri";
            this.dgvOgrenciIslemleri.Size = new System.Drawing.Size(736, 214);
            this.dgvOgrenciIslemleri.TabIndex = 0;
            this.dgvOgrenciIslemleri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOgrenciIslemleri_CellClick);
            // 
            // İslemler
            // 
            this.İslemler.Controls.Add(this.label7);
            this.İslemler.Controls.Add(this.btnOAra);
            this.İslemler.Controls.Add(this.txtOArama);
            this.İslemler.Controls.Add(this.btnOSil);
            this.İslemler.Controls.Add(this.btnOGuncelle);
            this.İslemler.Controls.Add(this.btnOEkle);
            this.İslemler.Controls.Add(this.btnOListele);
            this.İslemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İslemler.ForeColor = System.Drawing.Color.IndianRed;
            this.İslemler.Location = new System.Drawing.Point(32, 301);
            this.İslemler.Name = "İslemler";
            this.İslemler.Size = new System.Drawing.Size(405, 227);
            this.İslemler.TabIndex = 1;
            this.İslemler.TabStop = false;
            this.İslemler.Text = "İşlemler";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(48, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Öğrenci Adı: ";
            // 
            // btnOAra
            // 
            this.btnOAra.BackColor = System.Drawing.Color.IndianRed;
            this.btnOAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOAra.ForeColor = System.Drawing.Color.White;
            this.btnOAra.Location = new System.Drawing.Point(46, 168);
            this.btnOAra.Name = "btnOAra";
            this.btnOAra.Size = new System.Drawing.Size(317, 35);
            this.btnOAra.TabIndex = 23;
            this.btnOAra.Text = "Ara";
            this.btnOAra.UseVisualStyleBackColor = false;
            this.btnOAra.Click += new System.EventHandler(this.btnOAra_Click);
            // 
            // txtOArama
            // 
            this.txtOArama.Location = new System.Drawing.Point(135, 139);
            this.txtOArama.Name = "txtOArama";
            this.txtOArama.Size = new System.Drawing.Size(228, 23);
            this.txtOArama.TabIndex = 22;
            // 
            // btnOSil
            // 
            this.btnOSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnOSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOSil.ForeColor = System.Drawing.Color.White;
            this.btnOSil.Location = new System.Drawing.Point(215, 70);
            this.btnOSil.Name = "btnOSil";
            this.btnOSil.Size = new System.Drawing.Size(148, 35);
            this.btnOSil.TabIndex = 3;
            this.btnOSil.Text = "Sil";
            this.btnOSil.UseVisualStyleBackColor = false;
            this.btnOSil.Click += new System.EventHandler(this.btnOSil_Click);
            // 
            // btnOGuncelle
            // 
            this.btnOGuncelle.BackColor = System.Drawing.Color.IndianRed;
            this.btnOGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnOGuncelle.Location = new System.Drawing.Point(215, 29);
            this.btnOGuncelle.Name = "btnOGuncelle";
            this.btnOGuncelle.Size = new System.Drawing.Size(148, 35);
            this.btnOGuncelle.TabIndex = 2;
            this.btnOGuncelle.Text = "Güncelle";
            this.btnOGuncelle.UseVisualStyleBackColor = false;
            this.btnOGuncelle.Click += new System.EventHandler(this.btnOGuncelle_Click);
            // 
            // btnOEkle
            // 
            this.btnOEkle.BackColor = System.Drawing.Color.IndianRed;
            this.btnOEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOEkle.ForeColor = System.Drawing.Color.White;
            this.btnOEkle.Location = new System.Drawing.Point(46, 70);
            this.btnOEkle.Name = "btnOEkle";
            this.btnOEkle.Size = new System.Drawing.Size(148, 35);
            this.btnOEkle.TabIndex = 1;
            this.btnOEkle.Text = "Ekle";
            this.btnOEkle.UseVisualStyleBackColor = false;
            this.btnOEkle.Click += new System.EventHandler(this.btnOEkle_Click);
            // 
            // btnOListele
            // 
            this.btnOListele.BackColor = System.Drawing.Color.IndianRed;
            this.btnOListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOListele.ForeColor = System.Drawing.Color.White;
            this.btnOListele.Location = new System.Drawing.Point(46, 29);
            this.btnOListele.Name = "btnOListele";
            this.btnOListele.Size = new System.Drawing.Size(148, 35);
            this.btnOListele.TabIndex = 0;
            this.btnOListele.Text = "Listele";
            this.btnOListele.UseVisualStyleBackColor = false;
            this.btnOListele.Click += new System.EventHandler(this.btnOListele_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rdbErkek);
            this.groupBox2.Controls.Add(this.rdbKadın);
            this.groupBox2.Controls.Add(this.cmbOgrenciKulup);
            this.groupBox2.Controls.Add(this.txtOgrenciAd);
            this.groupBox2.Controls.Add(this.txtOgrenciSoyad);
            this.groupBox2.Controls.Add(this.txtOgrenciId);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox2.Location = new System.Drawing.Point(464, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 227);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Bilgileri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(18, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Cinsiyet: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(30, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Kulüp: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(27, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Soyad: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(47, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ad: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(5, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Öğrenci ID:";
            // 
            // rdbErkek
            // 
            this.rdbErkek.AutoSize = true;
            this.rdbErkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbErkek.Location = new System.Drawing.Point(197, 163);
            this.rdbErkek.Name = "rdbErkek";
            this.rdbErkek.Size = new System.Drawing.Size(58, 17);
            this.rdbErkek.TabIndex = 16;
            this.rdbErkek.TabStop = true;
            this.rdbErkek.Text = "Erkek";
            this.rdbErkek.UseVisualStyleBackColor = true;
            // 
            // rdbKadın
            // 
            this.rdbKadın.AutoSize = true;
            this.rdbKadın.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbKadın.Location = new System.Drawing.Point(117, 163);
            this.rdbKadın.Name = "rdbKadın";
            this.rdbKadın.Size = new System.Drawing.Size(57, 17);
            this.rdbKadın.TabIndex = 15;
            this.rdbKadın.TabStop = true;
            this.rdbKadın.Text = "Kadın";
            this.rdbKadın.UseVisualStyleBackColor = true;
            // 
            // cmbOgrenciKulup
            // 
            this.cmbOgrenciKulup.FormattingEnabled = true;
            this.cmbOgrenciKulup.Location = new System.Drawing.Point(83, 128);
            this.cmbOgrenciKulup.Name = "cmbOgrenciKulup";
            this.cmbOgrenciKulup.Size = new System.Drawing.Size(202, 24);
            this.cmbOgrenciKulup.TabIndex = 14;
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.Location = new System.Drawing.Point(83, 76);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(202, 23);
            this.txtOgrenciAd.TabIndex = 13;
            // 
            // txtOgrenciSoyad
            // 
            this.txtOgrenciSoyad.Location = new System.Drawing.Point(83, 102);
            this.txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            this.txtOgrenciSoyad.Size = new System.Drawing.Size(202, 23);
            this.txtOgrenciSoyad.TabIndex = 12;
            // 
            // txtOgrenciId
            // 
            this.txtOgrenciId.Enabled = false;
            this.txtOgrenciId.Location = new System.Drawing.Point(83, 50);
            this.txtOgrenciId.Name = "txtOgrenciId";
            this.txtOgrenciId.Size = new System.Drawing.Size(202, 23);
            this.txtOgrenciId.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(27, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Öğrenci İşlemleri Paneli";
            // 
            // FrmOgrenciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.İslemler);
            this.Controls.Add(this.dgvOgrenciIslemleri);
            this.Name = "FrmOgrenciIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOgrenciIslemleri";
            this.Load += new System.EventHandler(this.FrmOgrenciIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciIslemleri)).EndInit();
            this.İslemler.ResumeLayout(false);
            this.İslemler.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOgrenciIslemleri;
        private System.Windows.Forms.GroupBox İslemler;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOSil;
        private System.Windows.Forms.Button btnOGuncelle;
        private System.Windows.Forms.Button btnOEkle;
        private System.Windows.Forms.Button btnOListele;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOAra;
        private System.Windows.Forms.TextBox txtOArama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbErkek;
        private System.Windows.Forms.RadioButton rdbKadın;
        private System.Windows.Forms.ComboBox cmbOgrenciKulup;
        private System.Windows.Forms.TextBox txtOgrenciAd;
        private System.Windows.Forms.TextBox txtOgrenciSoyad;
        private System.Windows.Forms.TextBox txtOgrenciId;
        private System.Windows.Forms.Label label7;
    }
}