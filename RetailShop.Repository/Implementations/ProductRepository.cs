using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetailShop.Repository.Entities;
using RetailShop.Repository.Interface;

namespace RetailShop.Repository.Implementations
{
    public class ProductRepository: IProductRepository
    {
        private readonly AppDbContext _dbContext;
        public ProductRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Product> Get()
        {
            var ProductList = _dbContext.Products.ToList();
            return ProductList;
        }

        public Product Get(Guid id)
        {
            var Product = _dbContext.Products.FirstOrDefault(x => x.Id == id);
            return Product;
        }

        public Product Get(string productName)
        {
            var Product = _dbContext.Products.FirstOrDefault(x => x.Name == productName);
            return Product;
        }
        public void Post(Product product)
        {
            
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var Product = _dbContext.Products.FirstOrDefault(y => y.Id == id);
            _dbContext.Products.Remove(Product);
            _dbContext.SaveChanges();
        }

        public void Put(Product Product)
        {
            
            _dbContext.Products.Update(Product);
            _dbContext.SaveChanges();
        }
    }
}
