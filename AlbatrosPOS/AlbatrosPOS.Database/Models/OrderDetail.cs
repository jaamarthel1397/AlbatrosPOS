namespace AlbatrosPOS.Database.Models
{
    /// <summary>
    /// Represents a detail of the order.
    /// </summary>
    public class OrderDetail
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string Id { get; set; } = null!;

        /// <summary>
        /// Gets or sets the header's id.
        /// </summary>
        public string HeaderId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the product's id.
        /// </summary>
        public string ProductId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Gets or sets the header of the detail.
        /// </summary>
        public OrderHeader Header { get; set; } = null!;

        /// <summary>
        /// Gets or sets the product.
        /// </summary>
        public Product Product { get; set; } = null!;
    }
}
