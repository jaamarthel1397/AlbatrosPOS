using AlbatrosPOS.Database.Models;
using AlbatrosPOS.Services.ClientService;
using Microsoft.AspNetCore.Mvc;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlbatrosPOS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService clientService;
        private readonly ILogger logger;

        // GET: api/<ClientController>
        [HttpGet]
        public async Task<IEnumerable<Client>> Get()
        {
            var result = await this.clientService.GetAllClients();

            return result;
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public async Task<Client> Get(string id)
        {
            var result = await this.clientService.GetClientById(id);
            return result;
        }

        // POST api/<ClientController>
        [HttpPost]
        public async Task<bool> Post([FromBody] Client client)
        {
            if (client == null)
            {
                return false;
            }

            if (client.Name == null)
            {
                return false;
            }

            var result = await this.clientService.CreateClient(client);

            return result;
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public async Task<bool> Put(string id, [FromBody] Client client)
        {
            if (client == null)
            {
                return false;
            }

            if (client.Name == null)
            {
                return false;
            }

            var result = await this.clientService.UpdateClient(client);

            return result;
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(string id)
        {
            var result = await this.clientService.DeleteClient(id);
            return result;
        }
    }
}
