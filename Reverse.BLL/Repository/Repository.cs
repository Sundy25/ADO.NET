using Reverse.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Reverse.BLL.Repository
{
   public class Repository
    {
        public class ProductRepo : RepositoryBase<Product, int> { }
    }
}
