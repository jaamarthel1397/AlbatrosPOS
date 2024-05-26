using System.Text.Json.Serialization;

namespace AlbatrosPOS.App.Models
{
    public class Credentials
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
