using AlbatrosPOS.Database.Models;
using AlbatrosPOS.Services.OrderService.Data;

namespace AlbatrosPOS.Services.OrderService
{
    /// <summary>
    /// A service that manages the data of the <see cref="OrderHeader"/> and <see cref="OrderDetail"/> tables.
    /// </summary>
    public interface IOrderService
    {
        /// <summary>
        /// Gets the specified order.
        /// </summary>
        /// <param name="id">The id of the order to get.</param>
        /// <returns>An asynchronous task with the result.</returns>
        public Task<Order?> GetOrderById(string id);

        /// <summary>
        /// Gets all the available orders.
        /// </summary>
        /// <returns>An asynchronous task with the result.</returns>
        public Task<IEnumerable<OrderHeader>> GetAllOrderHeaders();

        /// <summary>
        /// Creates a new order.
        /// </summary>
        /// <param name="order">The new order to create.</param>
        /// <returns>An asynchonous task with the result of the operation.</returns>
        public Task<bool> CreateOrder(Order order);

        /// <summary>
        /// Modifies an existing order.
        /// </summary>
        /// <param name="order">The order to update.</param>
        /// <returns>An asynchonous task with the result of the operation.</returns>
        public Task<bool> UpdateOrder(Order order);

        /// <summary>
        /// Delets a order.
        /// </summary>
        /// <param name="id">The id of the order to delete.</param>
        /// <returns>An asynchronous task with the result.</returns>
        public Task<bool> DeleteOrder(string id);

        /// <summary>
        /// Deletes the specified order detail.
        /// </summary>
        /// <param name="id">The id of the order detail to delete.</param>
        /// <returns>An asynchronous task with the result.</returns>
        public Task<bool> DeleteOrderDetail(string id);
    }
}
