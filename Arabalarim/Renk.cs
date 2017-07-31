using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arabalarim
{
    [Table("Renkler")]
  public  class Renk
    {
        [Key]
        public int RenkID { get; set; }

        [Required]
        [MaxLength(25)]

        public string RenkAdi { get; set; }

        [Required]
        [MaxLength(10)]

        public string RenkKodu { get; set; }

        public virtual List<ModelRenk> Renkler { get; set; } = new List<ModelRenk>();
    }
}
