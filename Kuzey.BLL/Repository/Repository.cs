using Kuzey.DAL;
using Kuzey.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuzey.BLL.Repository
{

    // tüm business işemlerini artık buraya yazacağız. 
    public class CategoryRepo : RepositoryBase<Kategori, int> { }
    // mesela buradaki kategori dbset tipinde bir nesnedir. Git yerine dbset tipinde olmayan bir şey yaz hata verir. Neden, çünkü repositorybase dbset tipinde nesneleri tutuyor. 

    public class ProductRepo : RepositoryBase<Urun, int>
    {

        public List<Urun> GetAllByCategory(Kategori kategori)
        {
            dbContext = new MyContext();
            Kategori kat = dbContext.Kategoriler.Find(kategori.Id);
            return kat != null ? kat.Urunler : new List<Urun>();

        }
        public override void Delete(Urun entity) // al burada da delete yi override ettik. Çünkü delete yiçağırdık mı komple sql den siliyordu. // çünkü sadece ürün için böyle bir muhabbet istiyoruz. Kategori için ayrı. Belki başka tablomuz gelir onun için ayrı olur. Nerede ne istiyorsak ona göre ezeriz. 
        {
            dbContext = dbContext ?? new MyContext();
            try
            {
                var silinecek = dbContext.Urunler.Find(entity.Id);
                if (silinecek == null) return;
                silinecek.SatistaMi = false;
                dbContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Urun> ProductSearch(string key)
        {
            return this.GetAll()
                .Where(x => (x.UrunAdi.ToLower().Contains(key.ToLower()) ||
                x.Kategori.KategoriAdi.ToLower().Contains(key.ToLower())) & x.SatistaMi)
                .ToList();

        }

    }
    public class SiparisRepo : RepositoryBase<Siparis, int>
    {
        // şimdi biraz entity transaction yapalım sql de yaptığımız gibi

        public bool SiparisOlustur(Siparis yeniSiparis, List<SiparisDetay> sepet)
        {
            // bak bu alt taraftaki kodu formsiparis oluştur un içinden çektik. Sepeturunler ile yenisiparis patladı, biz de instance alacağımıza gittik namespace nin içinde tanımladık bastık geçtik. 
            using (MyContext db = new MyContext())
            {
                using (var tran = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Siparisler.Add(yeniSiparis);
                        foreach (var item in sepet)
                        {

                            db.SiparisDetaylari.Add(new SiparisDetay()
                            {
                                SiparisId = yeniSiparis.Id,
                                UrunId = item.UrunId,
                                Adet = item.Adet,
                                Indirim = item.Indirim,
                                UrunFiyati = item.UrunFiyati

                            });

                        }
                        db.SaveChanges();
                        tran.Commit();
                        return true; // burada global alanda bir return değerin olmalı her zaman try catch içinde. Ben ne yaptım mal gibi gittim bunu foreeach in içine yazdım haliyle patladı. Şimdi düzelttik. 
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        return false;

                    }

                }

            }

        }
        //    SELECT s.ID, K.Kategoriadi, u.UrunAdi, sd.Adet, sd.UrunFiyati, sd.Indirim, (sd.Adet* sd.Urunfiyati*(1-sd.Indirim)) [Toplam] FROM Urunler u
        //JOIN Kategoriler k ON k.Id=u.KategoriId
        //JOIN siparisdetaylari sd ON sd.UrunId= u.Id
        //JOIN siparisler s ON s.Id= sd.SiparisId

        // bu üstte sql de yazdığımız kod. Bunu c ye uyarlayalım altta
        public List<SiparisRaporuViewModel> SiparisRaporu()
        {

            // sorgu yapıp datagrid de göstermek istedik siparişdetaylarımızı. BUnun için bu listeyi açtık siparisrepo nun içine
            MyContext db = new MyContext();

            var siparisdetaylari = db.SiparisDetaylari;

            var rapor = from urun in db.Urunler
                        join Kategori in db.Kategoriler on urun.KategoriId equals Kategori.Id
                        join siparisdetay in db.SiparisDetaylari on urun.Id equals siparisdetay.UrunId
                        join siparis in db.Siparisler on siparisdetay.UrunId equals siparis.Id


                        select new
                        {
                            // buraya istediğin kadar property ekleyebilirsin.
                            SiparisId = siparis.Id,
                            KategoriAdi = Kategori.KategoriAdi,
                            UrunAdi = urun.UrunAdi,
                            Adet = siparisdetay.Adet,
                            UrunFiyati = siparisdetay.UrunFiyati,
                            Toplam = siparisdetay.UrunFiyati * siparisdetay.Adet,
                            Indirim = (1 - siparisdetay.Indirim)

                        };

            var raporson = rapor.AsEnumerable().Select(x => new SiparisRaporuViewModel
            {
                SiparisId = x.SiparisId,
                Adet = x.Adet,
                UrunAdi = x.UrunAdi,
                UrunFiyati = x.UrunFiyati,
                KategoriAdi = x.KategoriAdi,
                Toplam = x.Toplam * Convert.ToDecimal(x.Indirim)
                // linq decimal convert ile çarpma işlemi yapamadı diye bunu yazdık. 

            });

            // buraya tanımladığımız sonraporu linq decimal e çeviremiyor. Bunun çözümünü hoca ile internetten baktık ve infitimli fiyatı direkt hesaplamaktansa ikiye bölüp hesaplattı.
            return raporson.ToList();

        }

        // bir de sql de yazdığımız öbür sorgu için bir şey yazalım aynı yukarıdaki gibi. 
        public List<KategoriSiparisRaporuViewModel> KategoriyeGoreSiparisRaporu()
        {

            // sorgu yapıp datagrid de göstermek istedik siparişdetaylarımızı. BUnun için bu listeyi açtık siparisrepo nun içine
            MyContext db = new MyContext();



            var rapor = from urun in db.Urunler
                        join Kategori in db.Kategoriler
                        on urun.KategoriId equals Kategori.Id
                        join siparisdetay in db.SiparisDetaylari
                        on urun.Id equals siparisdetay.UrunId
                        join siparis in db.Siparisler
                        on siparisdetay.UrunId equals siparis.Id


                        select new
                        {
                            // buraya istediğin kadar property ekleyebilirsin.
                            SiparisId = siparis.Id,
                            KategoriAdi = Kategori.KategoriAdi,
                            UrunAdi = urun.UrunAdi,
                            Adet = siparisdetay.Adet,
                            UrunFiyati = siparisdetay.UrunFiyati,
                            Toplam = siparisdetay.UrunFiyati * siparisdetay.Adet,
                            Indirim = (1 - siparisdetay.Indirim)

                        };

            var raporson = rapor.AsParallel()
                .GroupBy(x => new { x.SiparisId, x.KategoriAdi })
                .Select(x => new KategoriSiparisRaporuViewModel

                {
                    SiparisId = x.Key.SiparisId,
                    KategoriAdi = x.Key.KategoriAdi,
                    Toplam = x.Sum(y => Convert.ToDecimal(y.Indirim) * y.Toplam)
                    // linq decimal convert ile çarpma işlemi yapamadı diye bunu yazdık. 

                })
                .OrderBy(x => x.SiparisId)
                .ToList();
            return raporson;
        }
        public List<SiparisToplamViewModel> SiparisToplamRaporu()
        {

            // sorgu yapıp datagrid de göstermek istedik siparişdetaylarımızı. BUnun için bu listeyi açtık siparisrepo nun içine
            MyContext db = new MyContext();



            var rapor = from urun in db.Urunler
                        join Kategori in db.Kategoriler
                        on urun.KategoriId equals Kategori.Id
                        join siparisdetay in db.SiparisDetaylari
                        on urun.Id equals siparisdetay.UrunId
                        join siparis in db.Siparisler
                        on siparisdetay.UrunId equals siparis.Id


                        select new
                        {
                            // buraya istediğin kadar property ekleyebilirsin.
                            SiparisId = siparis.Id,
                            KategoriAdi = Kategori.KategoriAdi,
                            UrunAdi = urun.UrunAdi,
                            Adet = siparisdetay.Adet,
                            UrunFiyati = siparisdetay.UrunFiyati,
                            Toplam = siparisdetay.UrunFiyati * siparisdetay.Adet,
                            Indirim = (1 - siparisdetay.Indirim)

                        };

            var raporson = rapor.AsParallel()
                .GroupBy(x => new { x.SiparisId })
                .Select(x => new SiparisToplamViewModel

                {
                    SiparisId = x.Key.SiparisId,
                    Toplam = x.Sum(y => Convert.ToDecimal(y.Indirim) * y.Toplam)
                    // linq decimal convert ile çarpma işlemi yapamadı diye bunu yazdık. 

                })
                .OrderBy(x => x.SiparisId)
                .ToList();

            return raporson;

        }
        public class SiparisDetayRepo : RepositoryBase<SiparisDetay, int>  // !!!!!!!!!!! burada bir ibnelik vardı sor hocaya
                                                                           // burada getbyid nasıl çalışacak Siparisrepo olarak açıp içini manuel dolduruyoruz. Getby lı iki method yazıyoruz vs. Daha kısa bir yolu olmalı ama şimdilik böyle bırakacağız. 
        {

        }
    }
}