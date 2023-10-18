namespace OkulProjesi
{
    partial class FrmDersler
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
            this.btnDSil = new System.Windows.Forms.Button();
            this.btnDGuncelle = new System.Windows.Forms.Button();
            this.btnDEkle = new System.Windows.Forms.Button();
            this.btnDListele = new System.Windows.Forms.Button();
            this.txtDersAd = new System.Windows.Forms.TextBox();
            this.txtDersId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDSil
            // 
            this.btnDSil.BackColor = System.Drawing.Color.IndianRed;
            this.btnDSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDSil.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDSil.Location = new System.Drawing.Point(463, 377);
            this.btnDSil.Name = "btnDSil";
            this.btnDSil.Size = new System.Drawing.Size(117, 40);
            this.btnDSil.TabIndex = 19;
            this.btnDSil.Text = "Sil";
            this.btnDSil.UseVisualStyleBackColor = false;
            this.btnDSil.Click += new System.EventHandler(this.btnDSil_Click);
            // 
            // btnDGuncelle
            // 
            this.btnDGuncelle.BackColor = System.Drawing.Color.IndianRed;
            this.btnDGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDGuncelle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDGuncelle.Location = new System.Drawing.Point(320, 377);
            this.btnDGuncelle.Name = "btnDGuncelle";
            this.btnDGuncelle.Size = new System.Drawing.Size(117, 40);
            this.btnDGuncelle.TabIndex = 18;
            this.btnDGuncelle.Text = "Güncelle";
            this.btnDGuncelle.UseVisualStyleBackColor = false;
            this.btnDGuncelle.Click += new System.EventHandler(this.btnDGuncelle_Click);
            // 
            // btnDEkle
            // 
            this.btnDEkle.BackColor = System.Drawing.Color.IndianRed;
            this.btnDEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDEkle.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDEkle.Location = new System.Drawing.Point(180, 377);
            this.btnDEkle.Name = "btnDEkle";
            this.btnDEkle.Size = new System.Drawing.Size(117, 40);
            this.btnDEkle.TabIndex = 17;
            this.btnDEkle.Text = "Ekle";
            this.btnDEkle.UseVisualStyleBackColor = false;
            this.btnDEkle.Click += new System.EventHandler(this.btnDEkle_Click);
            // 
            // btnDListele
            // 
            this.btnDListele.BackColor = System.Drawing.Color.IndianRed;
            this.btnDListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDListele.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDListele.Location = new System.Drawing.Point(41, 377);
            this.btnDListele.Name = "btnDListele";
            this.btnDListele.Size = new System.Drawing.Size(117, 40);
            this.btnDListele.TabIndex = 16;
            this.btnDListele.Text = "Listele";
            this.btnDListele.UseVisualStyleBackColor = false;
            this.btnDListele.Click += new System.EventHandler(this.btnDListele_Click);
            // 
            // txtDersAd
            // 
            this.txtDersAd.Location = new System.Drawing.Point(180, 310);
            this.txtDersAd.Name = "txtDersAd";
            this.txtDersAd.Size = new System.Drawing.Size(324, 20);
            this.txtDersAd.TabIndex = 15;
            // 
            // txtDersId
            // 
            this.txtDersId.Enabled = false;
            this.txtDersId.Location = new System.Drawing.Point(180, 284);
            this.txtDersId.Name = "txtDersId";
            this.txtDersId.Size = new System.Drawing.Size(324, 20);
            this.txtDersId.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(105, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ders Adı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(105, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ders Id: ";
            // 
            // dgvDers
            // 
            this.dgvDers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDers.Location = new System.Drawing.Point(41, 74);
            this.dgvDers.Name = "dgvDers";
            this.dgvDers.Size = new System.Drawing.Size(539, 194);
            this.dgvDers.TabIndex = 11;
            this.dgvDers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDers_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ders İşlemleri Formu";
            // 
            // FrmDersler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.btnDSil);
            this.Controls.Add(this.btnDGuncelle);
            this.Controls.Add(this.btnDEkle);
            this.Controls.Add(this.btnDListele);
            this.Controls.Add(this.txtDersAd);
            this.Controls.Add(this.txtDersId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDers);
            this.Controls.Add(this.label1);
            this.Name = "FrmDersler";
            this.Text = "FrmDErsler";
            this.Load += new System.EventHandler(this.FrmDersler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDSil;
        private System.Windows.Forms.Button btnDGuncelle;
        private System.Windows.Forms.Button btnDEkle;
        private System.Windows.Forms.Button btnDListele;
        private System.Windows.Forms.TextBox txtDersAd;
        private System.Windows.Forms.TextBox txtDersId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDers;
        private System.Windows.Forms.Label label1;
    }
}