namespace Kuzey.UI.WFA
{
    partial class FormSiparisOlustur
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
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.nAdet = new System.Windows.Forms.NumericUpDown();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.nIndirim = new System.Windows.Forms.NumericUpDown();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.dtpIstenenTarih = new System.Windows.Forms.DateTimePicker();
            this.nKargoFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            this.btnSiparisiOnayla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIndirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKargoFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(29, 57);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(163, 355);
            this.lstUrunler.TabIndex = 3;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(69, 31);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(123, 20);
            this.txtArama.TabIndex = 2;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.Location = new System.Drawing.Point(379, 57);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(173, 355);
            this.lstSepet.TabIndex = 4;
            this.lstSepet.SizeChanged += new System.EventHandler(this.lstSepet_SizeChanged);
            // 
            // nAdet
            // 
            this.nAdet.Location = new System.Drawing.Point(223, 84);
            this.nAdet.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nAdet.Name = "nAdet";
            this.nAdet.Size = new System.Drawing.Size(120, 20);
            this.nAdet.TabIndex = 5;
            this.nAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSepeteEkle.Location = new System.Drawing.Point(223, 192);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(120, 81);
            this.btnSepeteEkle.TabIndex = 6;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // nIndirim
            // 
            this.nIndirim.Location = new System.Drawing.Point(223, 130);
            this.nIndirim.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nIndirim.Name = "nIndirim";
            this.nIndirim.Size = new System.Drawing.Size(120, 20);
            this.nIndirim.TabIndex = 5;
            this.nIndirim.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(219, 367);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(48, 20);
            this.lblFiyat.TabIndex = 7;
            this.lblFiyat.Text = "Fiyat";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(219, 395);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(51, 20);
            this.lblTutar.TabIndex = 7;
            this.lblTutar.Text = "Tutar";
            // 
            // dtpIstenenTarih
            // 
            this.dtpIstenenTarih.Location = new System.Drawing.Point(575, 57);
            this.dtpIstenenTarih.Name = "dtpIstenenTarih";
            this.dtpIstenenTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpIstenenTarih.TabIndex = 8;
            // 
            // nKargoFiyat
            // 
            this.nKargoFiyat.DecimalPlaces = 2;
            this.nKargoFiyat.Location = new System.Drawing.Point(575, 103);
            this.nKargoFiyat.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nKargoFiyat.Name = "nKargoFiyat";
            this.nKargoFiyat.Size = new System.Drawing.Size(120, 20);
            this.nKargoFiyat.TabIndex = 9;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(575, 140);
            this.txtAdres.MaxLength = 250;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(199, 174);
            this.txtAdres.TabIndex = 10;
            this.txtAdres.Text = "";
            // 
            // btnSiparisiOnayla
            // 
            this.btnSiparisiOnayla.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparisiOnayla.Location = new System.Drawing.Point(577, 338);
            this.btnSiparisiOnayla.Name = "btnSiparisiOnayla";
            this.btnSiparisiOnayla.Size = new System.Drawing.Size(198, 74);
            this.btnSiparisiOnayla.TabIndex = 11;
            this.btnSiparisiOnayla.Text = "Siparişi Onayla";
            this.btnSiparisiOnayla.UseVisualStyleBackColor = true;
            this.btnSiparisiOnayla.Click += new System.EventHandler(this.btnSiparisiOnayla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Adet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "İndirim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kargo Fiyatı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Arama";
            // 
            // FormSiparisOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 465);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSiparisiOnayla);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.nKargoFiyat);
            this.Controls.Add(this.dtpIstenenTarih);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.nIndirim);
            this.Controls.Add(this.nAdet);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.txtArama);
            this.Name = "FormSiparisOlustur";
            this.Text = "FormSiparisOlustur";
            this.Load += new System.EventHandler(this.FormSiparisOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIndirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nKargoFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.NumericUpDown nAdet;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.NumericUpDown nIndirim;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.DateTimePicker dtpIstenenTarih;
        private System.Windows.Forms.NumericUpDown nKargoFiyat;
        private System.Windows.Forms.RichTextBox txtAdres;
        private System.Windows.Forms.Button btnSiparisiOnayla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}