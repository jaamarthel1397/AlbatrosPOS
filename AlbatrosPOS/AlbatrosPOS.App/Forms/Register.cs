using AlbatrosPOS.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbatrosPOS.App.Forms
{
    public partial class Register : Form
    {
        private readonly ApiClient _client;
        public Register(ApiClient apiClient)
        {
            InitializeComponent();
            _client = apiClient;
        }

        private async void registerBt_Click(object sender, EventArgs e)
        {
            var credentials = new Credentials
            {
                Username = usernameTb.Text,
                Password = passwordTf.Text,
            };

            var content = new StringContent(JsonSerializer.Serialize(credentials),
                Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _client.ExecuteWithoutToken("User/register", HttpMethod.Post, content);
            var responseContent = await response.Content.ReadAsStreamAsync();

            var result = JsonSerializer.Deserialize<bool>(responseContent);

            if (result == true)
            {
                resultTx.Text = "Se ha creado el usuario exitosamente.";
                returnBt.Visible = true;
            }
            else
            {
                resultTx.Text = "No fue posible crear el usuario, vuelva a intentarlo.";
            }
        }

        private void returnBt_Click(object sender, EventArgs e)
        {
            Login login = new Login(_client);
            login.Show();

            Close();
        }
    }
}
