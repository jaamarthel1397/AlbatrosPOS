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

namespace AlbatrosPOS.App.Forms.Product
{
    public partial class UpdateProduct : Form
    {
        private readonly ApiClient _client;
        private Models.Product _product;
        public UpdateProduct(ApiClient client, Models.Product product)
        {
            InitializeComponent();
            _client = client;
            _product = product;
        }

        private async void SaveBt_Click(object sender, EventArgs e)
        {
            var product = new Models.Product
            {
                Id = _product.Id,
                Description = descriptionTb.Text,
                Amount = ((int)numericUpDown1.Value),
            };

            var content = new StringContent(JsonSerializer.Serialize(product),
                Encoding.UTF8, "application/json");

            HttpResponseMessage updateResponse = await _client.Execute($"Product/{product.Id}", HttpMethod.Put, content);
            var test = await updateResponse.Content.ReadAsStringAsync();
            Close();
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            descriptionTb.Text = _product.Description;
            numericUpDown1.Value = _product.Amount;
        }
    }
}
