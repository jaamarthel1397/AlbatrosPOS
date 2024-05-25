using AlbatrosPOS.Database.Models;

namespace AlbatrosPOS.Services.ClientService
{
    /// <summary>
    /// A service that manages the data of the <see cref="Client"/> table.
    /// </summary>
    public interface IClientService
    {
        /// <summary>
        /// Gets the specified client.
        /// </summary>
        /// <param name="id">The id of the client to get.</param>
        /// <returns>An asynchronous task with the result.</returns>
        public Task<Client?> GetClientById(string id);

        /// <summary>
        /// Gets all the available clients.
        /// </summary>
        /// <returns>An asynchronous task with the result.</returns>
        public Task<IEnumerable<Client>> GetAllClients();

        /// <summary>
        /// Creates a new client.
        /// </summary>
        /// <param name="newClient">The new client to create.</param>
        /// <returns>An asynchonous task with the result of the operation.</returns>
        public Task<bool> CreateClient(Client newClient);

        /// <summary>
        /// Modifies an existing client.
        /// </summary>
        /// <param name="client">The client to update.</param>
        /// <returns>An asynchonous task with the result of the operation.</returns>
        public Task<bool> UpdateClient(Client client);

        /// <summary>
        /// Delets a client.
        /// </summary>
        /// <param name="id">The id of the client to delete.</param>
        /// <returns>An asynchronous task with the result.</returns>
        public Task<bool> DeleteClient(string id);
    }
}
