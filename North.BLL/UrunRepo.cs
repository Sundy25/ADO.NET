using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using North.DAL;

namespace North.BLL
{

    // buranın referanslarına North.DAL ekledik. NorthDal da northmodel.edmx var. Oradan veri çekip hakkında sorgu method vs yazacağız. 
  public  class UrunRepo
    {
        public List<Product> TumUrunleriGetir()
        {
            NorthwindEntities db = new NorthwindEntities();
            var urunler = db.Products.OrderBy(x => x.ProductName).ToList();
            return urunler;

        }

        public void UrunSil(Product urun)
        {
            NorthwindEntities db = new NorthwindEntities();
            var silinecek = db.Products.Find(urun.ProductID);
            db.Products.Remove(silinecek);
            db.SaveChanges();

        } // şimdi bu methodları nerede kullanacağız UI da. Form a gidelim.
    }
}
