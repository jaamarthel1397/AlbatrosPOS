using AlbatrosPOS.App.Forms.Order;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void MainMenu_Load(object sender, EventArgs e)
        {

            HttpResponseMessage ordersResponse = await _client.Execute("Order", HttpMethod.Get);
            var ordersContent = await ordersResponse.Content.ReadAsStreamAsync();

            var orders = JsonSerializer.Deserialize<IEnumerable<OrderHeader>>(ordersContent);
            ordersDgv.DataSource = orders;
        }

        private void addOrderBt_Click(object sender, EventArgs e)
        {
            CreateOrder createOrder = new CreateOrder(_client);
            createOrder.ShowDialog();
        }
    }
}
