using AlbatrosPOS.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbatrosPOS.App.Forms.Order
{
    public partial class CreateOrder : Form
    {
        private readonly ApiClient _client;
        private List<OrderDetail> details;

        public CreateOrder(ApiClient client)
        {
            InitializeComponent();
            _client = client;
        }

        private async void CreateOrder_Load(object sender, EventArgs e)
        {
            HttpResponseMessage clientsResponse = await _client.Execute("Client", HttpMethod.Get);
            var clientsContent = await clientsResponse.Content.ReadAsStreamAsync();

            var clients = JsonSerializer.Deserialize<IEnumerable<Models.Client>>(clientsContent);
            clientsCb.DataSource = clients;
            clientsCb.ValueMember = "Id";
            clientsCb.DisplayMember = "Name";

            HttpResponseMessage productsResponse = await _client.Execute("Product", HttpMethod.Get);
            var productsContent = await productsResponse.Content.ReadAsStreamAsync();

            var products = JsonSerializer.Deserialize<IEnumerable<Models.Product>>(productsContent);
            productCb.DataSource = products;
            productCb.ValueMember = "Id";
            productCb.DisplayMember = "Description";

            details = new List<OrderDetail>();
            detailsDgv.DataSource = details;
        }

        private void AddProductBt_Click(object sender, EventArgs e)
        {
            detailsDgv.DataSource = null;

            details.Add(new OrderDetail
            {
                ProductId = productCb.SelectedValue.ToString(),
                ProductDescription = productCb.Text.ToString(),
                Amount = ((int)amountDd.Value),
            });

            detailsDgv.DataSource = details;
        }

        private async void getAddressesBt_Click(object sender, EventArgs e)
        {
            HttpResponseMessage clientsAddressesResponse = await _client.Execute($"Client/{clientsCb.SelectedValue.ToString()}", HttpMethod.Get);
            var clientsAddressesContent = await clientsAddressesResponse.Content.ReadAsStreamAsync();

            var client = JsonSerializer.Deserialize<Models.Client>(clientsAddressesContent);
            addressCb.DataSource = client.Addresses;
            addressCb.ValueMember = "Id";
            addressCb.DisplayMember = "Description";
        }

        private async void createOrderBt_Click(object sender, EventArgs e)
        {
            Models.Order order = new Models.Order
            {
                Details = details,
                Header = new OrderHeader
                {
                    DateTime = DateTime.Now,
                    ClientId = clientsCb.SelectedValue.ToString(),
                    ClientName = clientsCb.Text.ToString(),
                    AddressDescription = addressCb.Text.ToString(),
                    AddressId = addressCb.SelectedValue.ToString(),
                }
            };

            var content = new StringContent(JsonSerializer.Serialize(order),
                Encoding.UTF8, "application/json");

            HttpResponseMessage createOrderResponse = await _client.Execute("Order", HttpMethod.Post, content);
            var response = await createOrderResponse.Content.ReadAsStringAsync();
            Close();
        }
    }
}
