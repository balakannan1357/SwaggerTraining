using Microsoft.AspNetCore.Mvc;
using RetailShop.Model.ViewModel;
using RetailShop.Services.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RetailShop.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        // GET: api/<OrderController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_orderService.GetOrderDetails());
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(_orderService.GetOrderDetails(id));
        }

        // POST api/<OrderController>
        [HttpPost]
        public void Post(string productName)
        {
            _orderService.PostOrder(productName);
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, OrderViewModel orderViewModel)
        {
            _orderService.PutOrder(id, orderViewModel);
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _orderService.DeleteOrder(id);
        }
    }
}
