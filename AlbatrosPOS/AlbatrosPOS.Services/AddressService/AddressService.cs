using AlbatrosPOS.Database.Models;
using AlbatrosPOS.Database.Repositories;
using AlbatrosPOS.Services.ClientService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AlbatrosPOS.Services.AddressService
{
    /// <inheritdoc/>
    public class AddressService : IAddressService
    {
        private readonly IRepository<Address> addressRepository;
        private readonly IClientService clientService;
        private readonly ILogger<AddressService> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressService"/> class.
        /// </summary>
        /// <param name="addressRepository">A repository that handles address data.</param>
        /// <param name="clientService">A service that handles client data.</param>
        /// <param name="logger">A generic interface for logging.</param>
        public AddressService(IRepository<Address> addressRepository, IClientService clientService, ILogger<AddressService> logger)
        {
            this.addressRepository = addressRepository;
            this.clientService = clientService;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task<bool> CreateAddress(Address newAddress)
        {
            try
            {
                this.logger.LogInformation("Attempting to create a new address");
                var client = await this.clientService.GetClientById(newAddress.ClientId);
                if (client == null)
                {
                    this.logger.LogError("A client with the client id {id} does not exist.", newAddress.ClientId);
                    return false;
                }

                this.addressRepository.Create(newAddress);
                await this.addressRepository.SaveChangesAsync();
                this.logger.LogInformation("Successfuly created the new address with id {id}", newAddress.Id);
                return true;
            }
            catch (Exception ex)
            {
                this.logger.LogError("An error ocurred while attempting to create the address." + ex.Message);
                return false;
            }
        }

        /// <inheritdoc/>
        public async Task<bool> DeleteAddress(string id)
        {
            try
            {
                this.logger.LogInformation("Attempting to delete the address with id {id}", id);
                var result = await this.GetAddressById(id);
                this.addressRepository.Delete(result!);
                await this.addressRepository.SaveChangesAsync();
                this.logger.LogInformation("Successfuly deleted the address with id {id}", id);
                return true;
            }
            catch (Exception ex)
            {
                this.logger.LogInformation("An error ocurred while attempting to delete the address with id {id}", id);
                return false;
            }
        }

        /// <inheritdoc/>
        public async Task<Address?> GetAddressById(string id)
        {
            try
            {
                this.logger.LogInformation("Attempting to get the address with id {id}", id);
                var result = await this.addressRepository.FindAsync(id);
                return result;
            }
            catch (Exception e)
            {
                this.logger.LogInformation("An error ocurred while attempting to get the address with id {id}", id);
                throw;
            }
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<Address>> GetAllAddresses()
        {
            try
            {
                this.logger.LogInformation("Attempting to get all the available addresses");
                var result = await this.addressRepository.All().ToListAsync();
                return result;
            }
            catch (Exception e)
            {
                this.logger.LogInformation("An error ocurred while attempting to get all the available addresses");
                throw;
            }
        }

        /// <inheritdoc/>
        public async Task<bool> UpdateAddress(Address address)
        {
            try
            {
                this.logger.LogInformation("Attempting to update the address with id {id}", address.Id);
                this.addressRepository.Update(address);
                await this.addressRepository.SaveChangesAsync();
                this.logger.LogInformation("Successfuly updated the address with id {id}", address.Id);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
