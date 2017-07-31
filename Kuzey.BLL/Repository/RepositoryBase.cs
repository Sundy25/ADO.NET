using Kuzey.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuzey.BLL.Repository

    // repositorybase ve repository class ı hoca her projesinde kullanırmış. İş katmanında yapılan tüm methodları bunun içinde çözüyor. Herkese de tavsiye etmiş onlar da kullanırmış. 
{
    // bu class ı en son açtık. Depobirimi anlamındadır. 
    // yeni bir kullanım şekli vaadetmiyor. Sadece class lar içindeki methodları tekrar tekrar yazmamanızı sağlar. Bunu kullanırsın. 

        // bakınız repository den veriyi kalıtım alarak değil, jenerik alarak yapacağız. Neden? Verdiğimiz tipe göre değişkenler kendisi otomatik oluşuyor. Örneğin. where ( x = x. yaptığımızda . ya bastığımızda teee gidip oradaki veriyi bulup karşına onu çıkarması jenerikliğin bir özelliğidir. 
    public abstract class RepositoryBase<T,ID> where T:class // T bir class olsun. 

        // buraya yazılacak T tipinin DBSet dipinde olmalı. 
       
       
       // public abstract yaptık ve jenerik yaptık. Neden public abstract yaptık? Base class olduğu için. Tablo tipi ve id kolonları için burada bir jenerik de oluşturduk. Bir şart ta koyduk t için
    {
        protected internal static MyContext dbContext; // ramda de her zaman hazır olsun.Protected internal public bir nesne, UI tarafında da kalıtım alarak kullanabiliriz. AMa kalıtım alırsak context de gelir. Protected internal yaparsak bll içinde kalıtım alınan nesnelerin içinde gelebilir. Öyle her yerden kalıtım alındığında context gelmesin deyü. 

        // şimdi standart 5 tane işlemimiz var. Bunları yapalım.  

        public virtual List<T> GetAll()// yani eğer ürünler tablosunda çalıştıysak ürünler.getall deyince alayı gelecek. 
        {
            dbContext = new MyContext();
            /* return dbContext.Urunler.ToList();*/ // şimdi bunun da jenerik olması lazım. Yukarıya T dediysek bu da T olmalı. Set metodu içine vermiş olduğunuz tipin tablosunu döndürür. 

            return dbContext.Set<T>().ToList(); // id verirsen de ürünün kendisi gelir. Onu da yazalım.
            
        }
        public virtual T GetByID(ID id) // ne tipinde bir id dönecek. Evladiyelik olsun. // yukarıdaki En başta class isminde tanımladığımız ID tipinde olsun.
        {

            dbContext = new MyContext();
            return dbContext.Set<T>().Find(id);

        }

        public virtual void Insert(T entity)
        {
            // dışarıdan bir insert var. try cartch yapalım

            try
            {

                dbContext = dbContext ?? new MyContext(); // dbcontext null değilse dbcontext i kullan, değilse new le instance al.
                dbContext.Set<T>().Add(entity); // şimdi dbcontext imiz ne tipindeyse o şekilde çağırıp kullanacak. Tutupta yerine kategori ya da ürün diye ayrı ayrı yazmıyoruz. 
                dbContext.SaveChanges();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public virtual void Delete(T entity)
        {
            // dışarıdan bir insert var. try cartch yapalım

            try
            {

                dbContext = dbContext ?? new MyContext(); // dbcontext null değilse dbcontext i kullan, değilse new le instance al.
                dbContext.Set<T>().Remove(entity); // şimdi dbcontext imiz ne tipindeyse o şekilde çağırıp kullanacak. Tutupta yerine kategori ya da ürün diye ayrı ayrı yazmıyoruz. 
                dbContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public virtual void Update()
        {
            try
            {
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        // şimdi kaç nesnemiz varsa yapabileceğimiz işlemler hazır. 2 tane de olabilir 200 tane de olabilir. 

    }
}
