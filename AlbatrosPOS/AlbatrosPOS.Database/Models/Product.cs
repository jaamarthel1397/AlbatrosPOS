using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbatrosPOS.Database.Models
{
    /// <summary>
    /// Represents a product for the inventory.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets the id of the product.
        /// </summary>
        public string Id { get; set; } = null!;

        /// <summary>
        /// Gets or sets the description of the product.
        /// </summary>
        public string Description { get; set; } = null!;

        /// <summary>
        /// Gets or sets the amount of units currently available.
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Gets or sets the product's orders.
        /// </summary>
        public ICollection<OrderDetail> Orders { get; set; }
    }
}
