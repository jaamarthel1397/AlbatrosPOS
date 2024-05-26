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
    public partial class CreateProduct : Form
    {
        private ApiClient _client;
        public CreateProduct(ApiClient apiClient)
        {
            InitializeComponent();
            this._client = apiClient;
        }

        private async void SaveBt_Click(object sender, EventArgs e)
        {
            var product = new Models.Product
            {
                Description = descriptionTb.Text,
                Amount = ((int)numericUpDown1.Value),
            };

            var content = new StringContent(JsonSerializer.Serialize(product),
                Encoding.UTF8, "application/json");

            HttpResponseMessage createResponse = await _client.Execute($"Product", HttpMethod.Post, content);
            Close();
        }
    }
}
