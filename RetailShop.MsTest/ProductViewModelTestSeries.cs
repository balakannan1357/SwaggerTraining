using RetailShop.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShop.MsTest
{
    public class ProductViewModelTestSeries
    {
        public ProductViewModel GetByName(String Name)
        { 
            List<ProductViewModel> productList = new List<ProductViewModel>
            {
                new ProductViewModel
                {
                    Name = "Car",
                    Price = 300000,
                    Qty = 6
                },
                new ProductViewModel
                {
                    Name = "Bike",
                    Price = 50000,
                    Qty = 10
                }
            };

            ProductViewModel? product = productList.FirstOrDefault(x => x.Name == Name);
            return product!;
        }
    }
}
