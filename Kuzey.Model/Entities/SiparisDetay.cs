using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuzey.Model.Entities
{
    [Table("SiparisDetaylari")]
    public class SiparisDetay
    {

        // 
        [Key]  // burada kompozit key açmazsanız mükerrer kayıt açma ihtimaliniz var. MEsela programımızda aynı üründen varsa adedini artırıyor. Buranın sayesinde olur bu. BUnu key ile yapıyoruz. Kompozit yapma budur. Siparis id yi eşsiz yapar. 
        [Column(Order =1)] // sql tablolarında da anahtarlı olan columnlar kompozit keydir. Foreign keyler de tablo geçişlerindeki sonsuz işaretindedir. Primary key de o tablo çizgisinin ucundaki anahtarın olduğu tablodadır. 
        public int SiparisId { get; set; }
        [Key]
        [Column(Order =2)]   // column orderlara sıra vermelisiniz. Bu ikinci keydir. Bunlar foreign key olarak çalışıyor ama biz bunların bir kompozit key olmasını istiyoruz. Alt tarafta UrunId ve SiparisId ye foreign key verilmiştir mesela. Ondan. Bunları siparis olustur class ında kullandığımızda foreign key olarak çalışır. 

        // birden çok kompozit sütun ekleyeceksen id ler gibi, ya da farketmez diğer şeylere de yapabilirsin sırasını column order ile belirliyorsun. 

            // sadece kompozit keyler de böyle bir muhabbet söz konusu. BUnlarda bir sıra ister. Diğerlerinde ise önce hangisini yazdıysan tablona o gelir. 
        public int UrunId { get; set; }

        public decimal UrunFiyati { get; set; }
        public short Adet { get; set; } 

        public double Indirim { get; set; }
        // navigation property leri yazalım. 


        [ForeignKey("UrunId")]
        public virtual Urun Urun {get;set;}

        [ForeignKey("SiparisId")]
        public virtual Siparis Siparis { get; set; }

        public override string ToString()
        {
            return $"{this.Adet} x {this.Urun.UrunAdi} -{this.Adet * this.Urun.Fiyat*Convert.ToDecimal(1-this.Indirim):c2}"; // burada da bir ürün bir den fazla siparişdetayında bulunabilir.
        }
    }
}
