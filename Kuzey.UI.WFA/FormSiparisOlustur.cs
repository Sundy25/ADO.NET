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

namespace Kuzey.UI.WFA
{
    public partial class FormSiparisOlustur : Form
    {
        public FormSiparisOlustur()
        {
            InitializeComponent();
        }

        private void FormSiparisOlustur_Load(object sender, EventArgs e)
        {
            lstUrunler.DataSource = new ProductRepo().GetAll();
            lstUrunler.DisplayMember = "UrunAdi";   // bunu yazmazsan listbox içine ürünler override edilmemiş gibi adres olarak gelir.
            
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            lstUrunler.DataSource = new ProductRepo().ProductSearch(txtArama.Text);
        }

        List<SiparisDetay> sepetUrunler = new List<SiparisDetay>();
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            // sepete eklediğimiz ürünü database e atmayacağız. Çünkü gerek yok. Ne gerek var yani mantıken. Hiç. Hayret bir şey.
            // bir field oluşturalım yukarıya onun içinde tutalım.
            if (lstUrunler.SelectedItem == null) return;

            Urun seciliUrun = lstUrunler.SelectedItem as Urun;
            bool varmi = false;
            foreach (var surunler in sepetUrunler)
            {
                if (seciliUrun.Id == surunler.UrunId)
                    varmi = true;
            }
            if (varmi)
            {
                sepetUrunler.Where(x => x.UrunId == seciliUrun.Id).FirstOrDefault().Adet += Convert.ToInt16(nAdet.Value);
            }
            else
            {
                sepetUrunler.Add(new SiparisDetay()
                {
                    Adet = Convert.ToInt16(nAdet.Value),
                    UrunFiyati = seciliUrun.Fiyat,
                    UrunId = seciliUrun.Id,
                    Indirim = Convert.ToDouble(nIndirim.Value / 100),
                    Urun = seciliUrun
                });
            }
            SepetDoldur();  
        }

        private void SepetDoldur()
        {
            lstSepet.Items.Clear();
            decimal sepetTutari = 0;

            foreach (var item in sepetUrunler)
            {
                lstSepet.Items.Add(item);
                sepetTutari += item.UrunFiyati * item.Adet * Convert.ToDecimal(1 - item.Indirim);
            }
            
            lblTutar.Text = $"{sepetTutari:c2}\nKDV:{sepetTutari * 0.18m:c2}";
            
        }
        private void lstSepet_SizeChanged(object sender, EventArgs e)
        {

        }

        private void btnSiparisiOnayla_Click(object sender, EventArgs e)
        {
            if (sepetUrunler.Count == 0)
            {
                MessageBox.Show("Öncelikle sepete ürün eklemelisiniz!");
                return;
            }
            Siparis yeniSiparis = new Siparis() // instance mizi aldık bak
            {
                Adres = txtAdres.Text,
                IstenenTarih = dtpIstenenTarih.Value,
                Navlun = nKargoFiyat.Value,

            };
            //şimdi insert edelim.

            try
            {
                //new SiparisRepo().Insert(yeniSiparis); // bu şekilde de siparişler tablosuna kayıtlarımızı ekleriz.

                //foreach (var item in sepetUrunler) // hepsini sipariş detay tablomuza ekleyelim
                //{
                //    new SiparisDetayRepo().Insert(new SiparisDetay()
                //    {
                //        SiparisId = yeniSiparis.Id,
                //        UrunId = item.UrunId,
                //        Adet = item.Adet,
                //        Indirim = item.Indirim,
                //        UrunFiyati = item.UrunFiyati

                //    });
                //}

                // burada siparisrepo ( Repository içindeki) içinde yaptığımız transaction u burada tek satırla kullanıp geçtik. alt satırıyazdık üst tarafı yorum satırı yaparak. 

                bool durum = new SiparisRepo().SiparisOlustur(yeniSiparis, sepetUrunler);

                
                if (durum)
                {
                    MessageBox.Show("Siparişiniz oluşmuştur");
                    sepetUrunler = new List<SiparisDetay>();
                    SepetDoldur();
                }
                else
                {
                    MessageBox.Show("Sipariş oluştururken bir hata meydana geldi.");
                }

                //sepetUrunler = new List<SiparisDetay>();
                //SepetDoldur(); // new leyip doldurduk tekrar. Listeyi temizlemek içün
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
