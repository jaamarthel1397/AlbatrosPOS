using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbatrosPOS.Database.Models
{
    /// <summary>
    /// Represents a client's address
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Gets or sets the id of the address.
        /// </summary>
        public string Id { get; set; } = null!;

        /// <summary>
        /// Gets or sets the description of the address.
        /// </summary>
        public string Description { get; set; } = null!;

        /// <summary>
        /// Gets or sets the client's id.
        /// </summary>
        public string ClientId { get; set; } = null!;

        /// <summary>
        /// Gets or sets the address's client.
        /// </summary>
        public Client Client { get; set; } = null!;
    }
}
