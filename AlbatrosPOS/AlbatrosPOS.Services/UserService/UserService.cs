
using AlbatrosPOS.Database.Models;
using AlbatrosPOS.Database.Repositories;
using AlbatrosPOS.Services.Options;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace AlbatrosPOS.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> userRepository;
        private readonly JwtOptions options;
        private readonly ILogger<UserService> logger;

        public UserService(IRepository<User> userRepository, IOptionsMonitor<JwtOptions> options, ILogger<UserService> logger)
        {
            this.userRepository = userRepository;
            this.options = options.CurrentValue;
            this.logger = logger;
        }

        public async Task<string> Login(string username, string password)
        {
            try
            {
                var hashedPassword = this.HashPassword(password);
                var result = await this.userRepository.FindAsync(username);
                if (result == null)
                {
                    return string.Empty;
                }

                if (result.Password == hashedPassword)
                {
                    return this.CreateJWT(username);
                }

                return string.Empty;
            }
            catch (Exception e)
            {
                this.logger.LogError(e.Message);
                return string.Empty;
            }
        }

        public async Task<bool> Register(string username, string password)
        {
            try
            {
                var hashedPassword = this.HashPassword(password);
                User newUser = new User
                {
                    Username = username,
                    Password = hashedPassword,
                };

                this.userRepository.Create(newUser);
                await this.userRepository.SaveChangesAsync();

                this.logger.LogInformation("User {username} was created successfuly", username);

                return true;
            }
            catch (Exception e)
            {
                this.logger.LogError("An error ocurred while attempting to create the user {username}", username);
                return false;
            }
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        private string CreateJWT(string username)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.options.Key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, username),
            };

            var token = new System.IdentityModel.Tokens.Jwt.JwtSecurityToken(
                issuer: this.options.Issuer,
                audience: this.options.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(60),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
