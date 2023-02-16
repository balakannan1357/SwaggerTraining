using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RetailShop.Repository.Entities;
using RetailShop.Repository.Interface;

namespace RetailShop.Repository.Implementations
{
    public class OrderRepository: IOrderRepository
    {
        private readonly AppDbContext _dbContext;
        public OrderRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Order> Get()
        {
            var OrderList = _dbContext.Orders.Include(x => x.Product).ToList();
            return OrderList;
        }

        public Order Get(Guid id)
        {
            var Order = _dbContext.Orders.FirstOrDefault(x => x.Id == id);
            return Order;
        }

        public void Post(Order Order)
        {
            _dbContext.Orders.Add(Order);
            _dbContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var Order = _dbContext.Orders.FirstOrDefault(y => y.Id == id);
            _dbContext.Orders.Remove(Order);
            _dbContext.SaveChanges();
        }

        public void Put(Order Order)
        {
            _dbContext.Orders.Update(Order);
            _dbContext.SaveChanges();
        }
    }
}
