namespace AlbatrosPOS.Api.Models
{
    public class Address
    {
        /// <summary>
        /// Gets or sets the id of the address.
        /// </summary>
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the description of the address.
        /// </summary>
        public string Description { get; set; } = null!;

        /// <summary>
        /// Gets or sets the client's id.
        /// </summary>
        public string? ClientId { get; set; } = null!;
    }
}
