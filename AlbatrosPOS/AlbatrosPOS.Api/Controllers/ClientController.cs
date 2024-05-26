using AlbatrosPOS.Api.Models;
using AlbatrosPOS.Database.Models;
using AlbatrosPOS.Services.ClientService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Address = AlbatrosPOS.Database.Models.Address;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlbatrosPOS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ClientController : ControllerBase
    {
        private readonly IClientService clientService;
        private readonly ILogger logger;

        public ClientController(IClientService clientService, ILogger<ClientController> logger)
        {
            this.clientService = clientService;
            this.logger = logger;
        }

        // GET: api/<ClientController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await this.clientService.GetAllClients();

            List<Models.Client> clients = new List<Models.Client>();
            foreach (var client in result)
            {
                clients.Add(new Models.Client
                {
                    Name = client.Name,
                    Id = client.Id,
                });
            }

            return Ok(clients);
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var client = await this.clientService.GetClientById(id);

            if (client == null)
            {
                return NotFound();
            }

            Models.Client result = new Models.Client
            {
                Id = id,
                Name = client.Name,
                Addresses = this.mapDbAddressesToDtoAddresses(client.Addresses),
            };

            return Ok(result);
        }

        // POST api/<ClientController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Models.Client client)
        {
            if (client == null)
            {
                return BadRequest();
            }

            if (client.Name == null)
            {
                return BadRequest();
            }
            
            var result = await this.clientService.CreateClient(new Database.Models.Client
            {
                Name = client.Name,
                Addresses = this.mapDtoAddressesToDbAddresses(client.Addresses),
            });

            return Ok(result);
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] Models.Client client)
        {
            if (client == null)
            {
                return BadRequest();
            }

            if (client.Name == null)
            {
                return BadRequest();
            }

            var result = await this.clientService.UpdateClient(new Database.Models.Client
            {
                Id = client.Id,
                Name = client.Name,
                Addresses = this.mapDtoAddressesToDbAddresses(client.Addresses),
            });

            return Ok(result);
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var result = await this.clientService.DeleteClient(id);
            if (result)
            {
                return Ok();
            }

            return BadRequest();
        }

        private ICollection<Database.Models.Address> mapDtoAddressesToDbAddresses(ICollection<Models.Address> addresses)
        {
            List<Database.Models.Address> result = new List<Database.Models.Address>();
            foreach (var address in addresses)
            {
                result.Add(new Database.Models.Address
                {
                    ClientId = address.ClientId,
                    Description = address.Description,
                });
            }

            return result;
        }

        private ICollection<Models.Address> mapDbAddressesToDtoAddresses(ICollection<Database.Models.Address> addresses)
        {
            List<Models.Address> result = new List<Models.Address>();
            foreach (var address in addresses)
            {
                result.Add(new Models.Address
                {
                    Id = address.Id,
                    ClientId = address.ClientId,
                    Description = address.Description,
                });
            }

            return result;
        }
    }
}
