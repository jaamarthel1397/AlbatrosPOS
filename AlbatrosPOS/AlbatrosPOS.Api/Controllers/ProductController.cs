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
        public async Task<IEnumerable<Product>> Get()
        {
            var result = await this.productService.GetAllProducts();

            return result;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<Product?> Get(string id)
        {
            var result = await this.productService.GetProductById(id);

            return result;
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<bool> Post([FromBody] Product product)
        {
            if (product == null)
            {
                return false;
            }

            if (product.Description == null || product.Amount == null)
            {
                return false;
            }

            var result = await this.productService.CreateProduct(product);

            return result;
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public async Task<bool> Put(string id, [FromBody] Product product)
        {
            if (product == null)
            {
                return false;
            }

            if (product.Description == null || product.Amount == null)
            {
                return false;
            }

            var result = await this.productService.UpdateProduct(product);

            return result;
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(string id)
        {
            var result = await this.productService.DeleteProduct(id);

            return result;
        }
    }
}
