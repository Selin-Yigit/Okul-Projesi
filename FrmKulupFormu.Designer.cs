namespace OkulProjesi
{
    partial class FrmKulupFormu
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
            this.dgvKulup = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKulupId = new System.Windows.Forms.TextBox();
            this.txtKulupAd = new System.Windows.Forms.TextBox();
            this.btnKListele = new System.Windows.Forms.Button();
            this.btnKEkle = new System.Windows.Forms.Button();
            this.btnKGuncelle = new System.Windows.Forms.Button();
            this.btnKSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKulup)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kulüp İşlemleri Formu";
            // 
            // dgvKulup
            // 
            this.dgvKulup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKulup.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKulup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKulup.Location = new System.Drawing.Point(33, 70);
            this.dgvKulup.Name = "dgvKulup";
            this.dgvKulup.Size = new System.Drawing.Size(539, 194);
            this.dgvKulup.TabIndex = 1;
            this.dgvKulup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKulup_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(97, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kulüp Id: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(97, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kulüp Adı: ";
            // 
            // txtKulupId
            // 
            this.txtKulupId.Enabled = false;
            this.txtKulupId.Location = new System.Drawing.Point(172, 280);
            this.txtKulupId.Name = "txtKulupId";
            this.txtKulupId.Size = new System.Drawing.Size(324, 20);
            this.txtKulupId.TabIndex = 4;
            // 
            // txtKulupAd
            // 
            this.txtKulupAd.Location = new System.Drawing.Point(172, 306);
            this.txtKulupAd.Name = "txtKulupAd";
            this.txtKulupAd.Size = new System.Drawing.Size(324, 20);
            this.txtKulupAd.TabIndex = 5;
            // 
            // btnKListele
            // 
            this.btnKListele.BackColor = System.Drawing.Color.IndianRed;
            this.btnKListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKListele.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKListele.Location = new System.Drawing.Point(33, 373);
            this.btnKListele.Name = "btnKListele";
            this.btnKListele.Size = new System.Drawing.Size(117, 40);
            this.btnKListele.TabIndex = 6;
            this.btnKListele.Text = "Listele";
            this.btnKListele.UseVisualStyleBackColor = false;
            this.btnKListele.Click += new System.EventHandler(this.btnKListele_Click);
            // 
            // btnKEkle
            // 
            this.btnKEkle.BackColor = System.Drawing.Color.IndianRed;
            this.btnKEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKEkle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKEkle.Location = new System.Drawing.Point(172, 373);
            this.btnKEkle.Name = "btnKEkle";
            this.btnKEkle.Size = new System.Drawing.Size(117, 40);
            this.btnKEkle.TabIndex = 7;
            this.btnKEkle.Text = "Ekle";
            this.btnKEkle.UseVisualStyleBackColor = false;
            this.btnKEkle.Click += new System.EventHandler(this.btnKEkle_Click);
            // 
            // btnKGuncelle
            // 
            this.btnKGuncelle.BackColor = System.Drawing.Color.IndianRed;
            this.btnKGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKGuncelle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKGuncelle.Location = new System.Drawing.Point(312, 373);
            this.btnKGuncelle.Name = "btnKGuncelle";
            this.btnKGuncelle.Size = new System.Drawing.Size(117, 40);
            this.btnKGuncelle.TabIndex = 8;
            this.btnKGuncelle.Text = "Güncelle";
            this.btnKGuncelle.UseVisualStyleBackColor = false;
            this.btnKGuncelle.Click += new System.EventHandler(this.btnKGuncelle_Click);
            // 
            // btnKSil
            // 
            this.btnKSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnKSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKSil.ForeColor = System.Drawing.SystemColors.Control;
            this.btnKSil.Location = new System.Drawing.Point(455, 373);
            this.btnKSil.Name = "btnKSil";
            this.btnKSil.Size = new System.Drawing.Size(117, 40);
            this.btnKSil.TabIndex = 9;
            this.btnKSil.Text = "Sil";
            this.btnKSil.UseVisualStyleBackColor = false;
            this.btnKSil.Click += new System.EventHandler(this.btnKSil_Click);
            // 
            // FrmKulupFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.btnKSil);
            this.Controls.Add(this.btnKGuncelle);
            this.Controls.Add(this.btnKEkle);
            this.Controls.Add(this.btnKListele);
            this.Controls.Add(this.txtKulupAd);
            this.Controls.Add(this.txtKulupId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvKulup);
            this.Controls.Add(this.label1);
            this.Name = "FrmKulupFormu";
            this.Text = "FrmKlupFormu";
            this.Load += new System.EventHandler(this.FrmKlupFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKulup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKulup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKulupId;
        private System.Windows.Forms.TextBox txtKulupAd;
        private System.Windows.Forms.Button btnKListele;
        private System.Windows.Forms.Button btnKEkle;
        private System.Windows.Forms.Button btnKGuncelle;
        private System.Windows.Forms.Button btnKSil;
    }
}