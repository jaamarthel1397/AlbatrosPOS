using System.Text.Json.Serialization;

namespace AlbatrosPOS.Api.Models
{
    public class Order
    {
        /// <summary>
        /// Represents the order's header.
        /// </summary>
        [JsonPropertyName("header")]
        public OrderHeader Header { get; set; }

        /// <summary>
        /// Represents the order's details.
        /// </summary>
        [JsonPropertyName("details")]
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
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the id of the client.
        /// </summary>
        [JsonPropertyName("clientId")]
        public string ClientId { get; set; } = null!;

        [JsonPropertyName("clientName")]
        public string? ClientName { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the order took place.
        /// </summary>
        [JsonPropertyName("dateTime")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Gets or sets the address id.
        /// </summary>
        [JsonPropertyName("addressId")]
        public string AddressId { get; set; } = null!;

        [JsonPropertyName("addressDescription")]
        public string? AddressDescription { get; set; }
    }

    /// <summary>
    /// Represents a detail of the order.
    /// </summary>
    public class OrderDetail
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the header's id.
        /// </summary>
        [JsonPropertyName("headerId")]
        public string? HeaderId { get; set; }

        /// <summary>
        /// Gets or sets the product's id.
        /// </summary>
        [JsonPropertyName("productId")]
        public string ProductId { get; set; } = null!;

        [JsonPropertyName("productDescription")]
        public string? ProductDescription { get; set; }

        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        [JsonPropertyName("amount")]
        public int Amount { get; set; }
    }
}
