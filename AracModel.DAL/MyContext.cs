using AracModel.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracModel.DAL
{
  public  class MyContext: DbContext
    {
        public MyContext()
            : base("name=LocalCon")
        {

        }

        public virtual DbSet<Marka> Markalar { get; set; }

        public virtual DbSet<Model> Modeller { get; set;  }
    }
}
