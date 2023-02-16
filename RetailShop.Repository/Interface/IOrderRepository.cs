using RetailShop.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShop.Repository.Interface
{
    public interface IOrderRepository
    {
        List<Order> Get();
        Order Get(Guid id);
        void Put(Order Order);
        void Post(Order Order);
        void Delete(Guid id);
    }
}
