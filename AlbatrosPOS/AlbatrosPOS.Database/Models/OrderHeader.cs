using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbatrosPOS.Database.Models
{
    /// <summary>
    /// Represents the header for an order.
    /// </summary>
    public class OrderHeader
    {
        /// <summary>
        /// Gets or sets the id of the order header.
        /// </summary>
        public string Id { get; set; } = null!;

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

        /// <summary>
        /// Gets or sets the order's address.
        /// </summary>
        public Address Address { get; set; } = null!;

        /// <summary>
        /// Gets or sets the order's client.
        /// </summary>
        public Client Client { get; set; } = null!;

        /// <summary>
        /// Gets or sets the collection of details.
        /// </summary>
        public ICollection<OrderDetail> Details { get; set; } = null!;
    }
}
