using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuzey.Model.Entities
{
    [Table("Urunler")]
  public  class Urun
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]

        public string UrunAdi { get; set; }

        public decimal Fiyat { get; set; } = 0;

        public int KategoriId { get; set; }

        public bool SatistaMi { get; set; } = true;

        [ForeignKey("KategoriId")]

        public virtual Kategori Kategori { get; set; } // bu neydi? ilişki kurmaydı. KategoriID ile şey yapmaktı. Bir şey. böyle yımış yımış. 

        public virtual List<SiparisDetay> SiparisDetaylari { get; set; } = new List<SiparisDetay>(); // bu ilişki sayesinde çok ilişki kuruldu. 
    }
}
