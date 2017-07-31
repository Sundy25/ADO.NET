namespace Arabalarim
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarkaAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKurulusYili = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKurucusu = new System.Windows.Forms.TextBox();
            this.btnMarkaEkle = new System.Windows.Forms.Button();
            this.cmbMarkalar = new System.Windows.Forms.ComboBox();
            this.txtModelAdi = new System.Windows.Forms.TextBox();
            this.txtModelYili = new System.Windows.Forms.TextBox();
            this.txtMotorHacmi = new System.Windows.Forms.TextBox();
            this.btnModelEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMarkaListesi = new System.Windows.Forms.ComboBox();
            this.lstModelListesi = new System.Windows.Forms.ListBox();
            this.btnMarkaSil = new System.Windows.Forms.Button();
            this.btnMarkaGuncelle = new System.Windows.Forms.Button();
            this.btnModelSil = new System.Windows.Forms.Button();
            this.btnModelGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDataGetir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka Adı";
            // 
            // txtMarkaAdi
            // 
            this.txtMarkaAdi.Location = new System.Drawing.Point(458, 17);
            this.txtMarkaAdi.Name = "txtMarkaAdi";
            this.txtMarkaAdi.Size = new System.Drawing.Size(100, 20);
            this.txtMarkaAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kuruluş Yılı";
            // 
            // txtKurulusYili
            // 
            this.txtKurulusYili.Location = new System.Drawing.Point(458, 52);
            this.txtKurulusYili.Name = "txtKurulusYili";
            this.txtKurulusYili.Size = new System.Drawing.Size(100, 20);
            this.txtKurulusYili.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kurucusu";
            // 
            // txtKurucusu
            // 
            this.txtKurucusu.Location = new System.Drawing.Point(458, 88);
            this.txtKurucusu.Name = "txtKurucusu";
            this.txtKurucusu.Size = new System.Drawing.Size(100, 20);
            this.txtKurucusu.TabIndex = 3;
            // 
            // btnMarkaEkle
            // 
            this.btnMarkaEkle.Location = new System.Drawing.Point(477, 123);
            this.btnMarkaEkle.Name = "btnMarkaEkle";
            this.btnMarkaEkle.Size = new System.Drawing.Size(81, 38);
            this.btnMarkaEkle.TabIndex = 4;
            this.btnMarkaEkle.Text = "Ekle";
            this.btnMarkaEkle.UseVisualStyleBackColor = true;
            this.btnMarkaEkle.Click += new System.EventHandler(this.btnMarkaEkle_Click);
            // 
            // cmbMarkalar
            // 
            this.cmbMarkalar.FormattingEnabled = true;
            this.cmbMarkalar.Location = new System.Drawing.Point(437, 177);
            this.cmbMarkalar.Name = "cmbMarkalar";
            this.cmbMarkalar.Size = new System.Drawing.Size(121, 21);
            this.cmbMarkalar.TabIndex = 5;
            // 
            // txtModelAdi
            // 
            this.txtModelAdi.Location = new System.Drawing.Point(437, 213);
            this.txtModelAdi.Name = "txtModelAdi";
            this.txtModelAdi.Size = new System.Drawing.Size(121, 20);
            this.txtModelAdi.TabIndex = 6;
            // 
            // txtModelYili
            // 
            this.txtModelYili.Location = new System.Drawing.Point(437, 245);
            this.txtModelYili.Name = "txtModelYili";
            this.txtModelYili.Size = new System.Drawing.Size(121, 20);
            this.txtModelYili.TabIndex = 7;
            // 
            // txtMotorHacmi
            // 
            this.txtMotorHacmi.Location = new System.Drawing.Point(437, 282);
            this.txtMotorHacmi.Name = "txtMotorHacmi";
            this.txtMotorHacmi.Size = new System.Drawing.Size(121, 20);
            this.txtMotorHacmi.TabIndex = 8;
            // 
            // btnModelEkle
            // 
            this.btnModelEkle.Location = new System.Drawing.Point(477, 315);
            this.btnModelEkle.Name = "btnModelEkle";
            this.btnModelEkle.Size = new System.Drawing.Size(81, 38);
            this.btnModelEkle.TabIndex = 9;
            this.btnModelEkle.Text = "Ekle";
            this.btnModelEkle.UseVisualStyleBackColor = true;
            this.btnModelEkle.Click += new System.EventHandler(this.btnModelEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Marka Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Model Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Yıl";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(366, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Motor Hacmi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Marka Adı";
            // 
            // cmbMarkaListesi
            // 
            this.cmbMarkaListesi.FormattingEnabled = true;
            this.cmbMarkaListesi.Location = new System.Drawing.Point(100, 20);
            this.cmbMarkaListesi.Name = "cmbMarkaListesi";
            this.cmbMarkaListesi.Size = new System.Drawing.Size(158, 21);
            this.cmbMarkaListesi.TabIndex = 10;
            this.cmbMarkaListesi.SelectedIndexChanged += new System.EventHandler(this.cmbMarkaListesi_SelectedIndexChanged);
            // 
            // lstModelListesi
            // 
            this.lstModelListesi.FormattingEnabled = true;
            this.lstModelListesi.Location = new System.Drawing.Point(100, 76);
            this.lstModelListesi.Name = "lstModelListesi";
            this.lstModelListesi.Size = new System.Drawing.Size(158, 277);
            this.lstModelListesi.TabIndex = 11;
            this.lstModelListesi.SelectedIndexChanged += new System.EventHandler(this.lstModelListesi_SelectedIndexChanged);
            // 
            // btnMarkaSil
            // 
            this.btnMarkaSil.Location = new System.Drawing.Point(285, 123);
            this.btnMarkaSil.Name = "btnMarkaSil";
            this.btnMarkaSil.Size = new System.Drawing.Size(75, 38);
            this.btnMarkaSil.TabIndex = 10;
            this.btnMarkaSil.Text = "Sil";
            this.btnMarkaSil.UseVisualStyleBackColor = true;
            this.btnMarkaSil.Click += new System.EventHandler(this.btnMarkaSil_Click);
            // 
            // btnMarkaGuncelle
            // 
            this.btnMarkaGuncelle.Location = new System.Drawing.Point(382, 123);
            this.btnMarkaGuncelle.Name = "btnMarkaGuncelle";
            this.btnMarkaGuncelle.Size = new System.Drawing.Size(75, 38);
            this.btnMarkaGuncelle.TabIndex = 10;
            this.btnMarkaGuncelle.Text = "Güncelle";
            this.btnMarkaGuncelle.UseVisualStyleBackColor = true;
            this.btnMarkaGuncelle.Click += new System.EventHandler(this.btnMarkaGuncelle_Click);
            // 
            // btnModelSil
            // 
            this.btnModelSil.Location = new System.Drawing.Point(285, 315);
            this.btnModelSil.Name = "btnModelSil";
            this.btnModelSil.Size = new System.Drawing.Size(75, 38);
            this.btnModelSil.TabIndex = 10;
            this.btnModelSil.Text = "Sil";
            this.btnModelSil.UseVisualStyleBackColor = true;
            this.btnModelSil.Click += new System.EventHandler(this.btnModelSil_Click);
            // 
            // btnModelGuncelle
            // 
            this.btnModelGuncelle.Location = new System.Drawing.Point(382, 315);
            this.btnModelGuncelle.Name = "btnModelGuncelle";
            this.btnModelGuncelle.Size = new System.Drawing.Size(75, 38);
            this.btnModelGuncelle.TabIndex = 10;
            this.btnModelGuncelle.Text = "Güncelle";
            this.btnModelGuncelle.UseVisualStyleBackColor = true;
            this.btnModelGuncelle.Click += new System.EventHandler(this.btnModelGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(622, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 264);
            this.dataGridView1.TabIndex = 12;
            // 
            // btnDataGetir
            // 
            this.btnDataGetir.Location = new System.Drawing.Point(762, 311);
            this.btnDataGetir.Name = "btnDataGetir";
            this.btnDataGetir.Size = new System.Drawing.Size(100, 42);
            this.btnDataGetir.TabIndex = 13;
            this.btnDataGetir.Text = "Data Getir";
            this.btnDataGetir.UseVisualStyleBackColor = true;
            this.btnDataGetir.Click += new System.EventHandler(this.btnDataGetir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 469);
            this.Controls.Add(this.btnDataGetir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnModelGuncelle);
            this.Controls.Add(this.btnModelSil);
            this.Controls.Add(this.btnMarkaGuncelle);
            this.Controls.Add(this.btnMarkaSil);
            this.Controls.Add(this.lstModelListesi);
            this.Controls.Add(this.cmbMarkaListesi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnModelEkle);
            this.Controls.Add(this.txtMotorHacmi);
            this.Controls.Add(this.txtModelYili);
            this.Controls.Add(this.txtModelAdi);
            this.Controls.Add(this.cmbMarkalar);
            this.Controls.Add(this.btnMarkaEkle);
            this.Controls.Add(this.txtKurucusu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKurulusYili);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMarkaAdi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarkaAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKurulusYili;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKurucusu;
        private System.Windows.Forms.Button btnMarkaEkle;
        private System.Windows.Forms.ComboBox cmbMarkalar;
        private System.Windows.Forms.TextBox txtModelAdi;
        private System.Windows.Forms.TextBox txtModelYili;
        private System.Windows.Forms.TextBox txtMotorHacmi;
        private System.Windows.Forms.Button btnModelEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMarkaListesi;
        private System.Windows.Forms.ListBox lstModelListesi;
        private System.Windows.Forms.Button btnMarkaSil;
        private System.Windows.Forms.Button btnMarkaGuncelle;
        private System.Windows.Forms.Button btnModelSil;
        private System.Windows.Forms.Button btnModelGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDataGetir;
    }
}

