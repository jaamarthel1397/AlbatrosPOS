using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbatrosPOS.Database.Models
{
    /// <summary>
    /// Represents a client that orders products.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string Id { get; set; } = null!;

        /// <summary>
        /// Gets or sets the name of the client.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets a collection of addresses.
        /// </summary>
        public ICollection<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the client's orders.
        /// </summary>
        public ICollection<OrderHeader> Orders { get; set; }
    }
}
