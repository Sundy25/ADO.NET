using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arabalarim
{
    [Table("Markalar")] // bunu yazmaksan markass olarak kaydeder. Böyle sabitliyorsun. Çünkü anadil ingiliççe
    public class Marka // class isimlerini tekil tablo isimlerini çoğul yazardık. 
    {

        [Key]
        public int MarkaID { get; set; } // adı id, MarkaID olan int kolonu anlar ve primary  key yapar. Ama işi şansa bırakmamak için başına key ekleriz. ki primary key versin.

        /*public string MarkaAdi { get; set; } */// eğer böyle bırakırsak nullable char max olur. böyle bırakmak istemiyorsak aşağıdaki gibi yazarız

        [Required] // not null yapmak için bunu yazıyoruz. 
        [MaxLength(50)]
        [Column("MarkaAdi", TypeName = "varchar")] // şimdi alt tarafı istediğimiz tipte yaptı.

        public string MarkaAdi { get; set; }
        public int? KurulusYili { get; set; }/* = 1990;*/ // nullable ve default değeri 1990
        public string Kurucusu { get; set; }
        public string Falani { get; set; }




        // gel gelelim ilişki kurmaya. Burası biraz sıkıntılı buna iyi konsantre olalım.  bir foreign key yapmamız lazım. 

        // şimdi model in ilişkisini yazdık, teke tek idi. Burada durum lasıl olacak? Nav. Prop lar virtual olmalı öncelikle.

        public virtual List<Model> Modeller { get; set; } = new List<Model>(); // çoğul ilişki olduğu zaman list şeklinde açıyoruz ilişkimizi. New leyerek de null reference muhabbetinini önüne geçiyorz. 
    }
}
