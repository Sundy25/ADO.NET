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

//        DAL- Data Access layer - veri erişim katmanı.SQL olabilir, Servis olabilir, xml ya da json data olabilir.Yada bunların bir kaçı veya hepsi olabilir. 
//O zaman kaç bağlantı olduğu sayısı* Dal.Şimdilik bir veri erişim katmanı olacak. İstediğimiz srguları bize getirmektir görevi.Veri erişimini
//görecek olan nesnedir.

//BLL- BUsiness Logic layer - İş mantık katmanı.Select, insert delete nasıl yapılır vs genel olarak veri erişim kurallarımızı burada yazarız. 
//Örn.tüm ürünleri listeleyen methodun BLL içinde yazılmış olması gerekmektedir.

//UI-  wfa, uapp, mvc, html, webform, consol, xamarin, api, wcf visual içinde ne yazabiliyorsak o olabilir.
//Kaç sunum katmanınız varsa o kadar UI ımız olur.

//Model veya Poco veya ntt - Poco class Nav. prop vs yazdığımız veri tabanı ilişkilendirme sınıflarıdır.


//DAL,BLL ve Poco nun olacağı projeler class librarydir. 

//şimdi kim kimden referans alıyor? 

//-DAL da model katmanı referans olarak almalıyız.

//-Dal da veriye erişim olacak.Dal verinin tipini poco dan görecek.

//- BLL hem poco yu hem DAL ı görmeli. BLL bunu görmezse, içine yazılacak kurallar çalıştırılacağı yeri göremez. Dal ne kadar çoksa bll den o kadar
//katmana gitmemiz lazım


//Şimdi DB first ile bunu bir uygulayalım

//---DB First te model katmanı yazamıyoruz. O yüzden pocu yok.
//--UI poco ve BLL i görmesi lazım.UI katmanları DAL ı göremez.UI DAL ı güvenlik açısından göremez. 
//--DAL ve BLL Class Lib olur. 
//--UI lar formapp olur. 
//BLL deki tüm public nesnelere erişebiliriz böylece.

//--BLL DAL ı görecek.Onun da referanslarına ekliyoruz.

//UI.da form a referanslarına BLL yi ekleriz.

//-- şimdi DAL da dbfirst yapacağız.Hepsine entity ekleyelim.


    //----------------------------------------------------------
    // 1- Hepsinin referansına model eklenir. 
    // 2- Modele bir şey eklenmez.
    // 3 - BLL e DAL eklenir. 
    // 4 - UI a BLL eklenir. 

    // sonra bu 4 üne tek tek paketler yüklenir. 

namespace Kuzey.UI.WFA
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstKategoriler.DisplayMember = "KategoriAdi";
            lstKategoriler.DataSource = new KategoriRepo().TumKategorileriGetir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                //new KategoriRepo().KategoriEkle(new Kategori()
                //{
                //    KategoriAdi = txtKategoriAdi.Text,
                //    Aciklama = txtAciklama.Text

                //});
                new CategoryRepo().Insert(new Kategori() // bak yukarıdaki yerine jeneriğimiz ile yaptık. Orn, yok kategoriekle yok ürün ekle, vs yerine insert de geç. Ekstradan method olaylarına girme. 
                {
                    KategoriAdi = txtKategoriAdi.Text,
                    Aciklama = txtAciklama.Text

                });

                lstKategoriler.DataSource = new KategoriRepo().TumKategorileriGetir(); // lstbox ı güncellemek için bunu yazıyoruz.
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var silinecek = lstKategoriler.SelectedItem as Kategori;
            try
            {
                if (silinecek!=null)
                    new KategoriRepo().KategoriSil(silinecek);
                lstKategoriler.DataSource = new KategoriRepo().TumKategorileriGetir(); // lstbox ı güncellemek için bunu yazıyoruz.

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private FormUrun urunlerForm;
        private void btnUrunleriGoster_Click(object sender, EventArgs e)
        {
            if (urunlerForm==null||urunlerForm.IsDisposed)
            {
                urunlerForm = new FormUrun();
                urunlerForm.Show();
            }
        }
        FormSiparisler siparisform = new FormSiparisler();
        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            if (siparisform!=null || siparisform.IsDisposed)
            {
                siparisform = new FormSiparisler();
                siparisform.Show();
            }
        }

        private void lstKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
