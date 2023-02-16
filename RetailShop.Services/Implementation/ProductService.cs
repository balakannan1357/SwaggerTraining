using AutoMapper;
using RetailShop.Model.ViewModel;
using RetailShop.Repository.Entities;
using RetailShop.Repository.Implementations;
using RetailShop.Repository.Interface;
using RetailShop.Services.Interface;
using System.Diagnostics;
using System.Xml.Linq;

namespace RetailShop.Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public List<ProductViewModel> GetProductDetails()
        {
            var productList = _productRepository.Get();
            List<ProductViewModel> ProductViewModelList = _mapper.Map<List<ProductViewModel>>(productList);
            return ProductViewModelList;
        }
        public ProductViewModel GetProductDetails(Guid id)
        {
            Product Product = _productRepository.Get(id);
            ProductViewModel ProductViewModel = _mapper.Map<ProductViewModel>(Product);
            return ProductViewModel;
        }

        public void PostProduct(ProductViewModel product)
        {
            var ProductNew = _mapper.Map<Product>(product);
            ProductNew.Id = Guid.NewGuid();
            _productRepository.Post(ProductNew);
        }

        public void PutProduct(Guid id, ProductViewModel product)
        {
            var ProductNew = _mapper.Map<Product>(product);
            ProductNew.Id = id;
            _productRepository.Put(ProductNew);
        }
        public void DeleteProduct(Guid id)
        {
            _productRepository.Delete(id);
        }
        
    }
}