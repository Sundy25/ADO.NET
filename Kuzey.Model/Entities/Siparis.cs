using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuzey.Model.Entities
{

    // Şimdi çoka çok ilişki yapalım kank., bununla birlikte bir tablo daha açacağız sonra bunları çokaçok bağlayacağız. 
    [Table("Siparisler")]
  public  class Siparis
    {
        [Key]

        public int Id { get; set; }
        public DateTime SiparisTarihi { get; set; } = DateTime.Now;
        public DateTime IstenenTarih { get; set; } // soru işareti koyduğumuzda, null yazamayız demek bu. Yazmazsak nullable olur. 

        public decimal Navlun { get; set; } = 0;
        [Required]
        [MaxLength(250)]
        public string Adres { get; set; }

        public virtual List<SiparisDetay> SiparisDetaylari { get; set; } = new List<SiparisDetay>(); // navigation property imiz ile bir siparişte birden çok detay olduğu ilişkisini kurduk
        
    }
}
