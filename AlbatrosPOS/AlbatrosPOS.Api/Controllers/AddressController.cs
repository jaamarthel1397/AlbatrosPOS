using AlbatrosPOS.Database.Models;
using AlbatrosPOS.Services.AddressService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlbatrosPOS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService addressService;
        private readonly ILogger<AddressController> logger;

        public AddressController(IAddressService addressService, ILogger<AddressController> logger)
        {
            this.addressService = addressService;
            this.logger = logger;
        }

        // GET: api/<AddressController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await this.addressService.GetAllAddresses();

            List<Models.Address> addresses = new List<Models.Address>();
            foreach (var address in result)
            {
                addresses.Add(new Models.Address
                {
                    Id = address.Id,
                    Description = address.Description,
                    ClientId = address.ClientId,
                });
            }

            return Ok(addresses);
        }

        // GET api/<AddressController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var result = await this.addressService.GetAddressById(id);

            if (result == null)
            {
                return NotFound();
            }

            var address = new Models.Address
            {
                Id = result.Id,
                Description = result.Description,
                ClientId = result.ClientId,
            };
            return Ok(address);
        }

        // POST api/<AddressController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Models.Address address)
        {
            if (address == null)
            {
                return BadRequest();
            }

            if (address.Description == null || address.ClientId == null)
            {
                return BadRequest();
            }

            var result = await this.addressService.CreateAddress(new Database.Models.Address
            {
                Id = address.Id,
                Description = address.Description,
                ClientId = address.ClientId,
            });

            return Ok(result);
        }

        // PUT api/<AddressController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] Models.Address address)
        {
            if (address == null)
            {
                return BadRequest();
            }

            if (address.Description == null || address.ClientId == null)
            {
                return BadRequest();
            }

            var result = await this.addressService.UpdateAddress(new Database.Models.Address
            {
                Id= address.Id,
                Description = address.Description,
                ClientId = address.ClientId,
            });

            return Ok(result);
        }

        // DELETE api/<AddressController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var result = await this.addressService.DeleteAddress(id);

            if (result)
            {
                return Ok();
            }

            return BadRequest();
        }
    }
}
