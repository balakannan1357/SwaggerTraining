using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShop.Repository.Entities
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }
    }
}
