using AlbatrosPOS.Database.Models;
using AlbatrosPOS.Database.Repositories;
using AlbatrosPOS.Services.AddressService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AlbatrosPOS.Services.ClientService
{
    /// <inheritdoc/>
    public class ClientService : IClientService
    {
        private readonly IRepository<Client> clientRepository;
        private readonly IAddressService addressService;
        private readonly ILogger<ClientService> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientService"/> class.
        /// </summary>
        /// <param name="clientRepository">A repository that handles client data.</param>
        /// <param name="addressService">A service that handles address data.</param>
        /// <param name="logger">A generic interface for logging.</param>
        public ClientService(
            IRepository<Client> clientRepository,
            IAddressService addressService,
            ILogger<ClientService> logger)
        {
            this.clientRepository = clientRepository;
            this.addressService = addressService;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task<bool> CreateClient(Client newClient)
        {
            try
            {
                this.logger.LogInformation("Attempting to create a new client");

                this.clientRepository.Create(newClient);
                await this.clientRepository.SaveChangesAsync();
                foreach (var item in newClient.Addresses)
                {
                    await this.addressService.CreateAddress(item);
                }

                this.logger.LogInformation("Successfuly created the new client with id {id}", newClient.Id);
                return true;
            }
            catch (Exception ex)
            {
                this.logger.LogError("An error ocurred while attempting to create the client." + ex.Message);
                return false;
            }
        }

        /// <inheritdoc/>
        public async Task<bool> DeleteClient(string id)
        {
            try
            {
                this.logger.LogInformation("Attempting to delete the client with id {id}", id);
                var result = await this.GetClientById(id);
                this.clientRepository.Delete(result!);
                
                foreach (var item in result.Addresses)
                {
                    await addressService.DeleteAddress(item.Id);
                }

                await this.clientRepository.SaveChangesAsync();
                this.logger.LogInformation("Successfuly deleted the client with id {id}", id);
                return true;
            }
            catch (Exception ex)
            {
                this.logger.LogInformation("An error ocurred while attempting to delete the client with id {id}", id);
                return false;
            }
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<Client>> GetAllClients()
        {
            try
            {
                this.logger.LogInformation("Attempting to get all the available clients");
                var result = await this.clientRepository.All().ToListAsync();
                return result;
            }
            catch (Exception e)
            {
                this.logger.LogInformation("An error ocurred while attempting to get all the available clients");
                throw;
            }
        }

        /// <inheritdoc/>
        public async Task<Client?> GetClientById(string id)
        {
            try
            {
                this.logger.LogInformation("Attempting to get the client with id {id}", id);
                var result = await this.clientRepository.Filter(x => x.Id == id).Include(y => y.Addresses).FirstAsync();
                return result;
            }
            catch (Exception e)
            {
                this.logger.LogInformation("An error ocurred while attempting to get the client with id {id}", id);
                throw;
            }
        }

        /// <inheritdoc/>
        public async Task<bool> UpdateClient(Client client)
        {
            try
            {
                this.logger.LogInformation("Attempting to update the client with id {id}", client.Id);
                this.clientRepository.Update(client);
                foreach (var item in client.Addresses)
                {
                    if (item.Id == null)
                    {
                        await addressService.CreateAddress(item);
                    }
                    else
                    {
                        await addressService.UpdateAddress(item);
                    }
                }
                await this.clientRepository.SaveChangesAsync();
                this.logger.LogInformation("Successfuly updated the client with id {id}", client.Id);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
