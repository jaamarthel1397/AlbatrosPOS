namespace AlbatrosPOS.Database.Models
{
    /// <summary>
    /// Represents a user of the application
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        public string Username { get; set; } = null!;

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        public string Password { get; set; } = null!;
    }
}
