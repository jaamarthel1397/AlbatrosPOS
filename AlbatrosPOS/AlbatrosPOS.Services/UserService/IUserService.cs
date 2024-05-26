namespace AlbatrosPOS.Services.UserService
{
    public interface IUserService
    {
        public Task<bool> Register(string username, string password);

        public Task<string> Login(string username, string password);
    }
}
