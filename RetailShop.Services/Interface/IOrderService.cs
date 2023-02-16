using RetailShop.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShop.Services.Interface
{
    public interface IOrderService
    {
        List<OrderViewModel> GetOrderDetails();
        OrderViewModel GetOrderDetails(Guid id);
        void PostOrder(string productName);
        void PutOrder(Guid id, OrderViewModel order);
        void DeleteOrder(Guid id);
    }
}
