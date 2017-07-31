namespace Kuzey.UI.WFA
{
    partial class FormSiparisler
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
            this.btnSiparisOlustur = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSiparisGenelRapor = new System.Windows.Forms.Button();
            this.btnKategoriyeGoreSiparisRaporu = new System.Windows.Forms.Button();
            this.btnToplamSiparis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSiparisOlustur
            // 
            this.btnSiparisOlustur.Location = new System.Drawing.Point(838, 35);
            this.btnSiparisOlustur.Name = "btnSiparisOlustur";
            this.btnSiparisOlustur.Size = new System.Drawing.Size(107, 69);
            this.btnSiparisOlustur.TabIndex = 1;
            this.btnSiparisOlustur.Text = "Sipariş Oluştur";
            this.btnSiparisOlustur.UseVisualStyleBackColor = true;
            this.btnSiparisOlustur.Click += new System.EventHandler(this.btnSiparisOlustur_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(710, 341);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnSiparisGenelRapor
            // 
            this.btnSiparisGenelRapor.Location = new System.Drawing.Point(838, 110);
            this.btnSiparisGenelRapor.Name = "btnSiparisGenelRapor";
            this.btnSiparisGenelRapor.Size = new System.Drawing.Size(107, 69);
            this.btnSiparisGenelRapor.TabIndex = 1;
            this.btnSiparisGenelRapor.Text = "Sipariş Genel Rapor";
            this.btnSiparisGenelRapor.UseVisualStyleBackColor = true;
            this.btnSiparisGenelRapor.Click += new System.EventHandler(this.btnSiparisGenelRapor_Click);
            // 
            // btnKategoriyeGoreSiparisRaporu
            // 
            this.btnKategoriyeGoreSiparisRaporu.Location = new System.Drawing.Point(838, 185);
            this.btnKategoriyeGoreSiparisRaporu.Name = "btnKategoriyeGoreSiparisRaporu";
            this.btnKategoriyeGoreSiparisRaporu.Size = new System.Drawing.Size(107, 69);
            this.btnKategoriyeGoreSiparisRaporu.TabIndex = 1;
            this.btnKategoriyeGoreSiparisRaporu.Text = "Kategoriye göre sipariş raporu";
            this.btnKategoriyeGoreSiparisRaporu.UseVisualStyleBackColor = true;
            this.btnKategoriyeGoreSiparisRaporu.Click += new System.EventHandler(this.btnKategoriyeGoreSiparisRaporu_Click);
            // 
            // btnToplamSiparis
            // 
            this.btnToplamSiparis.Location = new System.Drawing.Point(838, 260);
            this.btnToplamSiparis.Name = "btnToplamSiparis";
            this.btnToplamSiparis.Size = new System.Drawing.Size(107, 69);
            this.btnToplamSiparis.TabIndex = 1;
            this.btnToplamSiparis.Text = "Toplam Sipariş";
            this.btnToplamSiparis.UseVisualStyleBackColor = true;
            this.btnToplamSiparis.Click += new System.EventHandler(this.btnToplamSiparis_Click);
            // 
            // FormSiparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 417);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnToplamSiparis);
            this.Controls.Add(this.btnKategoriyeGoreSiparisRaporu);
            this.Controls.Add(this.btnSiparisGenelRapor);
            this.Controls.Add(this.btnSiparisOlustur);
            this.Name = "FormSiparisler";
            this.Text = "FormSiparisler";
            this.Load += new System.EventHandler(this.FormSiparisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSiparisOlustur;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSiparisGenelRapor;
        private System.Windows.Forms.Button btnKategoriyeGoreSiparisRaporu;
        private System.Windows.Forms.Button btnToplamSiparis;
    }
}