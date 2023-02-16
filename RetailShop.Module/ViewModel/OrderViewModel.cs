using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShop.Model.ViewModel
{
    public class OrderViewModel
    {
        Guid productId;
        string? productName;
        int productPrice;
        public Guid ProductId { get; set; }
        public string? ProductName { get; set; }
        public int ProductPrice { get; set; }
    }
}
