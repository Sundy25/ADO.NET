using Kuzey.DAL;
using Kuzey.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuzey.BLL
{
  public  class KategoriRepo
    {
        // burada direk database ile muhattap olmuyoruz. Kategori getiren bir method varsa bu onu bilir. Gerisi ile muhattap olmaz. Logic işler yapabiliriz çünkü burada. Kategori getiren bir komut yazalım

        public List<Kategori> TumKategorileriGetir() => new MyContext().Kategoriler.ToList();
        //{
        //    MyContext db = new MyContext();
        //    var kategoriler = db.Kategoriler.ToList();
        //    return kategoriler;

        //    // bak burayı nasıl kısa yazıyoruz. Üst tarafta yazdık geçtik.

        //}

        public void KategoriEkle ( Kategori kategori)
        {
            try
            {
                MyContext db = new MyContext();
                db.Kategoriler.Add(new Kategori()
                {
                    KategoriAdi = kategori.KategoriAdi,
                    Aciklama= kategori.Aciklama
                    
                });
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
              
            }
            
        }

        public void KategoriSil(Kategori kategori)
        {
            try
            {
                MyContext db = new MyContext();
                var silinecek = db.Kategoriler.Find(kategori.Id);
                if (silinecek !=null)
                {
                    db.Kategoriler.Remove(silinecek);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

    }
}
