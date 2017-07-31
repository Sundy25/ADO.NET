namespace AracModel.UI.WFA
{
    partial class FormModel
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
            this.cbTum = new System.Windows.Forms.CheckBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.nFiyat = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSatistaMi = new System.Windows.Forms.CheckBox();
            this.txtModelAdi = new System.Windows.Forms.TextBox();
            this.cmbMarkalar = new System.Windows.Forms.ComboBox();
            this.lstModeller = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTum
            // 
            this.cbTum.AutoSize = true;
            this.cbTum.Location = new System.Drawing.Point(129, 26);
            this.cbTum.Name = "cbTum";
            this.cbTum.Size = new System.Drawing.Size(47, 17);
            this.cbTum.TabIndex = 18;
            this.cbTum.Text = "Tüm";
            this.cbTum.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(383, 149);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(70, 53);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(319, 149);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(70, 53);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(250, 149);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(70, 53);
            this.btnYeni.TabIndex = 17;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            // 
            // nFiyat
            // 
            this.nFiyat.DecimalPlaces = 2;
            this.nFiyat.Location = new System.Drawing.Point(319, 60);
            this.nFiyat.MaximumSize = new System.Drawing.Size(9999, 0);
            this.nFiyat.Name = "nFiyat";
            this.nFiyat.Size = new System.Drawing.Size(120, 20);
            this.nFiyat.TabIndex = 14;
            this.nFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fiyat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ürün Adı";
            // 
            // cbSatistaMi
            // 
            this.cbSatistaMi.AutoSize = true;
            this.cbSatistaMi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbSatistaMi.Location = new System.Drawing.Point(261, 98);
            this.cbSatistaMi.Name = "cbSatistaMi";
            this.cbSatistaMi.Size = new System.Drawing.Size(78, 17);
            this.cbSatistaMi.TabIndex = 11;
            this.cbSatistaMi.Text = "Satışta Mı?";
            this.cbSatistaMi.UseVisualStyleBackColor = true;
            // 
            // txtModelAdi
            // 
            this.txtModelAdi.Location = new System.Drawing.Point(319, 26);
            this.txtModelAdi.Name = "txtModelAdi";
            this.txtModelAdi.Size = new System.Drawing.Size(100, 20);
            this.txtModelAdi.TabIndex = 10;
            // 
            // cmbMarkalar
            // 
            this.cmbMarkalar.FormattingEnabled = true;
            this.cmbMarkalar.Location = new System.Drawing.Point(12, 24);
            this.cmbMarkalar.Name = "cmbMarkalar";
            this.cmbMarkalar.Size = new System.Drawing.Size(111, 21);
            this.cmbMarkalar.TabIndex = 9;
            // 
            // lstModeller
            // 
            this.lstModeller.FormattingEnabled = true;
            this.lstModeller.Location = new System.Drawing.Point(12, 60);
            this.lstModeller.Name = "lstModeller";
            this.lstModeller.Size = new System.Drawing.Size(170, 238);
            this.lstModeller.TabIndex = 8;
            // 
            // FormModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 337);
            this.Controls.Add(this.cbTum);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.nFiyat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSatistaMi);
            this.Controls.Add(this.txtModelAdi);
            this.Controls.Add(this.cmbMarkalar);
            this.Controls.Add(this.lstModeller);
            this.Name = "FormModel";
            this.Text = "FormModel";
            ((System.ComponentModel.ISupportInitialize)(this.nFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbTum;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.NumericUpDown nFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbSatistaMi;
        private System.Windows.Forms.TextBox txtModelAdi;
        private System.Windows.Forms.ComboBox cmbMarkalar;
        private System.Windows.Forms.ListBox lstModeller;
    }
}