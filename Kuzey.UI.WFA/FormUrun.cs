using Kuzey.BLL;
using Kuzey.BLL.Repository;
using Kuzey.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// sınavda çıkar. Dataadapter, tableadapter, dataset, Bunların farkları sınavda çıkabilir. 
namespace Kuzey.UI.WFA
{
    public partial class FormUrun : Form
    {
        public FormUrun()
        {
            InitializeComponent();
        }

        private void FormUrun_Load(object sender, EventArgs e)
        {
            lstUrunler.DisplayMember = "UrunAdi"; // bu ikisini yazmazsan ürünleri isimleri ile değil adresleri ile görürsünüz.
            cmbKategoriler.DisplayMember = "KategoriAdi";
            //cmbKategoriler.DataSource = new KategoriRepo().TumKategorileriGetir();

            cmbKategoriler.DataSource = new CategoryRepo().GetAll(); // üsttekini yoruma alıp jenerik yaparak hallettik bu işi. 
        }

        private void UrunleriYukle()
        {

                if (cmbKategoriler.SelectedItem == null) return;

            var seciliKategori = cmbKategoriler.SelectedItem as Kategori;

            //lstUrunler.DataSource = new UrunRepo().KategorininUrunleriniGetir(seciliKategori) // urunrepo nun içindeki methodu kullandık pamps
            //.Where(x => x.SatistaMi == cbTum.Checked).ToList();

            //var urunler = new UrunRepo().KategorininUrunleriniGetir(seciliKategori);
            // urunrepo nun içindeki methodu kullandık.

            var urunler = new ProductRepo().GetAllByCategory(seciliKategori);

        lstUrunler.DataSource = !cbTum.Checked? urunler.Where(x => x.SatistaMi).ToList() : urunler; // şu : kısmını else olarak görüyor. İf else nin deişik bir yazım hali bu. 

        }
        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            UrunleriYukle();

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori kategori = cmbKategoriler.SelectedItem as Kategori;

                //if (kategori != null)
                //{
                //    new UrunRepo().UrunEkle(new Urun()
                //    {
                //        UrunAdi = txtUrunAdi.Text,
                //        Fiyat = nFiyat.Value,
                //        SatistaMi = cbSatistaMi.Checked,
                //        KategoriId = kategori.Id
                //    });
                //    UrunleriYukle();
                //}
                if (kategori != null)
                {
                    new ProductRepo().Insert(new Urun()
                    {
                        UrunAdi = txtUrunAdi.Text,
                        Fiyat = nFiyat.Value,
                        SatistaMi = cbSatistaMi.Checked,
                        KategoriId = kategori.Id
                    });
                    UrunleriYukle();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;
             {
                Urun seciliUrun = lstUrunler.SelectedItem as Urun;
                txtUrunAdi.Text = seciliUrun.UrunAdi;
                nFiyat.Value = seciliUrun.Fiyat;
                cbSatistaMi.Checked = seciliUrun.SatistaMi;
            }
        }

        private void cbTum_CheckedChanged(object sender, EventArgs e)
        {
            UrunleriYukle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;

            Urun seciliUrun = lstUrunler.SelectedItem as Urun;
            var guncellenecekUrun = new UrunRepo().UrunBul(seciliUrun.Id); // iki methoda da urunbul demişiki string arayana da id arayana da . Id arayanı kullandık. 

            try
            {
                // update i de jenerikle yazalım. 
                // update de ki biraz farklı. Öncelikle ürünü bulman lazım. Sonra aşağıya inip update yazıyorsun biriyorusun. 
                // açıkçası update e jenerik yazmak çok da mantıklı değil çünkü biraz daha uzun oluyor kod. Ama diğer avantajları da çok olduğundan karışıklık olmasın hepsini jenerik yapalım diyoruz. 
                seciliUrun = new ProductRepo().GetByID(seciliUrun.Id); // remdeki o anki instance da ki urunu buldu aktardı buraya. 

                seciliUrun.UrunAdi = txtUrunAdi.Text;
                seciliUrun.Fiyat = nFiyat.Value;
                seciliUrun.SatistaMi = cbSatistaMi.Checked;
                //new UrunRepo().UrunGuncelle(seciliUrun); // bu eski yöntem di. 

                // bu alttakini yazabilmek için getbyıd ile o ürünü bulmuş olmamız lazım. 
                new ProductRepo().Update();
                UrunleriYukle();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;
            Urun seciliUrun = lstUrunler.SelectedItem as Urun;
            try
            {
                //new UrunRepo().UrunSil(seciliUrun);

                new ProductRepo().Delete(seciliUrun); // bu sql den de siler. Biz satıştamısını false yapmasını istiyoruz sadece. Repositorybase den değiştireceğiz delete yi.Override yapıp.
                UrunleriYukle();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
