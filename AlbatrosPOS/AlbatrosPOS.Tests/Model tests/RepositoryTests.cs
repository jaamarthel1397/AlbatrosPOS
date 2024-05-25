using AlbatrosPOS.Database.Models;
using AlbatrosPOS.Services.ProductService;
using Moq;

namespace AlbatrosPOS.Tests
{
    public class RepositoryTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task ProductRepositoryGetsASpecificProduct()
        {
            var mockProductService = new Mock<IProductService>();
            var expected = new Product
            {
                Id = "123",
                Description = "A product",
                Amount = 5,
            };

            Task<Product?> task = Task.FromResult(expected)!;

            mockProductService.Setup(x => x.GetProductById("123")).Returns(task);

            var productRepositoryConsumer = new ProductRepositoryConsumer(mockProductService.Object);

            var result = await productRepositoryConsumer.GetById("123");

            Assert.That(result, Is.EqualTo(expected));

        }

        [Test]
        public async Task ProductRepositoryGetsAllTheAvailableProducts()
        {
            var mockProductService = new Mock<IProductService>();
            List<Product> expected =
            [
                new Product { Id = "1", Description = "Product 1", Amount = 9 },
                new Product { Id = "2", Description = "Product 2", Amount = 14 },
                new Product { Id = "3", Description = "Product 3", Amount = 2 },
            ];

            Task<IEnumerable<Product>> task = Task.FromResult(expected.AsEnumerable())!;

            mockProductService.Setup(x => x.GetAllProducts()).Returns(task);

            var productRepositoryConsumer = new ProductRepositoryConsumer(mockProductService.Object);

            var result = await productRepositoryConsumer.GetAllProducts();

            Assert.That(result, Is.EqualTo(expected));
        }

        private class ProductRepositoryConsumer
        {
            private readonly IProductService productService;

            public ProductRepositoryConsumer(IProductService productService)
            {
                this.productService = productService;
            }

            public async Task<Product> GetById(string id)
            {
                var result = await this.productService.GetProductById(id);
                return result;
            }

            public async Task<IEnumerable<Product>> GetAllProducts()
            {
                var result = await this.productService.GetAllProducts();
                return result;
            }
        }
    }
}