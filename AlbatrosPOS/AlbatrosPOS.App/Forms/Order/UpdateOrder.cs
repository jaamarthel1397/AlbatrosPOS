using AlbatrosPOS.App.Models;
using System.Text;
using System.Text.Json;

namespace AlbatrosPOS.App.Forms.Order
{
    public partial class UpdateOrder : Form
    {
        private readonly ApiClient _client;
        private List<OrderDetail> details;
        private OrderHeader header;

        public UpdateOrder(ApiClient apiClient, Models.OrderHeader orderHeader)
        {
            _client = apiClient;
            header = orderHeader;
            InitializeComponent();
        }

        private async void updateOrderBt_Click(object sender, EventArgs e)
        {
            Models.Order order = new Models.Order
            {
                Details = details,
                Header = new OrderHeader
                {
                    Id = header.Id,
                    DateTime = DateTime.Now,
                    ClientId = clientsCb.SelectedValue.ToString(),
                    ClientName = clientsCb.Text.ToString(),
                    AddressDescription = addressCb.Text.ToString(),
                    AddressId = addressCb.SelectedValue.ToString(),
                }
            };

            var content = new StringContent(JsonSerializer.Serialize(order),
                Encoding.UTF8, "application/json");

            HttpResponseMessage createOrderResponse = await _client.Execute($"Order/{header.Id.ToString()}", HttpMethod.Put, content);
            var response = await createOrderResponse.Content.ReadAsStringAsync();
            Close();
        }

        private void addProductBt_Click(object sender, EventArgs e)
        {
            detailsDgv.DataSource = null;

            details.Add(new OrderDetail
            {
                ProductId = productCb.SelectedValue.ToString(),
                ProductDescription = productCb.Text.ToString(),
                Amount = ((int)amountDd.Value),
                HeaderId = header.Id,
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

        private async void UpdateOrder_Load(object sender, EventArgs e)
        {
            HttpResponseMessage orderDetailsResponse = await _client.Execute($"Order/{header.Id}", HttpMethod.Get);
            var orderDetailsContent = await orderDetailsResponse.Content.ReadAsStreamAsync();

            var orderDetails = JsonSerializer.Deserialize<Models.Order>(orderDetailsContent);

            HttpResponseMessage clientsResponse = await _client.Execute("Client", HttpMethod.Get);
            var clientsContent = await clientsResponse.Content.ReadAsStreamAsync();

            var clients = JsonSerializer.Deserialize<IEnumerable<Models.Client>>(clientsContent);
            clientsCb.DataSource = clients;
            clientsCb.ValueMember = "Id";
            clientsCb.DisplayMember = "Name";
            clientsCb.SelectedValue = header.ClientId;

            HttpResponseMessage clientsAddressesResponse = await _client.Execute($"Client/{header.ClientId}", HttpMethod.Get);
            var clientsAddressesContent = await clientsAddressesResponse.Content.ReadAsStreamAsync();

            var client = JsonSerializer.Deserialize<Models.Client>(clientsAddressesContent);
            addressCb.DataSource = client.Addresses;
            addressCb.ValueMember = "Id";
            addressCb.DisplayMember = "Description";
            addressCb.SelectedValue = header.AddressId;

            HttpResponseMessage productsResponse = await _client.Execute("Product", HttpMethod.Get);
            var productsContent = await productsResponse.Content.ReadAsStreamAsync();

            var products = JsonSerializer.Deserialize<IEnumerable<Models.Product>>(productsContent);
            productCb.DataSource = products;
            productCb.ValueMember = "Id";
            productCb.DisplayMember = "Description";

            details = orderDetails.Details.ToList();
            detailsDgv.DataSource = details;
        }
    }
}
