using Kuzey.BLL;
using Kuzey.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kuzey.UI.Console
{
    // hemmen entityframework ü yükledik. 
    // sonra hemen model i ve bll i referansa ekledik
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                List<Kategori> kategoriler = new KategoriRepo().TumKategorileriGetir();
                // ekrana yazdırmak istiyoruz şimdi bunlar.  
                // ama hata alırız. Çünkü app.config içinde connection stringimiz yok ve biz programı artık buradan çalıştırmak istiyoruz. UI.WFA içindeki şeyleri app.config localcon u buradaki app.config içine kopyalayacağız.

                foreach (Kategori kategori in kategoriler)
                {
                    System.Console.WriteLine($"Kategori Adı:{kategori.KategoriAdi}\n\tAçıklama:{kategori.Aciklama}\n\tÜrün Sayısı: {kategori.Urunler.Count} ");
                    //var urunler = new UrunRepo().KategorininUrunleriniGetir(kategori);
                    // bak bunu farklı yazacağız.

                    var urunler = kategori.Urunler; // ürünleri getirme işini bu şekilde yazarsan program daha hızlı çalışır. Çünkü kategori yi yukarıda zaten çağırdık. Lazy loading burada işimize yaradı. Attı hafızaya, zırt diye kullandık bak. 


                    foreach (Urun urun in urunler)
                    {
                        var durum = urun.SatistaMi ? "Satişta" : "Satişta Değil";

                        System.Console.WriteLine($"\t\tÜrün Adı: {urun.UrunAdi}\n\tFiyat: {urun.Fiyat:0.00}\n\tDurum:{durum}"); // para birimi olan c2 console app ta ? olarak çıkıyor. O yüzden 0.00 yaptık pamps. 
                    }
                    
                }
                Thread.Sleep(1000); // while sokup sürekli sistem yeniemesini açtık. Ürüneklediğimiz zaman yenileyip gösrün diye. // şimdi console ve UI.WFA yi aynı anda çalıştırıyoruz. Birinden eklediğimizi öbür ekranda da görüyorz. 
                System.Console.Clear();
            }
            
            System.Console.Read();
            
        }
    }
}
