using Kuzey.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuzey.DAL
{
  public  class MyContext:DbContext
    {

        public MyContext()
           : base("name=LocalCon")
        {
            this.Database.CreateIfNotExists();   // burayı çok sonradan kodları  başka bir bilgisayara kopyaladığımız senaryo üzerine oluşturduk. eğer hiç database miz yoksa update-database yapıp migrationları getireceğimize localcon un constructor una yazıyoruz. Bu kodlar bakıyor database var mı diye* eğer yoksa oluşturuyor baştan. Migrationları da çalıştırıyor tabi ki. Çok tatlı bir kod. Çoluğuna çocuğuna kullandırt. 

        }
     

        public virtual DbSet<Kategori> Kategoriler { get; set; }

        public virtual DbSet<Urun> Urunler { get; set; } // Urun.cs yi kuzey model içindeki entities klasörüne koyduktan sonra bunu yazdık. Mycontext e hep akıtıyoruz böyle şeyleri. 
        // 

        // modelimizin entities kısmına Database de bir tablo yapacak ne class varsa burada dbset şeklinde açıyoruz. 
        public virtual DbSet<Siparis> Siparisler { get; set; }

        public virtual DbSet<SiparisDetay> SiparisDetaylari { get; set; }
    }
}
