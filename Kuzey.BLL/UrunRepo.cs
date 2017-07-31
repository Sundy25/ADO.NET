using Kuzey.DAL;
using Kuzey.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuzey.BLL
{
    public class UrunRepo
    {
        public List<Urun> TumUrunleriGetir()
        {
            return new MyContext().Urunler.ToList();

        }
        public List<Urun> TumAktifUrunleriGetir()
        {
            return new MyContext().Urunler.Where(x => x.SatistaMi == true).ToList(); // == true kısmını siledebilirdik. 

        }

        public void UrunEkle(Urun urun)
        {
            MyContext db = new MyContext();
            try
            {
                db.Urunler.Add(new Urun()
                {
                    UrunAdi = urun.UrunAdi,
                    Fiyat = urun.Fiyat,
                    KategoriId = urun.KategoriId,
                    SatistaMi = urun.SatistaMi

                });
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void UrunSil(Urun urun)
        {
            MyContext db = new MyContext();
            try
            {
                var silinecek = db.Urunler.Find(urun.Id);
                if (silinecek != null)
                {
                    silinecek.SatistaMi = false;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void UrunGuncelle(Urun urun)
        {
            MyContext db = new MyContext();
            try
            {
                var guncellenecek = db.Urunler.Find(urun.Id);
                if (guncellenecek != null) return;
                guncellenecek.SatistaMi = urun.SatistaMi;
                guncellenecek.KategoriId = urun.KategoriId;
                guncellenecek.Fiyat = urun.Fiyat;
                guncellenecek.UrunAdi = urun.UrunAdi;
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Urun UrunBul(int id) // id ye göre bulur ürünü
        {

            MyContext db = new MyContext();
            try
            {
                return db.Urunler.Find(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    

        public List<Urun> UrunBul(string arama) // bir de stringe göre bulalım dedik. 
        {
            string aranacak = arama.ToLower();
            MyContext db = new MyContext();
            try
            {
                return  db.Urunler.Where(x => x.UrunAdi.ToLower().Contains(aranacak) || x.Kategori.KategoriAdi.ToLower().Contains(aranacak)).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Urun> KategorininUrunleriniGetir(Kategori kategori)
        {
            Kategori kat = new  MyContext().Kategoriler.Find(kategori.Id);
            // bak bunu falan da alayını tüm methodları formurun de kullanacağız biraz biraz. 
            if (kat!=null)
            {
                return kat.Urunler;
            }

            return new List<Urun>();
        }
        // bulamazsada kategori de bir şey hata vermesin diye if else koyduk. 


    }
}
