using AlbatrosPOS.Database.Models;
using AlbatrosPOS.Services.ProductService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlbatrosPOS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        private readonly ILogger<ProductController> logger;

        public ProductController(IProductService productService, ILogger<ProductController> logger)
        {
            this.productService = productService;
            this.logger = logger;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await this.productService.GetAllProducts();

            List<Models.Product> products = new List<Models.Product>();
            foreach (var product in result)
            {
                products.Add(new Models.Product
                {
                    Id = product.Id,
                    Amount = product.Amount,
                    Description = product.Description,
                });
            }

            return Ok(products);
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var result = await this.productService.GetProductById(id);

            if (result == null)
            {
                BadRequest();
            }

            return Ok(new Models.Product
            {
                Id = result.Id,
                Amount = result.Amount,
                Description = result.Description,
            });
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Models.Product product)
        {
            if (product == null)
            {
                return BadRequest();
            }

            if (product.Description == null || product.Amount == null)
            {
                return BadRequest();
            }

            var result = await this.productService.CreateProduct(new Product
            {
                Id = product.Id,
                Amount = product.Amount,
                Description = product.Description,
            });

            return Ok(result);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] Models.Product product)
        {
            if (product == null)
            {
                return BadRequest();
            }

            if (product.Description == null || product.Amount == null)
            {
                return BadRequest();
            }

            var result = await this.productService.UpdateProduct(new Product
            {
                Id = product.Id,
                Amount = product.Amount,
                Description = product.Description,
            });

            return Ok(result);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var result = await this.productService.DeleteProduct(id);

            if (result == false)
            {
                return Ok();
            }

            return BadRequest();
        }
    }
}
