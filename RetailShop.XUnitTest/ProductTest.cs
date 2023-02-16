using Moq;
using RetailShop.API.Controller;
using RetailShop.Model.ViewModel;
using RetailShop.Services.Interface;

namespace RetailShop.XUnitTest
{
    public class ProductTest
    {
        private readonly Mock<IProductService> _productService;
        public ProductTest()
        {
            _productService = new Mock<IProductService>();
        }
        [Fact]
        public void GetAllProduct()
        {
            //Arrange
            var testData = GetProductViewModels();
            _productService.Setup(k => k.GetProductDetails()).Returns(testData);
            var productController = new ProductController(_productService.Object);
            //Act
            var response =  productController.Get();
            //Assert
            Assert.NotNull(response);
        }

        private List<ProductViewModel> GetProductViewModels()
        {
            return new List<ProductViewModel>
            {
                new ProductViewModel
                {
                    Name = "Car",
                    Price = 300000,
                    Qty = 6
                }
            };
        }
    }
}      