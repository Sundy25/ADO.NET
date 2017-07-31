namespace KuzeyYeliOtomasyonu
{
    partial class FormUrunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUrunler));
            System.Windows.Forms.Label urunAdiLabel;
            System.Windows.Forms.Label fiyatLabel;
            System.Windows.Forms.Label eklenmeTarihiLabel;
            System.Windows.Forms.Label aktifMiLabel;
            System.Windows.Forms.Label iDLabel;
            this.kuzeyYeliDataSet = new KuzeyYeliOtomasyonu.KuzeyYeliDataSet();
            this.urunlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunlerTableAdapter = new KuzeyYeliOtomasyonu.KuzeyYeliDataSetTableAdapters.UrunlerTableAdapter();
            this.tableAdapterManager = new KuzeyYeliOtomasyonu.KuzeyYeliDataSetTableAdapters.TableAdapterManager();
            this.urunlerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.urunlerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.urunlerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.urunAdiTextBox = new System.Windows.Forms.TextBox();
            this.fiyatTextBox = new System.Windows.Forms.TextBox();
            this.eklenmeTarihiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.aktifMiCheckBox = new System.Windows.Forms.CheckBox();
            this.kategoriIDComboBox = new System.Windows.Forms.ComboBox();
            urunAdiLabel = new System.Windows.Forms.Label();
            fiyatLabel = new System.Windows.Forms.Label();
            eklenmeTarihiLabel = new System.Windows.Forms.Label();
            aktifMiLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kuzeyYeliDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingNavigator)).BeginInit();
            this.urunlerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kuzeyYeliDataSet
            // 
            this.kuzeyYeliDataSet.DataSetName = "KuzeyYeliDataSet";
            this.kuzeyYeliDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunlerBindingSource
            // 
            this.urunlerBindingSource.DataMember = "Urunler";
            this.urunlerBindingSource.DataSource = this.kuzeyYeliDataSet;
            // 
            // urunlerTableAdapter
            // 
            this.urunlerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KategorilerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KuzeyYeliOtomasyonu.KuzeyYeliDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UrunlerTableAdapter = this.urunlerTableAdapter;
            // 
            // urunlerBindingNavigator
            // 
            this.urunlerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.urunlerBindingNavigator.BindingSource = this.urunlerBindingSource;
            this.urunlerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.urunlerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.urunlerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.urunlerBindingNavigatorSaveItem});
            this.urunlerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.urunlerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.urunlerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.urunlerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.urunlerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.urunlerBindingNavigator.Name = "urunlerBindingNavigator";
            this.urunlerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.urunlerBindingNavigator.Size = new System.Drawing.Size(978, 25);
            this.urunlerBindingNavigator.TabIndex = 0;
            this.urunlerBindingNavigator.Text = "bindingNavigator1";
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
            // urunlerBindingNavigatorSaveItem
            // 
            this.urunlerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.urunlerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("urunlerBindingNavigatorSaveItem.Image")));
            this.urunlerBindingNavigatorSaveItem.Name = "urunlerBindingNavigatorSaveItem";
            this.urunlerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.urunlerBindingNavigatorSaveItem.Text = "Save Data";
            this.urunlerBindingNavigatorSaveItem.Click += new System.EventHandler(this.urunlerBindingNavigatorSaveItem_Click);
            // 
            // urunlerDataGridView
            // 
            this.urunlerDataGridView.AutoGenerateColumns = false;
            this.urunlerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urunlerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1});
            this.urunlerDataGridView.DataSource = this.urunlerBindingSource;
            this.urunlerDataGridView.Location = new System.Drawing.Point(100, 158);
            this.urunlerDataGridView.Name = "urunlerDataGridView";
            this.urunlerDataGridView.Size = new System.Drawing.Size(743, 220);
            this.urunlerDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UrunAdi";
            this.dataGridViewTextBoxColumn2.HeaderText = "UrunAdi";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Fiyat";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fiyat";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Stok";
            this.dataGridViewTextBoxColumn4.HeaderText = "Stok";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "KategoriID";
            this.dataGridViewTextBoxColumn5.HeaderText = "KategoriID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "EklenmeTarihi";
            this.dataGridViewTextBoxColumn6.HeaderText = "EklenmeTarihi";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "AktifMi";
            this.dataGridViewCheckBoxColumn1.HeaderText = "AktifMi";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // urunAdiLabel
            // 
            urunAdiLabel.AutoSize = true;
            urunAdiLabel.Location = new System.Drawing.Point(269, 52);
            urunAdiLabel.Name = "urunAdiLabel";
            urunAdiLabel.Size = new System.Drawing.Size(51, 13);
            urunAdiLabel.TabIndex = 4;
            urunAdiLabel.Text = "Urun Adi:";
            // 
            // urunAdiTextBox
            // 
            this.urunAdiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urunlerBindingSource, "UrunAdi", true));
            this.urunAdiTextBox.Location = new System.Drawing.Point(326, 49);
            this.urunAdiTextBox.Name = "urunAdiTextBox";
            this.urunAdiTextBox.Size = new System.Drawing.Size(100, 20);
            this.urunAdiTextBox.TabIndex = 5;
            // 
            // fiyatLabel
            // 
            fiyatLabel.AutoSize = true;
            fiyatLabel.Location = new System.Drawing.Point(506, 52);
            fiyatLabel.Name = "fiyatLabel";
            fiyatLabel.Size = new System.Drawing.Size(32, 13);
            fiyatLabel.TabIndex = 6;
            fiyatLabel.Text = "Fiyat:";
            // 
            // fiyatTextBox
            // 
            this.fiyatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urunlerBindingSource, "Fiyat", true));
            this.fiyatTextBox.Location = new System.Drawing.Point(544, 49);
            this.fiyatTextBox.Name = "fiyatTextBox";
            this.fiyatTextBox.Size = new System.Drawing.Size(100, 20);
            this.fiyatTextBox.TabIndex = 7;
            // 
            // eklenmeTarihiLabel
            // 
            eklenmeTarihiLabel.AutoSize = true;
            eklenmeTarihiLabel.Location = new System.Drawing.Point(5, 116);
            eklenmeTarihiLabel.Name = "eklenmeTarihiLabel";
            eklenmeTarihiLabel.Size = new System.Drawing.Size(80, 13);
            eklenmeTarihiLabel.TabIndex = 8;
            eklenmeTarihiLabel.Text = "Eklenme Tarihi:";
            // 
            // eklenmeTarihiDateTimePicker
            // 
            this.eklenmeTarihiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.urunlerBindingSource, "EklenmeTarihi", true));
            this.eklenmeTarihiDateTimePicker.Location = new System.Drawing.Point(91, 112);
            this.eklenmeTarihiDateTimePicker.Name = "eklenmeTarihiDateTimePicker";
            this.eklenmeTarihiDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.eklenmeTarihiDateTimePicker.TabIndex = 9;
            // 
            // aktifMiLabel
            // 
            aktifMiLabel.AutoSize = true;
            aktifMiLabel.Location = new System.Drawing.Point(433, 116);
            aktifMiLabel.Name = "aktifMiLabel";
            aktifMiLabel.Size = new System.Drawing.Size(45, 13);
            aktifMiLabel.TabIndex = 10;
            aktifMiLabel.Text = "Aktif Mi:";
            // 
            // aktifMiCheckBox
            // 
            this.aktifMiCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.urunlerBindingSource, "AktifMi", true));
            this.aktifMiCheckBox.Location = new System.Drawing.Point(484, 111);
            this.aktifMiCheckBox.Name = "aktifMiCheckBox";
            this.aktifMiCheckBox.Size = new System.Drawing.Size(104, 24);
            this.aktifMiCheckBox.TabIndex = 11;
            this.aktifMiCheckBox.UseVisualStyleBackColor = true;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(64, 55);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 11;
            iDLabel.Text = "ID:";
            // 
            // kategoriIDComboBox
            // 
            this.kategoriIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.urunlerBindingSource, "ID", true));
            this.kategoriIDComboBox.FormattingEnabled = true;
            this.kategoriIDComboBox.Location = new System.Drawing.Point(91, 52);
            this.kategoriIDComboBox.Name = "kategoriIDComboBox";
            this.kategoriIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.kategoriIDComboBox.TabIndex = 12;
            // 
            // FormUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 398);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.kategoriIDComboBox);
            this.Controls.Add(aktifMiLabel);
            this.Controls.Add(this.aktifMiCheckBox);
            this.Controls.Add(eklenmeTarihiLabel);
            this.Controls.Add(this.eklenmeTarihiDateTimePicker);
            this.Controls.Add(fiyatLabel);
            this.Controls.Add(this.fiyatTextBox);
            this.Controls.Add(urunAdiLabel);
            this.Controls.Add(this.urunAdiTextBox);
            this.Controls.Add(this.urunlerDataGridView);
            this.Controls.Add(this.urunlerBindingNavigator);
            this.Name = "FormUrunler";
            this.Text = "FormUrunler";
            this.Load += new System.EventHandler(this.FormUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kuzeyYeliDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerBindingNavigator)).EndInit();
            this.urunlerBindingNavigator.ResumeLayout(false);
            this.urunlerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KuzeyYeliDataSet kuzeyYeliDataSet;
        private System.Windows.Forms.BindingSource urunlerBindingSource;
        private KuzeyYeliDataSetTableAdapters.UrunlerTableAdapter urunlerTableAdapter;
        private KuzeyYeliDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator urunlerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton urunlerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView urunlerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox urunAdiTextBox;
        private System.Windows.Forms.TextBox fiyatTextBox;
        private System.Windows.Forms.DateTimePicker eklenmeTarihiDateTimePicker;
        private System.Windows.Forms.CheckBox aktifMiCheckBox;
        private System.Windows.Forms.ComboBox kategoriIDComboBox;
    }
}