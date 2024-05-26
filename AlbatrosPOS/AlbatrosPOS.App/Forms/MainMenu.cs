using AlbatrosPOS.App.Forms.Client;
using AlbatrosPOS.App.Forms.Order;
using AlbatrosPOS.App.Forms.Product;
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
    public partial class MainMenu : Form
    {
        private readonly ApiClient _client;
        public MainMenu(ApiClient apiClient)
        {
            InitializeComponent();
            _client = apiClient;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var selected = ordersDgv.SelectedRows[0].Cells["Id"].Value;
            HttpResponseMessage deleteResponse = await _client.Execute($"Order/{selected}", HttpMethod.Delete);
            if (deleteResponse.IsSuccessStatusCode)
            {
                MessageBox.Show("Registro eliminado exitosamente");
            }
            else
            {
                MessageBox.Show("Ocurrió un error al intentar eliminar el registro, por favor revise datos relacionados");
            }
            ordersDgv.DataSource = null;
            ordersDgv.DataSource = await this.getOrders();

        }

        private async void MainMenu_Load(object sender, EventArgs e)
        {
            var orders = await this.getOrders();
            ordersDgv.DataSource = orders;

            var products = await this.getProducts();
            productsDgv.DataSource = products;

            var clients = await this.getClients();
            clientsDgv.DataSource = clients;
        }

        private async void addOrderBt_Click(object sender, EventArgs e)
        {
            CreateOrder createOrder = new CreateOrder(_client);
            createOrder.ShowDialog();
            var result = await this.getOrders();
            ordersDgv.DataSource = result;
        }

        private async Task<IEnumerable<Models.OrderHeader>> getOrders()
        {
            HttpResponseMessage ordersResponse = await _client.Execute("Order", HttpMethod.Get);
            var ordersContent = await ordersResponse.Content.ReadAsStreamAsync();

            var orders = JsonSerializer.Deserialize<IEnumerable<OrderHeader>>(ordersContent);

            return orders;
        }

        private async Task<IEnumerable<Models.Client>> getClients()
        {
            HttpResponseMessage clientsResponse = await _client.Execute("Client", HttpMethod.Get);
            var clientsContent = await clientsResponse.Content.ReadAsStreamAsync();

            var clients = JsonSerializer.Deserialize<IEnumerable<Models.Client>>(clientsContent);

            return clients;
        }

        private async Task<IEnumerable<Models.Product>> getProducts()
        {
            HttpResponseMessage productsResponse = await _client.Execute("Product", HttpMethod.Get);
            var productsContent = await productsResponse.Content.ReadAsStreamAsync();

            var products = JsonSerializer.Deserialize<IEnumerable<Models.Product>>(productsContent);

            return products;
        }

        private async void ordersDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = ordersDgv.SelectedRows[0];
            var orderHeader = new Models.OrderHeader
            {
                Id = selected.Cells["Id"].Value.ToString(),
                AddressId = selected.Cells["AddressId"].Value.ToString(),
                ClientId = selected.Cells["ClientId"].Value.ToString(),
                AddressDescription = selected.Cells["AddressDescription"].Value.ToString(),
                ClientName = selected.Cells["ClientName"].Value.ToString(),
                DateTime = DateTime.Parse(selected.Cells["DateTime"].Value.ToString()),
            };

            UpdateOrder updateOrder = new UpdateOrder(_client, orderHeader);
            updateOrder.ShowDialog();
            ordersDgv.DataSource = null;
            ordersDgv.DataSource = await getOrders();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ordersPanel.Visible = true;
            clientsPanel.Visible = false;
            productsPanel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productsPanel.Visible = true;
            ordersPanel.Visible = false;
            clientsPanel.Visible = false;
        }

        private void clientsBt_Click(object sender, EventArgs e)
        {
            clientsPanel.Visible = true;
            ordersPanel.Visible = false;
            productsPanel.Visible = false;
        }

        private async void createClient_Click(object sender, EventArgs e)
        {
            CreateClient createClient = new CreateClient(_client);
            createClient.ShowDialog();
            var result = await this.getClients();
            clientsDgv.DataSource = result;
        }

        private async void DeleteClient_Click_1(object sender, EventArgs e)
        {
            var selected = clientsDgv.SelectedRows[0].Cells["Id"].Value;
            HttpResponseMessage deleteResponse = await _client.Execute($"Client/{selected}", HttpMethod.Delete);
            if (deleteResponse.IsSuccessStatusCode)
            {
                MessageBox.Show("Registro eliminado exitosamente");
            }
            else
            {
                MessageBox.Show("Ocurrió un error al intentar eliminar el registro, por favor revise datos relacionados");
            }
            clientsDgv.DataSource = null;
            clientsDgv.DataSource = await this.getClients();
        }

        private async void createProduct_Click(object sender, EventArgs e)
        {
            CreateProduct createProduct = new CreateProduct(_client);
            createProduct.ShowDialog();
            var result = await this.getProducts();
            productsDgv.DataSource = result;
        }

        private async void deleteProduct_Click(object sender, EventArgs e)
        {
            var selected = productsDgv.SelectedRows[0].Cells["Id"].Value;
            HttpResponseMessage deleteResponse = await _client.Execute($"Product/{selected}", HttpMethod.Delete);
            if (deleteResponse.IsSuccessStatusCode)
            {
                MessageBox.Show("Registro eliminado exitosamente");
            }
            else
            {
                MessageBox.Show("Ocurrió un error al intentar eliminar el registro, por favor revise datos relacionados");
            }
            productsDgv.DataSource= null;
            productsDgv.DataSource = await this.getProducts();
        }

        private async void productsDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = productsDgv.SelectedRows[0];
            var product = new Models.Product
            {
                Id = selected.Cells["Id"].Value.ToString(),
                Description = selected.Cells["Description"].Value.ToString(),
                Amount = Int32.Parse(selected.Cells["Amount"].Value.ToString()),
            };

            UpdateProduct updateProduct = new UpdateProduct(_client, product);
            updateProduct.ShowDialog();
            productsDgv.DataSource = null;
            productsDgv.DataSource = await this.getProducts();
        }

        private async void clientsDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selected = clientsDgv.SelectedRows[0];
            var client = new Models.Client
            {
                Id = selected.Cells["Id"].Value.ToString(),
                Name = selected.Cells["Name"].Value.ToString(),
            };

            UpdateClient updateClient = new UpdateClient(_client, client);
            updateClient.ShowDialog();
            clientsDgv.DataSource = null;
            clientsDgv.DataSource = await this.getClients();
        }
    }
}
