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

namespace AlbatrosPOS.App.Forms.Client
{
    public partial class CreateClient : Form
    {
        private readonly ApiClient _client;
        private List<Address> addresses = new List<Address>();

        public CreateClient(ApiClient client)
        {
            InitializeComponent();
            _client = client;
        }

        private void addAddressBt_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            var value = addressTb.Text.ToString();
            addresses.Add(new Address
            {
                Description = value,
            });
            dataGridView1.DataSource = addresses;
        }

        private async void createBt_Click(object sender, EventArgs e)
        {
            var client = new Models.Client
            {
                Name = nameTb.Text.ToString(),
                Addresses = addresses,
            };

            var content = new StringContent(JsonSerializer.Serialize(client),
                Encoding.UTF8, "application/json");

            HttpResponseMessage createResponse = await _client.Execute($"Client", HttpMethod.Post, content);
            Close();
        }
    }
}
