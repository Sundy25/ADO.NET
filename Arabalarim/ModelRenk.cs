using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arabalarim
{

   public class ModelRenk
    {
        [Key]
        [Column(Order = 10)] // genelde on 20 diye sıra verilir. ARaya bir şey yazmak istenir deyü.
        public int ModelID { get; set; }

        [Key]
        [Column(Order=20)]
        public int RenkID { get; set; }

        [Column(TypeName ="smalldatetime")]

        public DateTime EklenmeZamani { get; set; }

        // nav. proerty yazalım şimdi modellerei içine. 

        [ForeignKey("ModelID")]
        public virtual Model Modeller { get; set; }
        
        [ForeignKey("ModelID")]
        public virtual Model Renkler { get; set; } // bura tekil ilişkili. O yüzden list yapmıyoruz. 
    }
}
