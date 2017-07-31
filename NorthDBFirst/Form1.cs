using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthDBFirst
{
    // DB first, önce database yapılır sonra uygulama yapılır. 
    // MOdel first
    // Code first 
    // Hepsinde öncelik kendilerindedir üçünü de göreceğiz. Önce dbfirst. Şimdi entityframework ekleyelim projeye.
    // Tools, nuget package manager- console dan Install- Package EntityFramework yazdık. Ve paket yüklendi.
    // bu paket app.Config içine de bazı kodlar ekler. 
    // entityframework bir ORM  tool dur. 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NorthCon db = new NorthCon(); // al sana database e bağlandı. Bu kadar.
            //MessageBox.Show($"Toplam Kategori Sayısı:{db.Categories.Count()}");
            dataGridView1.DataSource = db.Categories.ToList();

            // şimdi biraz sorgu yazalım. Üst tarafı denemek için yaptık messagebox ı yorum satırı yapalım onu. 
            // ürünlerimi ürün adı fiyat ve stopktaki toplam ürünlerimin fiyatı olacak şeklde raporlayalım.

            //var data = db.Products.ToList();

            // peki biz buna hepsini getirtmek yerine seçim yapabilir miyiz? Elbette. Üstü yoruma alalımç

            List<UrunFiyatListeleViewModel> data = db.Products.Select(x => new UrunFiyatListeleViewModel() //şimdi sorgu işini c# ta nasıl yapacağız?  her şeyin bir nesnesi olması gerekir. birinci seçenek class eklersin. ... Ekledik UrunfiyatListeleviewmode class ı mızı. bu satırın başındaki list kısmını komple silip var da diyebilirdik.
            {
                Fiyat = x.UnitPrice,
                Stok = x.UnitsInStock,
                UrunAdi = x.ProductName,
                ToplamFiyat = x.UnitPrice * x.UnitsInStock
                // bak bu şekil bir urunfiyatlisteleviewmodel class ı açtık. İçine fiyat stok vs tanımladık. Cart diye bir satırda sorguya attık. Bu şekilde tablomuza sadece fiyat stok ürünadı toplam fiyat vs gelecek. 

                // bu sql deki select sorgusunun c# taki halidir. 
                // c# ta adamlar en son selecti yazmışlar. 

            }).ToList();
            dataGridView1.DataSource = data;

            // unitprice ı 30 dan küçüklerin sorgusunu da ekleyelim. Sıralı bir şekilde. fiyatlar azalan, isim artan. 
            var sorgu = db.Products.Where(x => x.UnitPrice < 30).OrderByDescending(x => x.UnitPrice).ThenBy(x => x.ProductName).ToList();
            // orderby ın default u asc dir. 


            // en pahalı 5 ürünümüzümüzü bulalım...

            sorgu = db.Products.OrderByDescending(x => x.UnitPrice).Take(5).ToList(); // bunlar böyle satır satır seçerek çalıştırıyoruz, aynı sql de olduğu gibi. 

            // çalışanlarımı ad, soyad, yaş kolonları ile listeleyin ve büyükten küçüğe sıralayın. 
            // gittik northEntity.edmx i açtık. Update Model From database dedik. Ve employee yi ekledik tablo olarak. Çünkü bize çalışanlar lazım. 
            // önce bir çalışanları listeleyelim

            var sorgu1 = db.Employees

               .Where(x => x.City == "London") // bu where yi anonim tipten önce yazdık, çünkü anınim tipten sonra yazınca sadece ad soyad yaş ile muhatap olabiliyorsunuz. O yüzden başa koyduk. 

                .Select(x => new
                {

                    Ad = x.FirstName,
                    Soyad = x.LastName,
                    Yas = DateTime.Now.Year - x.BirthDate.Value.Year // burada birthdate.year arasına bir value koyduk. Nesneler null mı değil mi buna göre iş yapmak lazım. Hasvalue ve value tipinde jenerik nesneler tanımlanmış. Birthdate de bir değer vardır, bunun year ını getir demek bu. 

                    // biz artık select melect take vs. ne varsa bu oluşturacağımız anonim nesneler üstünden çekeceğiz. Sanki bir nesne varmış biz bunun içini doldurmuşuz ve yaşa göre sıralıyormuşuz gibi oluyor. 

                }).Where(x => x.Yas < 60) // 60 yaşından küçükler gelsin. 

            .OrderBy(x => x.Yas).ToList(); // bak şimdi anonim bir tip yapacağız. 

            //dataGridView1.DataSource = sorgu1;  // -----> bununla üstteki sorguları çalıştırıyorduk ama yorum yapalım şimdilik. 

            //dataGridView1.DataSource = sorgu; // bununla da. 

            // sorgular da böyle takılınıyor. 

            // bunu yapınca category kolonu class adı olara kyazıyor. System.Data.Entity falan filan. Yani string olarak atıyor. Bunu nasıl düzeltiyorduk? 
            // gidip category class ında override ediyorduk categoryname i.
            //***** Ama unutulmamalıdır ki, projeyi her kayıt ettiğinde entityframework kendinin orjinal halini geri yükler.Yani orada bir override yapmak ya da yorum yapmanın bir anlamı yok. 
            // ama onun da değişikliklerin yok olmadığı halini göreceğiz kank sıkıntı yok. 


            //TABİ DOĞRU OLAN BÖYLE ANONİM TİP AÇMAMAK, HER YAPACAĞIMIZ SORGU İÇİN BİR CLASS AÇMAK VE SORGULARIMIZI ONUN ÜZERİNDEN YAPMAKTIR. 



            // Hadi iki tane sorumuz var 
            // ----------------------------------------------------------------------------------


            // ürünlerinim adları stok miktarları fiyatları ve fiyatlara %18 kdv eklenmiş hallerini raporlayınız. 

            //var sorgu2 = db.Products.Select(x => new 
            //{

            //    UrunAdi = x.ProductName,
            //    Stok = x.UnitsInStock,
            //    Fiyat = x.UnitPrice,
            //    KDVLi=(x.UnitPrice*1.18m)

            //}).ToList();
            //dataGridView1.DataSource = sorgu2;

            // şimdi anonim tip yaptık ama bunu normal class a çevirebilir miyiz? Çevirebiliriz. Aynı yukarıdaki UrunFiyatListeleViewModel de olduğu gibi class açıp aşağıdaki değişkenleri tanımla.
            // ama bunu yapmadık, derste bir sıkıntı çıktı bizde.

            var sorgu2 = db.Products.Select(x => new
            {

                UrunAdi = x.ProductName,
                Stok = x.UnitsInStock,
                Fiyat = x.UnitPrice,
                KDVLi = (x.UnitPrice * 1.18m)

            }).ToList();
            dataGridView1.DataSource = sorgu2;


            // --n.davalio@northwind. -- a.fuller@norhwind.com adı soyadını bu şekilde mail yaparak gösteren bir liste yapınız. 


            var sorgu3 = db.Employees.Select(x => new
            {
                Ad = x.FirstName,
                Soyad = x.LastName,
                Mail = (x.FirstName.Substring(0, 1) + "." + x.LastName + "@northwind.com".ToLower())

            }).ToList();

            //dataGridView1.DataSource = sorgu3;

            // 1993 yılı ve sonrasında işe aldığım çalışanlar ? 

            var sorgu4 = db.Employees.Select(x => new
            {
                Ad = x.FirstName,
                Soyad = x.LastName,
                IseAlimTarihi = x.HireDate
            }).Where(x => x.IseAlimTarihi.Value.Year >= 1993).OrderBy(x => x.Ad).ToList();

            dataGridView1.DataSource = sorgu4;

            var sorgualternatif = db.Employees.Where(x => x.HireDate.Value.Year >= 1993).ToList();
            // böyle de olur. 

            // Mart ayında alınmış siparişlerim? 


            // bunun için order ı eklememiz gerek tablo olarak northEntity e 

            var sorgu5 = db.Orders.Where(x => x.OrderDate.Value.Month == 3).ToList();


            dataGridView1.DataSource = sorgu5;


            // Ürünlerim arasında stok miktari 20 ile 50 arasında olan ürünlerimin listesini raporlayınız. 

            var sorgu6 = db.Products
                .Where(x => x.UnitsInStock.HasValue && (x.UnitsInStock.Value > 20 || x.UnitsInStock < 50))
                .OrderBy(x => x.UnitsInStock)
                .ToList();

            dataGridView1.DataSource = sorgu6;


            // Yaşı 55 den büyük, ingilterede oturmayan çalışanların adlarını ve yaşlarını getirin.

            var sorgu7 = db.Employees.Where(x => x.Country != "UK").Select(x => new
            {
                AdSoyad = x.FirstName.Substring(1, 0) + "." + x.LastName,
                Yas = DateTime.Now.Year - x.BirthDate.Value.Year,
                Ikamet = x.Country


            }).Where(x => x.Yas >= 55).ToList();

            dataGridView1.DataSource = sorgu7;

            // Henüz ulaşmamış siparişler.

            var sorgu8 = db.Orders.Where(x => !x.ShippedDate.HasValue).ToList();

            // DUMON  ya da ALFKI müşterileri tarafından alınmış 1 nolu personelin onayladığı siparişler.

            var sorgu9 = db.Orders
                .Where(x => (x.CustomerID == "DUMON" || x.CustomerID == "ALFKI") &&
                x.EmployeeID == 1 &&
                x.ShipVia == 3 && string.IsNullOrEmpty(x.ShipRegion)

                ).ToList();

            dataGridView1.DataSource = sorgu9;

            // çalışanları ad, soyad, yaş, kolonları ile listeleyin ve büyükten küçüğe sıralayın. 

            // lambda Expression suz yazalım bir de.


            var sorgu10 = from emp in db.Employees
                          select new
                          {
                              ID = emp.EmployeeID,
                              Ad = emp.FirstName,
                              Soyad = emp.LastName,
                              Yas = DateTime.Now.Year - emp.BirthDate.Value.Year
                          };
            dataGridView1.DataSource = sorgu10.ToList();

            // bazı durumlarda lambda expression ile yazmak çok zor olacak. Join ler vs hep bununla yapacağız. Bu LINQ tir. 
            // üsttekiler lambda expression kullanarak LINQ tir. ARtık bu formata geçeceğiz biraz çünkü işler karışacak biraz. 



            // 1993 yılı ve sonrasında işe aldığım çalışanlar

            var sorgu11 = from emp in db.Employees
                          where emp.HireDate.Value.Year >= 1993
                          select emp; // bu demek ki bütün kolonları istiyoruz demektir. Yok spesifik şeyler istiyorsak select kısmını açarsın. 

            dataGridView1.DataSource = sorgu11.ToList();


            // Adı C ile başlayan ürünler
            // burada like ı kullanmayı öğrenmemiz gerekecek. 

            var sorgu12 = db.Products.Where(x => x.ProductName.Substring(0, 1).ToLower() == "c");
            // bunu şöyle de yazabiliriz. 
            var sorgu12f = db.Products.Where(x => x.ProductName.StartsWith("C")).ToList();
            dataGridView1.DataSource = sorgu12.ToList();

            var sorgu12Linq = from pro in db.Products
                              where pro.ProductName.Substring(0, 1).ToLower() == "C"
                              select pro;

            dataGridView1.DataSource = sorgu12Linq.ToList();


            // Adının içinde A geçen ürünler

            var sorgu13 = db.Products.Where(x => x.ProductName.Contains("A"));
            dataGridView1.DataSource = sorgu13.ToList();

            var sorgu13Linq = from pro in db.Products
                              where pro.ProductName.Contains("A")
                              select pro;

            dataGridView1.DataSource = sorgu13Linq.ToList();

            // 1997 yılından sonra alınmış kaç adet sipariş vardır? 

            var sorgu14 = db.Orders.Count(x => x.OrderDate.Value.Year >= 1997); // where yerine count u direk yazıp saydırabilirsin.
            lblSonuc.Text = sorgu14.ToString();

            var sorgu14linq = from order in db.Orders
                              where order.OrderDate.Value.Year >= 1997
                              select order;
            dataGridView1.DataSource = sorgu14linq.ToList();

            // kaç ülkeden müşterimiz bulunmaktadır? 
            // customer tablosunu ekle önce
            var sorgu15 = db.Customers.GroupBy(x => x.Country).ToList(); // count burada yemedi bu yüzden groupby yaptık.
            dataGridView1.DataSource = sorgu15;
            lblSonuc.Text = sorgu15.Count.ToString();

            // ürünleri ürünadı, kategoriadı, fiyat olarak listeleyin. Fiyata göre asc yapınız.

            var sorgu16 = db.Products.Select(x => new UrunKateGoriListeleViewModel  // bak bu class ı direk yazdık ve ctrl+. ya basarak create class in new file dedik direk cart diye kendi oluşturdu class ı projenin içine. Bu kadar basit. 
            {
                UrunAdi = x.ProductName,
                KategoriAdi = x.Category.CategoryName, // navigation property i kullandık. Join yapıp kategorileri katmadan hallettik.
                Fiyat = x.UnitPrice
            }).OrderByDescending(x => x.Fiyat).ToList();

            dataGridView1.DataSource = sorgu16;

            // Federal shipping ile taşınmış ve nancy nin almış olduğu siparişler

            var sorgu17 = db.Orders.Where(x => x.Employee.FirstName == "NANCY" && x.Shipper.CompanyName == "Federal Shipping").ToList();
            dataGridView1.DataSource = sorgu17;

            // company nameleri arasında A harfi geçen müşterilerin vermiş olduğu, nancy andrew ya da janet tarafından alınmış, speedy express ile taşınmamış siparişlere toplam ne kadar kargo ödemesi yapılmıştır? 

            var sorgu18 = db.Orders.Where(x =>
            new string[] { "Nancy", "Andrew", "Janet" }.Contains(x.Employee.FirstName) &&
            x.Shipper.CompanyName != "Speedy Express" &&
            x.Shipper.CompanyName.Contains("A"))
            .ToList();
            // where select foreeach gibi çalışır. Burada string dizisinde employee tablosunda string dizisini aradı. 

            dataGridView1.DataSource = sorgu18;

            lblSonuc.Text = $"Toplam:{sorgu18.Sum(x => x.Freight):c2}\nOrtalama:{ sorgu18.Average(x => x.Freight):c2}";

            db.Configuration.LazyLoadingEnabled = true;



            //lazyLoading tabloların property lerindedir. Orada true seçilidir. False yaparsan ramde durur. Kapatırsan daha hzlı çalışır. 
            // lazyloading i sınavlarda sorarlar. 
            // data ne zaman lazımsa o zaman çalışıyor. Eğer bunu yaparsanız siz istediğiniz zaman veri tabanından çalışıp gelir. 


            // bak şimdi sorgunun bir değişik halini daha göreceğiz. 

            var sorgu19 = db.Database.SqlQuery<string>("select productname from products");

            // Direk sql kodunu içine çaktık.

            //var sorgu20 =
            //    db.Database.SqlQuery<List<t2>>
            //    ("select EmployeeID,Count(0) [Adet] from Orders group by EmployeeID order by [Sipariş adet] desc ");

            var sorgu21 = from siparis in db.Orders
                          group new
                          {
                              siparis
                          } by new
                          {
                              CalisanID = siparis.EmployeeID,
                          } into calisanSiparis
                          select new // burada isteidğimiz şeyi doldurabiliriz.
                          {
                              EmpID = calisanSiparis.Key.CalisanID,
                              Count = calisanSiparis.Count()
                              
                          };

            dataGridView1.DataSource = sorgu21.ToList();



            // eğer aratablonuzda iki tane .... varsa şu aşağı yönde anahtar şeklinde olan şey tablolarda. 
            //  entityframework bunu modellemiyor. O zaman ara tabloyu çizmiyor. Bu iki tabloyu sonsuza sonsuz bağlıyor. Normalde sql de bunu göremezsiniz. 

            // durum iki, eğer ekstra alanlar varsa bunu direk sql deki gibi yapıyor. 

            // ara tabloya bir hiç olmayan tablo ekleyebiliriz. Aratablolar navigation properties dir. 





            // hangi siparişe ne kadar ödenmiş? 
            var detaylar = db.Order_Details.ToList(); // önce bunu ram a aldık. Çünkü sonra aşağıda convert to decimal çalışmıyor sonra. 
            var sorgu22 = from siparisdetay in detaylar  // ekstra ekleyeceğimiz tablo yok
                          group new
                          {
                              siparisdetay
                          } by new
                          {
                              SipID = siparisdetay.OrderID

                          } into sdetay
                          select new
                          {
                              SiparisID = sdetay.Key.SipID,
                              Toplam = sdetay.Sum(x => x.siparisdetay.UnitPrice * x.siparisdetay.Quantity * (1 - Convert.ToDecimal(x.siparisdetay.Discount)))

                          };

            dataGridView1.DataSource = sorgu22.ToList();

            // hangi üründen toplam kaç adet alınmıştır? 

            var sorgu24 = from urunler in db.Products
                          join sdetay in db.Order_Details on urunler.ProductID equals sdetay.ProductID
                          group new
                          {
                              urunler
                          } by new

                          {
                              urunler.ProductName
                          } into urungrup
                          
                          select new
                          {
                              UrunAdi = urungrup.Key.ProductName,
                              Adet= urungrup.Count()
                          };
            
            dataGridView1.DataSource = sorgu24.OrderByDescending(x=>x.Adet).ToList();

            // b toplamda 1000 in üzerinde sipariş edilmiş ürünler. 

            // 10 dan fazla sipariş veren müşteriler ve siparişleri 

            var sorgu25 = from siparisler in db.Orders
                          join musteriler in db.Customers on siparisler.CustomerID equals musteriler.CustomerID
                          group new
                          {
                              musteriler,
                          } by new
                          {
                              CompanyName = musteriler.CompanyName // o tabloda hangi kolonun olması gerektiği

                          } into firmagrup
                          // bu sorguda where yok.
                          select new
                          {

                              CompanyName = firmagrup.Key.CompanyName,
                              Total = firmagrup.Count()
                          }; // 

            int sayfa = 5;
            int bulunduguSayfa = 1;

            dataGridView1.DataSource = sorgu25.Where(x => x.Total > 10).OrderByDescending(x => x.Total).Skip((bulunduguSayfa-1)*sayfa).Take(sayfa).ToList(); // ilk on da olan sonuçları getirdi sıralayarak.  // sayfalamada skip ve take olayını çok görürüz. 

            // hep mantık budur, bulunduğu sayfa-1 * sayfa-- sayfa bir sayfada kaç tane olacağını gösterir.
            // bulunduğu sayfa klasik. web uygulamalarında çok yapacağız bunu. 
            // skip 10 da on tane atla demek. Yani burada 10 ile 20 arasını alır. 

            // tüm sorguları da buraya attık. Bunu da yapabilirsin. bunu direk sql kodunun içnie de atabilirsin. 


            // 1996 yılında hangi kategoriden ne kadarlık sipariş geçişmiş.

            var sdetay1 = db.Order_Details.ToList(); // aggaregate fonksiyonu select yapacağız. Bunu to list e çevirmeden yazmaya çalışınca sıkıntı çıkarıyordu. Order details olan yerlere sdetay yazacağız aşağıya

            var sorgu26 = from siparisdetay in sdetay1
                          join urunler in db.Products on siparisdetay.ProductID equals urunler.ProductID
                          join kategoriler in db.Categories on urunler.CategoryID equals kategoriler.CategoryID
                          join siparisler in db.Orders on siparisdetay.OrderID equals siparisler.OrderID

                          where siparisler.OrderDate.Value.Year == 1996 && siparisler.ShippedDate != null
                          // şimdi joinler bittiğine göre group by order by vs yazarı.

                          orderby siparisler.OrderDate descending
                          group new
                          {
                              kategoriler,
                              urunler,   // kategoriler den  urunlerden ve siparisdetaydan bir şeyi group by yapacağız
                              siparisdetay
                          } by new
                          {
                              cname = kategoriler.CategoryName,
                              urunad = urunler.ProductName
                          } into kategoriurungrup // bunu da yazarak group by ımız hazır. 
                          select new
                          {

                              KategoriAdi = kategoriurungrup.Key.cname,
                              UrunAdi = kategoriurungrup.Key.urunad,
                              Toplam = kategoriurungrup.Sum(x => x.siparisdetay.UnitPrice * x.siparisdetay.Quantity * Convert.ToDecimal(1 - x.siparisdetay.Discount))
                          };

            dataGridView1.DataSource = sorgu26.ToList();
            // ODEV 101 LİNQ ÖRNEĞİNE BAKALIM. 
        }
    }
}
