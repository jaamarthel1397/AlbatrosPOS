namespace AlbatrosPOS.App
{
    public static class JwtManager
    {
        private static string token;

        public static string Token
        {
            get { return token; }
            set { token = value;}
        }

        private static string username;

        public static string Username
        {
            get { return username; }
            set { username = value; }
        }
    }
}
