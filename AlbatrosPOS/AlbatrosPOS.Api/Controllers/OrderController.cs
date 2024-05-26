using AlbatrosPOS.Api.Models;
using AlbatrosPOS.Database.Models;
using AlbatrosPOS.Services.OrderService;
using AlbatrosPOS.Services.OrderService.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlbatrosPOS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
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
        public async Task<IActionResult> GetHeaders()
        {
            var result = await this.orderService.GetAllOrderHeaders();

            return Ok(this.MapDbOrderHeadersToDtoOrderHeaders(result));
        }


        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var result = await this.orderService.GetOrderById(id);

            if (result == null)
            {
                return BadRequest();
            }

            return Ok(this.MapDbOrderToDtoOrder(result));
        }

        // POST api/<OrderController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Models.Order order)
        {
            if (order == null)
            {
                return BadRequest();
            }

            if (order.Header == null)
            {
                return BadRequest();
            }

            var result = await this.orderService.CreateOrder(this.MapDtoOrderToDbOrder(order));

            return Ok(result);
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] Models.Order order)
        {
            if (order == null)
            {
                return BadRequest();
            }

            if (order.Header == null)
            {
                return BadRequest();
            }

            var result = await this.orderService.UpdateOrder(this.MapDtoOrderToDbOrder(order));

            return Ok(result);
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var result = await this.orderService.DeleteOrder(id);

            if (result)
            {
                return Ok();
            }

            return BadRequest();
        }

        private Models.Order MapDbOrderToDtoOrder(Services.OrderService.Data.Order order)
        {
            var result = new Models.Order
            {
                Header = new Models.OrderHeader
                {
                    Id = order.Header.Id,
                    DateTime = order.Header.DateTime,
                    AddressId = order.Header.AddressId,
                    ClientId = order.Header.ClientId,
                },
                Details = this.MapDbOrderDetailToDtoOrderDetail(order.Details),
            };

            return result;
        }

        private Services.OrderService.Data.Order MapDtoOrderToDbOrder(Models.Order order)
        {
            var result = new Services.OrderService.Data.Order
            {
                Header = new Database.Models.OrderHeader
                {
                    Id = order.Header.Id,
                    DateTime = order.Header.DateTime,
                    AddressId = order.Header.AddressId,
                    ClientId = order.Header.ClientId,
                },
                Details = this.MapDtoOrderDetailToDbOrderDetail(order.Details),
            };

            return result;
        }

        private IEnumerable<Models.OrderHeader> MapDbOrderHeadersToDtoOrderHeaders(IEnumerable<Database.Models.OrderHeader> headersCollection)
        {
            List<Models.OrderHeader> headers = new List<Models.OrderHeader>();
            foreach (var header in headersCollection)
            {
                headers.Add(new Models.OrderHeader
                {
                    Id = header.Id,
                    AddressId = header.AddressId,
                    ClientId = header.ClientId,
                    DateTime = header.DateTime,
                    AddressDescription = header.Address.Description,
                    ClientName = header.Client.Name,
                });
            }

            return headers;
        }

        private ICollection<Models.OrderDetail> MapDbOrderDetailToDtoOrderDetail(ICollection<Database.Models.OrderDetail> orderDetailCollection)
        {
            List<Models.OrderDetail> orderDetails = new List<Models.OrderDetail>();
            foreach (var item in orderDetailCollection)
            {
                orderDetails.Add(new Models.OrderDetail
                {
                    Id = item.Id,
                    HeaderId = item.HeaderId,
                    ProductId = item.ProductId,
                    Amount = item.Amount,
                });
            }

            return orderDetails;
        }

        private ICollection<Database.Models.OrderDetail> MapDtoOrderDetailToDbOrderDetail(ICollection<Models.OrderDetail> orderDetailCollection)
        {
            List<Database.Models.OrderDetail> orderDetails = new List<Database.Models.OrderDetail>();
            foreach (var item in orderDetailCollection)
            {
                orderDetails.Add(new Database.Models.OrderDetail
                {
                    Id = item.Id,
                    HeaderId = item.HeaderId,
                    ProductId = item.ProductId,
                    Amount = item.Amount,
                });
            }

            return orderDetails;
        }
    }
}
