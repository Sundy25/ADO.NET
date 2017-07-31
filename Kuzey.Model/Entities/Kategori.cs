using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuzey.Model.Entities
{

    [Table("Kategoriler")]
  public  class Kategori
    {
        private string _kategoriAdi;

        [Key]
        public int Id { get; set; }
        // biraz kural ekleyelim. öncelikle full propert lazım

        [Required]
        [MaxLength(25)]
        public string KategoriAdi

        {

            get
            {
                return _kategoriAdi;
            }

            set
            {
                foreach (char c in value)
                {
                    if (char.IsDigit(c))
                    {
                        throw new Exception("Kategori adında rakam bulunamaz.");
                    }
                }
                _kategoriAdi = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower(); // kategori adını düzenledik. 
            }
        }
        // bunu yazdıktan sonra add-migration desek bir migration senaryosu çıkar mı? Veritabanını etkileyen bir şey var mı? Yok. O zaman migration yapmamıza gerek yok. Burası C# tarafında yapılan bir durum. 
        public string Aciklama { get; set; }

        public DateTime EklenmeZamani { get; set; } = DateTime.Now; // şimdi database değişti. Migration şart. Ama migration yapmadan çalıştıralım bak ne oluyor. Hata verir. Model ile database arasında bir fark var. Veri tabanını yenilemeni söyler
        // önce add migration sonra update database
        // tabi bu değişiklikler kuzey.model in içinde olsa bile migration lar database ile ilgili olduğu için kuzey.dal ın içinde yapacağız. 

        public virtual List<Urun> Urunler { get; set; } = new List<Urun>(); // urunler ile teke çok ilişki kurduk. 


    }
}
