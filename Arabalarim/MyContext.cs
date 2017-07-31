using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// bunu kendimiz elle ekledik. Kalıtım aldıracağız. 03 te aynen böyle bir class vardı biz de öyle yapalım dedik. Bizim normalde böyle bir database miz yok. Adı üstünde code first. 
namespace Arabalarim
{
    public class MyContext:DbContext
    {

        public MyContext()
            : base("name=LocalCon ") // mycon du, şimdi localcon u kullanacağız. App.config in içinden değiştirdik sonra buraya yazdık.
        {

            // sürekli newleyip bağlantı aldığımız class aslınad bu classtır. 
            // base ne işe yarıyordu? Kalıtım alınan class taki constructor un Mycon overload ı çalışıyor. 
        }

      

        public virtual DbSet<Marka> Markalar { get; set; } // hani db.Customers, db.Bla bla yazuyırduk ya. İşte buradan geliyür.

        public virtual DbSet<Model> Modeller { get; set; } // model class ını bağlantı çektik bak bununla. En son yazdığımız geçiş senaryosu üstüne kodlar yazdık. Yani arada fark var. O halde database i güncellemek için migration yapmamız lazım. 

        public virtual DbSet<ModelRenk> ModelRenkler { get; set; } // al yaptığımız modelrenk class ını buraya da böyle bağladık. Şimdi database update yapalım. 

    }
}
