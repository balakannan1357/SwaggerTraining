using Microsoft.AspNetCore.Mvc;
using RetailShop.Model.ViewModel;
using RetailShop.Services.Implementation;
using RetailShop.Services.Interface;
using System.Security.Cryptography;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RetailShop.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productService.GetProductDetails());
        }
        
        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(_productService.GetProductDetails(id));
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post(ProductViewModel product)
        {
            _productService.PostProduct(product);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, ProductViewModel product)
        {
            _productService.PutProduct(id, product);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _productService.DeleteProduct(id);
        }
    }
}
