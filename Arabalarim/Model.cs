using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arabalarim
{

    [Table("Modeller")]
 public   class Model
    {
        // yine ne olur ne olmaz key imizi yazalım
        [Key]
        public int ModelID { get; set; }

        [Required]
        [MaxLength(100,ErrorMessage ="En fazla 100 karakter girebilirsiniz")] // bak max leng i böyle de yapabiliriz. 100 karakter den fazla düşerse try catch e yazacağımız hata mesajını buradan çekecek. :) Amk çok güzel yea.
        [Column("AD", TypeName ="varchar")] // kolonun tip adı varchar yaptık. Model adı property si için totalde 3 şartımız oldu. Bunları title şeklinde başa yazıyoruz. 
        // colonun ismi de AD olsun dedik. Bak bu çok tatlı bir kullanım. Başa yazdığımız ismi, typename de tip adını belirler. 
        public string ModelAdi { get; set; }

        public int Yil { get; set; } = 1990; // int c# da notnull bir tiptir. 1990 yazmasakda nutnull dan sıfır gelir. 


        // bunların ilişkisini de kuracağız. Mycontex te tanımlamamamız gerek model class ını

        public double MotorHacmi { get; set;  } // migration yaptıktan sonra bunu ekledik. Unuttuk ekledik diyelim. Tekrar migration yazmamız gerekir. Yaptığın her değişiklikte bu olmalı. Database ye yapacağın her müdahalede. Önce update yaparsın. sonra tekrar migration yazarsın 

        // gel gelelim ilişki kurmaya. Burası biraz sıkıntılı buna iyi konsantre olalım. Bir foreign key e ihtiyacımız var. Bunu hangi class a koyacağız, marka a mı modele mi koyacağız? 

        // buraya koyacağız.

        public int MarkaID { get; set; } // İLİŞKİ OLACAĞI FOREİGN KEY VE NAVİGATİON PROPERTY AYNI İSİMDE OLMALI

        // bundan sorna yazacaklarımız navigationproperty olacak. şimdi bir modelin bir markası mı var çok markası mı? Tek. O zaman buraya tekil ilişki kurmalısın. Virtual ile.


            [ForeignKey("MarkaID")] // üstteki property nin adını aldık buaraya
            // kimi nitelendiriyoruz nav. prop u. MarkaID diye bir property yazdık, sonra bununla ilşkisini foreign key ile kurduk. 
        public virtual Marka Marka { get; set; } // bu şelilde bir nav kurarsak entityframework aradaki ilişkiyi otomatik kurar. Ama bunun otomatik olmasını istemiyoruz. Default bir bağlantı istemiyoruz. İlişki kuracağımız yere bir foreign key lazım. Gidip buraya bir foreign key kuracağız üstüne. // SQL DE BÖYLE BİR KOLON OLMAYACAK. BU İLİŞKİYİ KURACAK

        public virtual List<ModelRenk> Renkler { get; set; } = new List<ModelRenk>(); // çoklu ilişki olduğu için ilişkiyi list ile kurduk. Şimdi renk için de yapalım renk class ına gidip. 
    }
}
