using AlbatrosPOS.Database.Models;
using AlbatrosPOS.Services.AddressService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlbatrosPOS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
        public async Task<IEnumerable<Address>> Get()
        {
            var result = await this.addressService.GetAllAddresses();

            return result;
        }

        // GET api/<AddressController>/5
        [HttpGet("{id}")]
        public async Task<Address> Get(string id)
        {
            var result = await this.addressService.GetAddressById(id);
            return result;
        }

        // POST api/<AddressController>
        [HttpPost]
        public async Task<bool> Post([FromBody] Address address)
        {
            if (address == null)
            {
                return false;
            }

            if (address.Description == null || address.ClientId == null)
            {
                return false;
            }

            var result = await this.addressService.CreateAddress(address);

            return result;
        }

        // PUT api/<AddressController>/5
        [HttpPut("{id}")]
        public async Task<bool> Put(string id, [FromBody] Address address)
        {
            if (address == null)
            {
                return false;
            }

            if (address.Description == null || address.ClientId == null)
            {
                return false;
            }

            var result = await this.addressService.UpdateAddress(address);

            return result;
        }

        // DELETE api/<AddressController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(string id)
        {
            var result = await this.addressService.DeleteAddress(id);

            return result;
        }
    }
}
