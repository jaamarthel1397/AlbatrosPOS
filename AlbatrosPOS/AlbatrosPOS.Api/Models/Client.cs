namespace AlbatrosPOS.Api.Models
{
    public class Client
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the client.
        /// </summary>
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets a collection of addresses.
        /// </summary>
        public ICollection<Address> Addresses { get; set; }
    }
}
