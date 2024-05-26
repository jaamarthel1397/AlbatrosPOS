using AlbatrosPOS.App.Models;
using System.Text;
using System.Text.Json;

namespace AlbatrosPOS.App.Forms.Client
{
    public partial class UpdateClient : Form
    {
        private readonly ApiClient _client;
        private Models.Client clientModel;
        private List<Address> addresses = new List<Address>();
        public UpdateClient(ApiClient client, Models.Client clientModel)
        {
            _client = client;
            InitializeComponent();
            this.clientModel = clientModel;
        }

        private async void UpdateBt_Click(object sender, EventArgs e)
        {
            var client = new Models.Client
            {
                Id = clientModel.Id,
                Name = nameTb.Text.ToString(),
                Addresses = addresses,
            };

            var content = new StringContent(JsonSerializer.Serialize(client),
                Encoding.UTF8, "application/json");

            HttpResponseMessage createResponse = await _client.Execute($"Client/{clientModel.Id}", HttpMethod.Put, content);
            Close();
        }

        private async void UpdateClient_Load(object sender, EventArgs e)
        {
            HttpResponseMessage clientsResponse = await _client.Execute($"Client/{clientModel.Id}", HttpMethod.Get);
            var clientsContent = await clientsResponse.Content.ReadAsStreamAsync();

            var clients = JsonSerializer.Deserialize<Models.Client>(clientsContent);
            var clientsAddresses = clients.Addresses.ToList();
            addresses = clientsAddresses;

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = addresses;
            dataGridView1.ReadOnly = false;
            nameTb.Text = clientModel.Name;
        }

        private void addAddressBt_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            var value = addressTb.Text.ToString();
            addresses.Add(new Address
            {
                Description = value,
                ClientId = clientModel.Id,
            });
            dataGridView1.DataSource = addresses;
        }
    }
}
