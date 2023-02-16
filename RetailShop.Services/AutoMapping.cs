using AutoMapper;
using RetailShop.Model.ViewModel;
using RetailShop.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShop.Services
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Product, ProductViewModel>().ReverseMap();
            CreateMap<Order, OrderViewModel>().ReverseMap();
        }
    }
}
