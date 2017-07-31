namespace KuzeyYonetim
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
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.cbSatistaMi = new System.Windows.Forms.CheckBox();
            this.numFiyat = new System.Windows.Forms.NumericUpDown();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKategoriSil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYeniUrunAdi = new System.Windows.Forms.TextBox();
            this.cbYeniSatistaMi = new System.Windows.Forms.CheckBox();
            this.numYeniUrunFiyati = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnYeniUrunEkle = new System.Windows.Forms.Button();
            this.cmbUrunKategori = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYeniUrunFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(30, 29);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(241, 21);
            this.cmbKategoriler.TabIndex = 0;
            this.cmbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriler_SelectedIndexChanged);
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(31, 74);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(240, 316);
            this.lstUrunler.TabIndex = 1;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "UrunAdi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fiyat";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(349, 108);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(120, 20);
            this.txtUrunAdi.TabIndex = 3;
            // 
            // cbSatistaMi
            // 
            this.cbSatistaMi.AutoSize = true;
            this.cbSatistaMi.Location = new System.Drawing.Point(349, 170);
            this.cbSatistaMi.Name = "cbSatistaMi";
            this.cbSatistaMi.Size = new System.Drawing.Size(69, 17);
            this.cbSatistaMi.TabIndex = 4;
            this.cbSatistaMi.Text = "SatistaMi";
            this.cbSatistaMi.UseVisualStyleBackColor = true;
            // 
            // numFiyat
            // 
            this.numFiyat.DecimalPlaces = 2;
            this.numFiyat.Location = new System.Drawing.Point(349, 138);
            this.numFiyat.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numFiyat.Name = "numFiyat";
            this.numFiyat.Size = new System.Drawing.Size(120, 20);
            this.numFiyat.TabIndex = 4;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(301, 243);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(111, 47);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategori Adı";
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(600, 33);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(159, 20);
            this.txtKategoriAdi.TabIndex = 6;
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Location = new System.Drawing.Point(600, 244);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(129, 47);
            this.btnKategoriEkle.TabIndex = 7;
            this.btnKategoriEkle.Text = "Kategori Ekle";
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(600, 64);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(159, 164);
            this.txtAciklama.TabIndex = 8;
            this.txtAciklama.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Açıklama";
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.Location = new System.Drawing.Point(301, 28);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(111, 44);
            this.btnKategoriSil.TabIndex = 9;
            this.btnKategoriSil.Text = "Kategori Sil";
            this.btnKategoriSil.UseVisualStyleBackColor = true;
            this.btnKategoriSil.Click += new System.EventHandler(this.btnKategoriSil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(803, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "UrunAdi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(819, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Fiyat";
            // 
            // txtYeniUrunAdi
            // 
            this.txtYeniUrunAdi.Location = new System.Drawing.Point(868, 80);
            this.txtYeniUrunAdi.Name = "txtYeniUrunAdi";
            this.txtYeniUrunAdi.Size = new System.Drawing.Size(120, 20);
            this.txtYeniUrunAdi.TabIndex = 3;
            // 
            // cbYeniSatistaMi
            // 
            this.cbYeniSatistaMi.AutoSize = true;
            this.cbYeniSatistaMi.Location = new System.Drawing.Point(868, 142);
            this.cbYeniSatistaMi.Name = "cbYeniSatistaMi";
            this.cbYeniSatistaMi.Size = new System.Drawing.Size(69, 17);
            this.cbYeniSatistaMi.TabIndex = 4;
            this.cbYeniSatistaMi.Text = "SatistaMi";
            this.cbYeniSatistaMi.UseVisualStyleBackColor = true;
            // 
            // numYeniUrunFiyati
            // 
            this.numYeniUrunFiyati.DecimalPlaces = 2;
            this.numYeniUrunFiyati.Location = new System.Drawing.Point(868, 110);
            this.numYeniUrunFiyati.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numYeniUrunFiyati.Name = "numYeniUrunFiyati";
            this.numYeniUrunFiyati.Size = new System.Drawing.Size(120, 20);
            this.numYeniUrunFiyati.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(784, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Kategori Adı";
            // 
            // btnYeniUrunEkle
            // 
            this.btnYeniUrunEkle.Location = new System.Drawing.Point(869, 244);
            this.btnYeniUrunEkle.Name = "btnYeniUrunEkle";
            this.btnYeniUrunEkle.Size = new System.Drawing.Size(120, 47);
            this.btnYeniUrunEkle.TabIndex = 10;
            this.btnYeniUrunEkle.Text = "Yeni Ürün Ekle";
            this.btnYeniUrunEkle.UseVisualStyleBackColor = true;
            this.btnYeniUrunEkle.Click += new System.EventHandler(this.btnYeniUrunEkle_Click);
            // 
            // cmbUrunKategori
            // 
            this.cmbUrunKategori.FormattingEnabled = true;
            this.cmbUrunKategori.Location = new System.Drawing.Point(868, 37);
            this.cmbUrunKategori.Name = "cmbUrunKategori";
            this.cmbUrunKategori.Size = new System.Drawing.Size(121, 21);
            this.cmbUrunKategori.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 488);
            this.Controls.Add(this.cmbUrunKategori);
            this.Controls.Add(this.btnYeniUrunEkle);
            this.Controls.Add(this.btnKategoriSil);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.btnKategoriEkle);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.numYeniUrunFiyati);
            this.Controls.Add(this.numFiyat);
            this.Controls.Add(this.cbYeniSatistaMi);
            this.Controls.Add(this.cbSatistaMi);
            this.Controls.Add(this.txtYeniUrunAdi);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.cmbKategoriler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYeniUrunFiyati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.CheckBox cbSatistaMi;
        private System.Windows.Forms.NumericUpDown numFiyat;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKategoriSil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYeniUrunAdi;
        private System.Windows.Forms.CheckBox cbYeniSatistaMi;
        private System.Windows.Forms.NumericUpDown numYeniUrunFiyati;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnYeniUrunEkle;
        private System.Windows.Forms.ComboBox cmbUrunKategori;
    }
}

