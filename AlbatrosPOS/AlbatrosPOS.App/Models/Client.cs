using System.Text.Json.Serialization;

namespace AlbatrosPOS.App.Models
{
    public class Client
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the client.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets a collection of addresses.
        /// </summary>
        [JsonPropertyName("addresses")]
        public ICollection<Address> Addresses { get; set; }
    }
}
