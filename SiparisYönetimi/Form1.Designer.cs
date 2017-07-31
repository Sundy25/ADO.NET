namespace SiparisYönetimi
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
            this.cmbPersoneller = new System.Windows.Forms.ComboBox();
            this.btnSiparisleriGetir = new System.Windows.Forms.Button();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSiparisTarihi = new System.Windows.Forms.Label();
            this.lblTeslimTarihi = new System.Windows.Forms.Label();
            this.lblKargoUcreti = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSiparisDetayGetir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbPersoneller
            // 
            this.cmbPersoneller.FormattingEnabled = true;
            this.cmbPersoneller.Location = new System.Drawing.Point(25, 38);
            this.cmbPersoneller.Name = "cmbPersoneller";
            this.cmbPersoneller.Size = new System.Drawing.Size(192, 21);
            this.cmbPersoneller.TabIndex = 0;
            // 
            // btnSiparisleriGetir
            // 
            this.btnSiparisleriGetir.Location = new System.Drawing.Point(25, 66);
            this.btnSiparisleriGetir.Name = "btnSiparisleriGetir";
            this.btnSiparisleriGetir.Size = new System.Drawing.Size(192, 23);
            this.btnSiparisleriGetir.TabIndex = 1;
            this.btnSiparisleriGetir.Text = "Siparişleri Getir";
            this.btnSiparisleriGetir.UseVisualStyleBackColor = true;
            this.btnSiparisleriGetir.Click += new System.EventHandler(this.btnSiparisleriGetir_Click);
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.Location = new System.Drawing.Point(25, 115);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(192, 238);
            this.lstSiparisler.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lütfen Bir Sİpariş Seçniz";
            // 
            // lblSiparisTarihi
            // 
            this.lblSiparisTarihi.AutoSize = true;
            this.lblSiparisTarihi.Location = new System.Drawing.Point(254, 273);
            this.lblSiparisTarihi.Name = "lblSiparisTarihi";
            this.lblSiparisTarihi.Size = new System.Drawing.Size(76, 13);
            this.lblSiparisTarihi.TabIndex = 3;
            this.lblSiparisTarihi.Text = "lblSiparisDetay";
            // 
            // lblTeslimTarihi
            // 
            this.lblTeslimTarihi.AutoSize = true;
            this.lblTeslimTarihi.Location = new System.Drawing.Point(254, 304);
            this.lblTeslimTarihi.Name = "lblTeslimTarihi";
            this.lblTeslimTarihi.Size = new System.Drawing.Size(73, 13);
            this.lblTeslimTarihi.TabIndex = 3;
            this.lblTeslimTarihi.Text = "lblTeslimTarihi";
            // 
            // lblKargoUcreti
            // 
            this.lblKargoUcreti.AutoSize = true;
            this.lblKargoUcreti.Location = new System.Drawing.Point(254, 331);
            this.lblKargoUcreti.Name = "lblKargoUcreti";
            this.lblKargoUcreti.Size = new System.Drawing.Size(73, 13);
            this.lblKargoUcreti.TabIndex = 3;
            this.lblKargoUcreti.Text = "lblKargoÜcreti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bir Personel Seçiniz";
            // 
            // btnSiparisDetayGetir
            // 
            this.btnSiparisDetayGetir.Location = new System.Drawing.Point(25, 359);
            this.btnSiparisDetayGetir.Name = "btnSiparisDetayGetir";
            this.btnSiparisDetayGetir.Size = new System.Drawing.Size(192, 23);
            this.btnSiparisDetayGetir.TabIndex = 1;
            this.btnSiparisDetayGetir.Text = "Siparişlerin Detaylarını Getir";
            this.btnSiparisDetayGetir.UseVisualStyleBackColor = true;
            this.btnSiparisDetayGetir.Click += new System.EventHandler(this.btnSiparisDetayGetir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 394);
            this.Controls.Add(this.lblKargoUcreti);
            this.Controls.Add(this.lblTeslimTarihi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSiparisTarihi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.btnSiparisDetayGetir);
            this.Controls.Add(this.btnSiparisleriGetir);
            this.Controls.Add(this.cmbPersoneller);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPersoneller;
        private System.Windows.Forms.Button btnSiparisleriGetir;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSiparisTarihi;
        private System.Windows.Forms.Label lblTeslimTarihi;
        private System.Windows.Forms.Label lblKargoUcreti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSiparisDetayGetir;
    }
}

