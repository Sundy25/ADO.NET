namespace KuzeyYeliOtomasyonu
{
    partial class FormKategoriler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKategoriler));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label kategoriAdiLabel;
            System.Windows.Forms.Label aciklamaLabel;
            System.Windows.Forms.Label eklenmeTarihiLabel;
            this.kuzeyYeliDataSet = new KuzeyYeliOtomasyonu.KuzeyYeliDataSet();
            this.kategorilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorilerTableAdapter = new KuzeyYeliOtomasyonu.KuzeyYeliDataSetTableAdapters.KategorilerTableAdapter();
            this.tableAdapterManager = new KuzeyYeliOtomasyonu.KuzeyYeliDataSetTableAdapters.TableAdapterManager();
            this.kategorilerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.kategorilerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kategorilerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.kategoriAdiTextBox = new System.Windows.Forms.TextBox();
            this.aciklamaTextBox = new System.Windows.Forms.TextBox();
            this.eklenmeTarihiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnUrunler = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            kategoriAdiLabel = new System.Windows.Forms.Label();
            aciklamaLabel = new System.Windows.Forms.Label();
            eklenmeTarihiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kuzeyYeliDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingNavigator)).BeginInit();
            this.kategorilerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kuzeyYeliDataSet
            // 
            this.kuzeyYeliDataSet.DataSetName = "KuzeyYeliDataSet";
            this.kuzeyYeliDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategorilerBindingSource
            // 
            this.kategorilerBindingSource.DataMember = "Kategoriler";
            this.kategorilerBindingSource.DataSource = this.kuzeyYeliDataSet;
            // 
            // kategorilerTableAdapter
            // 
            this.kategorilerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KategorilerTableAdapter = this.kategorilerTableAdapter;
            this.tableAdapterManager.UpdateOrder = KuzeyYeliOtomasyonu.KuzeyYeliDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UrunlerTableAdapter = null;
            // 
            // kategorilerBindingNavigator
            // 
            this.kategorilerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kategorilerBindingNavigator.BindingSource = this.kategorilerBindingSource;
            this.kategorilerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kategorilerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kategorilerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.kategorilerBindingNavigatorSaveItem});
            this.kategorilerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kategorilerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kategorilerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kategorilerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kategorilerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kategorilerBindingNavigator.Name = "kategorilerBindingNavigator";
            this.kategorilerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kategorilerBindingNavigator.Size = new System.Drawing.Size(856, 25);
            this.kategorilerBindingNavigator.TabIndex = 0;
            this.kategorilerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // kategorilerBindingNavigatorSaveItem
            // 
            this.kategorilerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kategorilerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kategorilerBindingNavigatorSaveItem.Image")));
            this.kategorilerBindingNavigatorSaveItem.Name = "kategorilerBindingNavigatorSaveItem";
            this.kategorilerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.kategorilerBindingNavigatorSaveItem.Text = "Save Data";
            this.kategorilerBindingNavigatorSaveItem.Click += new System.EventHandler(this.kategorilerBindingNavigatorSaveItem_Click);
            // 
            // kategorilerDataGridView
            // 
            this.kategorilerDataGridView.AutoGenerateColumns = false;
            this.kategorilerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kategorilerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.kategorilerDataGridView.DataSource = this.kategorilerBindingSource;
            this.kategorilerDataGridView.Location = new System.Drawing.Point(357, 70);
            this.kategorilerDataGridView.Name = "kategorilerDataGridView";
            this.kategorilerDataGridView.Size = new System.Drawing.Size(443, 220);
            this.kategorilerDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KategoriAdi";
            this.dataGridViewTextBoxColumn2.HeaderText = "KategoriAdi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Aciklama";
            this.dataGridViewTextBoxColumn3.HeaderText = "Aciklama";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EklenmeTarihi";
            this.dataGridViewTextBoxColumn4.HeaderText = "EklenmeTarihi";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(90, 77);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kategorilerBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(117, 70);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(205, 20);
            this.iDTextBox.TabIndex = 3;
            // 
            // kategoriAdiLabel
            // 
            kategoriAdiLabel.AutoSize = true;
            kategoriAdiLabel.Location = new System.Drawing.Point(44, 116);
            kategoriAdiLabel.Name = "kategoriAdiLabel";
            kategoriAdiLabel.Size = new System.Drawing.Size(67, 13);
            kategoriAdiLabel.TabIndex = 4;
            kategoriAdiLabel.Text = "Kategori Adi:";
            // 
            // kategoriAdiTextBox
            // 
            this.kategoriAdiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kategorilerBindingSource, "KategoriAdi", true));
            this.kategoriAdiTextBox.Location = new System.Drawing.Point(117, 109);
            this.kategoriAdiTextBox.Name = "kategoriAdiTextBox";
            this.kategoriAdiTextBox.Size = new System.Drawing.Size(205, 20);
            this.kategoriAdiTextBox.TabIndex = 5;
            // 
            // aciklamaLabel
            // 
            aciklamaLabel.AutoSize = true;
            aciklamaLabel.Location = new System.Drawing.Point(58, 155);
            aciklamaLabel.Name = "aciklamaLabel";
            aciklamaLabel.Size = new System.Drawing.Size(53, 13);
            aciklamaLabel.TabIndex = 6;
            aciklamaLabel.Text = "Aciklama:";
            // 
            // aciklamaTextBox
            // 
            this.aciklamaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kategorilerBindingSource, "Aciklama", true));
            this.aciklamaTextBox.Location = new System.Drawing.Point(117, 148);
            this.aciklamaTextBox.Name = "aciklamaTextBox";
            this.aciklamaTextBox.Size = new System.Drawing.Size(205, 20);
            this.aciklamaTextBox.TabIndex = 7;
            // 
            // eklenmeTarihiLabel
            // 
            eklenmeTarihiLabel.AutoSize = true;
            eklenmeTarihiLabel.Location = new System.Drawing.Point(31, 194);
            eklenmeTarihiLabel.Name = "eklenmeTarihiLabel";
            eklenmeTarihiLabel.Size = new System.Drawing.Size(80, 13);
            eklenmeTarihiLabel.TabIndex = 8;
            eklenmeTarihiLabel.Text = "Eklenme Tarihi:";
            // 
            // eklenmeTarihiDateTimePicker
            // 
            this.eklenmeTarihiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.kategorilerBindingSource, "EklenmeTarihi", true));
            this.eklenmeTarihiDateTimePicker.Location = new System.Drawing.Point(117, 187);
            this.eklenmeTarihiDateTimePicker.Name = "eklenmeTarihiDateTimePicker";
            this.eklenmeTarihiDateTimePicker.Size = new System.Drawing.Size(205, 20);
            this.eklenmeTarihiDateTimePicker.TabIndex = 9;
            // 
            // btnUrunler
            // 
            this.btnUrunler.Location = new System.Drawing.Point(236, 248);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(75, 23);
            this.btnUrunler.TabIndex = 10;
            this.btnUrunler.Text = "Ürünler";
            this.btnUrunler.UseVisualStyleBackColor = true;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // FormKategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 307);
            this.Controls.Add(this.btnUrunler);
            this.Controls.Add(eklenmeTarihiLabel);
            this.Controls.Add(this.eklenmeTarihiDateTimePicker);
            this.Controls.Add(aciklamaLabel);
            this.Controls.Add(this.aciklamaTextBox);
            this.Controls.Add(kategoriAdiLabel);
            this.Controls.Add(this.kategoriAdiTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.kategorilerDataGridView);
            this.Controls.Add(this.kategorilerBindingNavigator);
            this.Name = "FormKategoriler";
            this.Text = "FormKategoriler";
            this.Load += new System.EventHandler(this.FormKategoriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kuzeyYeliDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingNavigator)).EndInit();
            this.kategorilerBindingNavigator.ResumeLayout(false);
            this.kategorilerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KuzeyYeliDataSet kuzeyYeliDataSet;
        private System.Windows.Forms.BindingSource kategorilerBindingSource;
        private KuzeyYeliDataSetTableAdapters.KategorilerTableAdapter kategorilerTableAdapter;
        private KuzeyYeliDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kategorilerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton kategorilerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView kategorilerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox kategoriAdiTextBox;
        private System.Windows.Forms.TextBox aciklamaTextBox;
        private System.Windows.Forms.DateTimePicker eklenmeTarihiDateTimePicker;
        private System.Windows.Forms.Button btnUrunler;
    }
}