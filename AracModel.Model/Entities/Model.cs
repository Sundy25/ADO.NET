using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracModel.Model.Entities
{
    [Table("Modeller")]
 public   class Model
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]

        public string ModelAdi { get; set; }

        public decimal Fiyat { get; set; } = 0;

        public int MarkaId { get; set; }

        public bool SatistaMi { get; set; } = true;

        [ForeignKey("MarkaId")]

        public virtual Marka Marka { get; set; }
    }
}
