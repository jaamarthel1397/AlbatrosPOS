using AlbatrosPOS.App.Models;
using System.Text.Json;
using System.Text;
using AlbatrosPOS.App.Forms;

namespace AlbatrosPOS.App
{
    public partial class Login : Form
    {
        private readonly ApiClient _client;

        public Login(ApiClient apiClient)
        {
            this._client = apiClient;
            InitializeComponent();
        }

        private async void loginBt_Click(object sender, EventArgs e)
        {
            var credentials = new Credentials
            {
                Username = usernameTb.Text,
                Password = passwordTf.Text,
            };

            var content = new StringContent(JsonSerializer.Serialize(credentials),
                Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _client.ExecuteWithoutToken("User/login", HttpMethod.Post, content);
            var responseContent = await response.Content.ReadAsStreamAsync();

            var authenticateResponse = JsonSerializer.Deserialize<AuthenticateResponse>(responseContent);

            if (authenticateResponse != null)
            {
                if (authenticateResponse.Token != null)
                {
                    JwtManager.Token = authenticateResponse.Token;
                    JwtManager.Username = authenticateResponse.Username;
                    Hide();
                    MainMenu mainMenu = new MainMenu(this._client);
                    mainMenu.Show();
                }
            }
        }

        private void registerBt_Click(object sender, EventArgs e)
        {
            Hide();
            Register register = new Register(_client);
            register.Show();
        }
    }
}
