using AlbatrosPOS.Database.Models;

namespace AlbatrosPOS.Services.OrderService.Data
{
    /// <summary>
    /// Represents an order.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Gets or sets the header of the order.
        /// </summary>
        public OrderHeader Header { get; set; } = null!;

        /// <summary>
        /// Gets or sets the details of the order.
        /// </summary>
        public ICollection<OrderDetail> Details { get; set; }
    }
}
