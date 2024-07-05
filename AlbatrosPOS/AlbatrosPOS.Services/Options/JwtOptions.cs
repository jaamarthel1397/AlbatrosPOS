namespace AlbatrosPOS.Services.Options
{
    /// <summary>
    /// Represents the configurable JWT Options.
    /// </summary>
    public class JwtOptions
    {
        /// <summary>
        /// Gets or sets the token's issuer.
        /// </summary>
        public string Issuer { get; set; }

        /// <summary>
        /// Gets or sets the token's audience
        /// </summary>
        public string Audience { get; set; }

        /// <summary>
        /// Gets or sets the token's key.
        /// </summary>
        public string Key { get; set; }
    }
}
