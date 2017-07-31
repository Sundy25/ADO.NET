using Kuzey.BLL.Repository;
using Kuzey.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuzey.UI.WFA
{
    public partial class FormSiparisler : Form
    {
        public FormSiparisler()
        {
            InitializeComponent();
        }

        private FormSiparisOlustur frmSiparisOlustur = new FormSiparisOlustur();
        private void btnSiparisOlustur_Click(object sender, EventArgs e)
        {
            if (frmSiparisOlustur != null || frmSiparisOlustur.IsDisposed) // burada tek çizgi kullandığınızda altını çizmesinin sebebi bir nesne null sa property si olmadığı için diğerine bakmadan atlar. tek çizgide ikisine de bakar. Çift ise biri nullsa öbürüne bakmaz. 
            {
                frmSiparisOlustur = new FormSiparisOlustur();
                frmSiparisOlustur.Show();
            }
        }

        private void FormSiparisler_Load(object sender, EventArgs e)
        {
            // bir tablo yazsın, sipariş adı,idsi, miktarı, adresi. Sepette yazdığı gibi yazsın.
            // ikinci olarak da entity de transaction yapacaksın. Neden? Diyelim on sipariş verdik, foreeach dönerken 5. siparişte program hata verdi. Sana 5 ürün siparişi gelir. Bunu engellemek. 
            MyContext db = new MyContext();
            dataGridView1.DataSource = new SiparisRepo().SiparisRaporu();

           
        }

        private void btnSiparisGenelRapor_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new SiparisRepo().SiparisRaporu();
        }

        private void btnKategoriyeGoreSiparisRaporu_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new SiparisRepo().KategoriyeGoreSiparisRaporu();
        }

        private void btnToplamSiparis_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new SiparisRepo().SiparisToplamRaporu();
        }
    }
}
