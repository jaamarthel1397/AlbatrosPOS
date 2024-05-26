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

namespace AlbatrosPOS.App.Forms.Order
{
    public partial class CreateOrder : Form
    {
        private readonly ApiClient _client;
        public OrderDetail[] details;

        public CreateOrder(ApiClient client)
        {
            InitializeComponent();
            _client = client;
        }

        private async void CreateOrder_Load(object sender, EventArgs e)
        {
            HttpResponseMessage clientsResponse = await _client.Execute("Client", HttpMethod.Get);
            var clientsContent = await clientsResponse.Content.ReadAsStreamAsync();

            var clients = JsonSerializer.Deserialize<IEnumerable<Client>>(clientsContent);
            clientsCb.DataSource = clients;
            clientsCb.ValueMember = "Id";
            clientsCb.DisplayMember = "Name";

            HttpResponseMessage productsResponse = await _client.Execute("Product", HttpMethod.Get);
            var productsContent = await productsResponse.Content.ReadAsStreamAsync();

            var products = JsonSerializer.Deserialize<IEnumerable<Product>>(productsContent);
            productCb.DataSource = products;
            productCb.ValueMember = "Id";
            productCb.DisplayMember = "Description";
        }

        private void addProductBt_Click(object sender, EventArgs e)
        {
            this.details.Append(new OrderDetail
            {
                
            })
        }

        private async void getAddressesBt_Click(object sender, EventArgs e)
        {
            HttpResponseMessage clientsAddressesResponse = await _client.Execute($"Client/{clientsCb.SelectedValue.ToString()}", HttpMethod.Get);
            var clientsAddressesContent = await clientsAddressesResponse.Content.ReadAsStreamAsync();

            var client = JsonSerializer.Deserialize<Client>(clientsAddressesContent);
            addressCb.DataSource = client.Addresses;
            addressCb.ValueMember = "Id";
            addressCb.DisplayMember = "Description";
        }
    }
}
