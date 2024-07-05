using System.Text.Json.Serialization;

namespace AlbatrosPOS.App.Models
{
    public class Address
    {
        /// <summary>
        /// Gets or sets the id of the address.
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Gets or sets the description of the address.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; } = null!;

        /// <summary>
        /// Gets or sets the client's id.
        /// </summary>
        [JsonPropertyName("clientId")]
        public string? ClientId { get; set; } = null!;
    }
}
