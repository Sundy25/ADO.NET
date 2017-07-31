using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuzeyYeliOtomasyonu
{
    public partial class FormKategoriler : Form
    {
        public FormKategoriler()
        {
            InitializeComponent();
        }

        private void kategorilerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            DataRowView rows = (DataRowView)this.kategorilerBindingSource.Current;
            DataRow row = rows.Row;
            row["EklenmeTarihi"] = DateTime.Now;
            // bu üstteki üç satırı kendimiz yazdık. BU bindingsourcelerin ne olduğunu ileride göreceğiz.
            // şimdi bir de ürünler sayfası yapalım başka bir sayfada. 

            this.kategorilerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kuzeyYeliDataSet);

        }

        private void FormKategoriler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kuzeyYeliDataSet.Kategoriler' table. You can move, or remove it, as needed.
            this.kategorilerTableAdapter.Fill(this.kuzeyYeliDataSet.Kategoriler);

        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            FormUrunler urunlerform = new FormUrunler();
            urunlerform.ShowDialog();
        }
    }
}
