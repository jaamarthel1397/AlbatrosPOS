using AlbatrosPOS.Database.Models;
using AlbatrosPOS.Database.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AlbatrosPOS.Services.ProductService
{
    /// <inheritdoc/>
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> productRepository;
        private readonly ILogger<ProductService> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductService"/> class.
        /// </summary>
        /// <param name="productRepository">The repository for the entity.</param>
        /// <param name="logger">A generic interface for logging.</param>
        public ProductService(IRepository<Product> productRepository, ILogger<ProductService> logger)
        {
            this.productRepository = productRepository;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task<bool> CreateProduct(Product newProduct)
        {
            try
            {
                this.logger.LogInformation("Attempting to create a new product");
                this.productRepository.Create(newProduct);
                await this.productRepository.SaveChangesAsync();
                this.logger.LogInformation("Successfuly created the new product with id {id}", newProduct.Id);
                return true;
            }
            catch (Exception ex)
            {
                this.logger.LogError("An error ocurred while attempting to create the product."+ ex.Message);
                return false;
            }
        }

        /// <inheritdoc/>
        public async Task<bool> DeleteProduct(string id)
        {
            try
            {
                this.logger.LogInformation("Attempting to delete the product with id {id}", id);
                var result = await this.GetProductById(id);
                this.productRepository.Delete(result!);
                await this.productRepository.SaveChangesAsync();
                this.logger.LogInformation("Successfuly deleted the product with id {id}", id);
                return true;
            }
            catch (Exception ex)
            {
                this.logger.LogInformation("An error ocurred while attempting to delete the product with id {id}", id);
                return false;
            }
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            try
            {
                this.logger.LogInformation("Attempting to get all the available products");
                var result = await this.productRepository.All().ToListAsync();
                return result;
            }
            catch (Exception e)
            {
                this.logger.LogInformation("An error ocurred while attempting to get all the available products");
                throw;
            }
        }

        /// <inheritdoc/>
        public async Task<Product?> GetProductById(string id)
        {
            try
            {
                this.logger.LogInformation("Attempting to get the product with id {id}", id);
                var result = await this.productRepository.FindAsync(id);
                return result;
            }
            catch (Exception e)
            {
                this.logger.LogInformation("An error ocurred while attempting to get the product with id {id}", id);
                throw;
            }
        }

        /// <inheritdoc/>
        public async Task<bool> UpdateProduct(Product product)
        {
            try
            {
                this.logger.LogInformation("Attempting to update the product with id {id}", product.Id);
                this.productRepository.Update(product);
                await this.productRepository.SaveChangesAsync();
                this.logger.LogInformation("Successfuly updated the product with id {id}", product.Id);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
