using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShop.Model.ViewModel
{
    public class ProductViewModel
    {
        string? name;
        int qty;
        int price;
        public string? Name { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }

    }
}