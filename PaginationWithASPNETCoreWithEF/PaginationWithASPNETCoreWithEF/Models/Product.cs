using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaginationWithASPNETCoreWithEF.Models
{
    [Table("Product")]
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        //public decimal UnitPrice { get; set; }
        public bool Discontinued { get; set; }
    }
}
