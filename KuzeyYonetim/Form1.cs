using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuzeyYonetim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Yukle()
        {
            cmbKategoriler.DisplayMember = "CategoryName";
            var kategoriler = new NorthwindEntities().Categories.OrderBy(x => x.CategoryName).ToList(); // tostring ezmekle uğraşamayız. çünkü her save edişte gidecek.
            cmbKategoriler.DataSource = kategoriler;
            cmbUrunKategori.DisplayMember = "CategoryName";
            cmbUrunKategori.DataSource = kategoriler;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Yukle(); // load içine yazacağımıza method ile aldık, çünkü bunu sürekli çağıracağız. 
        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstUrunler.DisplayMember = "ProductName";
            // seçilen kategoriye göre doldurmak istiyoruz.

            
            Category seciliKategori = cmbKategoriler.SelectedItem as Category;

            // bu seçili kategorinin şimdi id si kategoriname i vardır. Şimdi onları çekelim.

            NorthwindEntities db = new NorthwindEntities(); // bağlandık.

            var urunler = db.Categories.Find(seciliKategori.CategoryID).Products.OrderBy(x=>x.ProductName).ToList(); // alfabetik sıralı list formatında var elimizde herşey şu an. // şu an bize bu satır categoryid leri verdi.     // find methodunu çalıştırmak için primarykey muhabbetini bilmek zorundasınız. 
            // elimizdeki id lere göre yapıyoruz işlerimizi
            lstUrunler.DataSource = urunler; // çalıştırıp görelim. Kategoriler listeye aktarıldı. 
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product seciliUrun = (Product)lstUrunler.SelectedItem; // elimizde bir seçili ürün olduğunda bir product tipinde liste var şimdi

            txtUrunAdi.Text = seciliUrun.ProductName;
            //   numFiyat.Value = seciliUrun.UnitPrice.HasValue ? seciliUrun.UnitPrice.Value : 0; // hasvalue true falsa veriyor. Yok ise :::: o zman 0 yaz. : işareti else anlamındaydı. tek satırda if else satırıdır bu. 

            // bu satırın aynısını şöyle de yazabiliriz. 

            numFiyat.Value = seciliUrun.UnitPrice ?? 0; // ?? operatörü soltarafında bulunan nesnenin değerinin null olup olmadığına bakar. eğer null değilse sol taraftaki değeri kullanır eğer null ise sağ taraftaki değeri kullanır. 

            cbSatistaMi.Checked = seciliUrun.Discontinued;
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            // kategori ekleyeceğiz, kategori tiinde bir nesne yapalım

            Category yeniKategori = new Category()
            {
                CategoryName = txtKategoriAdi.Text,
                Description = txtAciklama.Text


            };
            using (NorthwindEntities db= new NorthwindEntities()) // veri tabanı işlemleri çok yer kapladığı için using kullandık. Bu parantez içinde çalışır ve sonra dispose edilir. 
            {
                db.Categories.Add(yeniKategori); // sadece ne yaptık context yapısındaki gibi bir ekleme yaptık. Burada da add diyerek ekliyoruz. 

                // şimdi db nin içine yenikategori ekle dediğimizde listeye eklendi. Ama kategori listesinde görünmez, çünkü şu an sadece ram de duruyor. Yukle diyerek yeniden new le diğimiz içinde o yazdığımız silinir. Şimdi bu problemi çözelim. 
                // bu categories array ile database deki array arasında fark var mı? Var ( kategori ekledikten sonra) Bunu şöyle çözüyoruz.

                db.SaveChanges(); // bu kadar basit. Bunu yazmazsan güncel data gelmez. Gelemez. 
                // eklemesi mi gerek ekliyor, silmek gerekirse siler. Ne değişiklik yaptıysan. 
            }
            Yukle(); 
        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            // şimdi seçtiğimizi hem ramden uçuracağız, hem databaseden sileceğiz. Usingimizi yapalım.

            using(NorthwindEntities db= new NorthwindEntities())
            {
                Category silinecekCategory = cmbKategoriler.SelectedItem as Category;
                silinecekCategory = db.Categories.Find(silinecekCategory.CategoryID); // silinecek kategoriyi bulduk. Ramdeki hali. Bu aynı nesneyi remden uçuralım.
                db.Categories.Remove(silinecekCategory);
                // mesela bununla beverages i silemezsiniz. Çünkü ilişkili bir kategori.
                db.SaveChanges();

            }
            Yukle();
        }

        private void btnYeniUrunEkle_Click(object sender, EventArgs e)
        {
            Product yeniProduct = new Product()
            {
                ProductName = txtYeniUrunAdi.Text,
                UnitPrice = numYeniUrunFiyati.Value,
                Discontinued = cbYeniSatistaMi.Checked,
                CategoryID = (cmbUrunKategori.SelectedItem as Category).CategoryID
            };
            // şimdi burada dolduruyoruz ya, burada bir kategori var. kategori navigation property dir. Yeni bir insert yapacağız. Burada kategory varmış gidelim seçelim alalım dersen gider yeni bir kategori ekler. O yüzden böyle yapmıyoruz // bunu anlamadım :) 

            using ( NorthwindEntities db = new NorthwindEntities())
            {
                db.Products.Add(yeniProduct);
                db.SaveChanges();

            }
            Yukle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int urunid = ((Product)lstUrunler.SelectedItem).ProductID;

            try
            {
                NorthwindEntities db = new NorthwindEntities();
                Product guncellenecekProduct = db.Products.Find(urunid);
                guncellenecekProduct.ProductName = txtUrunAdi.Text;
                guncellenecekProduct.UnitPrice = numFiyat.Value;
                guncellenecekProduct.Discontinued = cbSatistaMi.Checked;

                db.SaveChanges(); // Bunu oopta da böyle yapıyoruz. İki tane referans tipli değişken birbirine eşitleniyor. Bunları değiştirdik mi öbür tarafta değişiyor. Savechanges de yaptık mı biter bu iş.
            }
            catch (Exception ex)
            {

                MessageBox.Show("Güncelleme işleminde bir hata oluştu");
            }
            finally
            {
                Yukle();
            }
        }
    }
}
