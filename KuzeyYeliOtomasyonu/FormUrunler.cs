using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuzeyYeliOtomasyonu
{
    public partial class FormUrunler : Form
    {
        public FormUrunler()
        {
            InitializeComponent();
        }

        private void urunlerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.urunlerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kuzeyYeliDataSet);

           

        }

        private void FormUrunler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kuzeyYeliDataSet.Urunler' table. You can move, or remove it, as needed.
          
            // burada bir sql table adaptor yaparak içi doldurmamız lazım
            SqlDataAdapter da = new SqlDataAdapter("Select ID, Ad from Kategoriler", 
            ConfigurationManager.ConnectionStrings[0].ConnectionString); // neden 0 yaptık? 

            DataTable ds = new DataTable();
            da.Fill(ds);

            kategoriIDComboBox.DisplayMember = "Ad";
            kategoriIDComboBox.ValueMember = "ID";
            kategoriIDComboBox.DataSource = ds;
            
        // datarow, connect disconnect bilin bu işin temeli. Ama bu kadar yeter. 
        // 

            this.urunlerTableAdapter.Fill(this.kuzeyYeliDataSet.Urunler); //bu kod en üstteydi, en alta koyduk
        }
    }
}
