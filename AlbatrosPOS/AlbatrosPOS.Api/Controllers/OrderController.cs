using AlbatrosPOS.Database.Models;
using AlbatrosPOS.Services.OrderService;
using AlbatrosPOS.Services.OrderService.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlbatrosPOS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService orderService;
        private readonly ILogger<OrderController> logger;

        public OrderController(IOrderService orderService, ILogger<OrderController> logger)
        {
            this.orderService = orderService;
            this.logger = logger;
        }

        // GET: api/<OrderController>
        [HttpGet]
        public async Task<IEnumerable<OrderHeader>> GetHeaders()
        {
            var result = await this.orderService.GetAllOrderHeaders();

            return result;
        }


        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public async Task<Order> Get(string id)
        {
            var result = await this.orderService.GetOrderById(id);
            return result;
        }

        // POST api/<OrderController>
        [HttpPost]
        public async Task<bool> Post([FromBody] Order order)
        {
            if (order == null)
            {
                return false;
            }

            if (order.Header == null)
            {
                return false;
            }

            var result = await this.orderService.CreateOrder(order);

            return result;
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public async Task<bool> Put(int id, [FromBody] Order order)
        {
            if (order == null)
            {
                return false;
            }

            if (order.Header == null)
            {
                return false;
            }

            var result = await this.orderService.UpdateOrder(order);

            return result;
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(string id)
        {
            var result = await this.orderService.DeleteOrder(id);

            return result;
        }
    }
}
