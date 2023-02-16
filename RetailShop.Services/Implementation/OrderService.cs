using AutoMapper;
using RetailShop.Model.ViewModel;
using RetailShop.Repository.Entities;
using RetailShop.Repository.Interface;
using RetailShop.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShop.Services.Implementation
{
    public class OrderService: IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public OrderService(IOrderRepository orderRepository, IProductRepository productRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public List<OrderViewModel> GetOrderDetails()
        {
            var OrderList = _orderRepository.Get();
            List<OrderViewModel> OrderViewModelList = _mapper.Map<List<OrderViewModel>>(OrderList);
            return OrderViewModelList;
        }
        public OrderViewModel GetOrderDetails(Guid id)
        {
            var Order = _orderRepository.Get(id);
            OrderViewModel OrderViewModel = _mapper.Map<OrderViewModel>(Order);
            return OrderViewModel;
        }

        public void PostOrder(string productName)
        {
            var product = _productRepository.Get(productName);
            Order orderNew = new();
            orderNew.Id = Guid.NewGuid();
            orderNew.ProductId = product.Id;
            orderNew.Product = product;
            _orderRepository.Post(orderNew);
        }

        public void PutOrder(Guid id, OrderViewModel order)
        {
            var OrderNew = _mapper.Map<Order>(order);
            OrderNew.Id = id;
            _orderRepository.Put(OrderNew);
        }
        public void DeleteOrder(Guid id)
        {
            _orderRepository.Delete(id);
        }
    }
}
