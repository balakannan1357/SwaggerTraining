using RetailShop.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShop.Repository.Interface
{
    public interface IProductRepository
    {
        List<Product> Get();
        Product Get(Guid id);
        Product Get(string productName);
        void Put(Product Product);
        void Post(Product Product);
        void Delete(Guid id);
    }
}
