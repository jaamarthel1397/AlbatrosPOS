namespace AlbatrosPOS.Api.Models
{
    public class Order
    {
        /// <summary>
        /// Represents the order's header.
        /// </summary>
        public OrderHeader Header { get; set; }

        /// <summary>
        /// Represents the order's details.
        /// </summary>
        public ICollection<OrderDetail> Details { get; set; }
    }

    /// <summary>
    /// Represents the header for an order.
    /// </summary>
    public class OrderHeader
    {
        /// <summary>
        /// Gets or sets the id of the order header.
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the id of the client.
        /// </summary>
        public string ClientId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the date and time when the order took place.
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Gets or sets the address id.
        /// </summary>
        public string AddressId { get; set; } = null!;
    }

    /// <summary>
    /// Represents a detail of the order.
    /// </summary>
    public class OrderDetail
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the header's id.
        /// </summary>
        public string? HeaderId { get; set; }

        /// <summary>
        /// Gets or sets the product's id.
        /// </summary>
        public string ProductId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        public int Amount { get; set; }
    }
}
