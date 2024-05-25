
namespace AlbatrosPOS.Services.ProductService
{
    using AlbatrosPOS.Database.Models;

    /// <summary>
    /// A service that manages the data of the <see cref="Product"/> table.
    /// </summary>
    public interface IProductService
    {
        /// <summary>
        /// Gets the specified product.
        /// </summary>
        /// <param name="id">The id of the product to get.</param>
        /// <returns>An asynchronous task with the result.</returns>
        public Task<Product?> GetProductById(string id);

        /// <summary>
        /// Gets all the available products.
        /// </summary>
        /// <returns>An asynchronous task with the result.</returns>
        public Task<IEnumerable<Product>> GetAllProducts();

        /// <summary>
        /// Creates a new product.
        /// </summary>
        /// <param name="newProduct">The new product to create.</param>
        /// <returns>An asynchonous task with the result of the operation.</returns>
        public Task<bool> CreateProduct(Product newProduct);

        /// <summary>
        /// Modifies an existing product.
        /// </summary>
        /// <param name="product">The product to update.</param>
        /// <returns>An asynchonous task with the result of the operation.</returns>
        public Task<bool> UpdateProduct(Product product);

        /// <summary>
        /// Delets a product.
        /// </summary>
        /// <param name="id">The id of the product to delete.</param>
        /// <returns>An asynchronous task with the result.</returns>
        public Task<bool> DeleteProduct(string id);
    }
}
