using RetailShop.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShop.Services.Interface
{
    public interface ICustomerService
    {
        List<ProductViewModel> GetProductDetails();
        ProductViewModel GetProductDetails(Guid id);
        void PostProduct(ProductViewModel product);
        void PutProduct(Guid id, ProductViewModel product);
        void DeleteProduct(Guid id);
    }
}
