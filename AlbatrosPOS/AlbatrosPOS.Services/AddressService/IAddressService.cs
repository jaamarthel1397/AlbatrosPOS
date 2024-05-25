using AlbatrosPOS.Database.Models;

namespace AlbatrosPOS.Services.AddressService
{
    /// <summary>
    /// A service that manages the data of the <see cref="Address"/> table.
    /// </summary>
    public interface IAddressService
    {
        /// <summary>
        /// Gets the specified address.
        /// </summary>
        /// <param name="id">The id of the address to get.</param>
        /// <returns>An asynchronous task with the result.</returns>
        public Task<Address?> GetAddressById(string id);

        /// <summary>
        /// Gets all the available addresses.
        /// </summary>
        /// <returns>An asynchronous task with the result.</returns>
        public Task<IEnumerable<Address>> GetAllAddresses();

        /// <summary>
        /// Creates a new address.
        /// </summary>
        /// <param name="newAddress">The new address to create.</param>
        /// <returns>An asynchonous task with the result of the operation.</returns>
        public Task<bool> CreateAddress(Address newAddress);

        /// <summary>
        /// Modifies an existing address.
        /// </summary>
        /// <param name="address">The address to update.</param>
        /// <returns>An asynchonous task with the result of the operation.</returns>
        public Task<bool> UpdateAddress(Address address);

        /// <summary>
        /// Delets a address.
        /// </summary>
        /// <param name="id">The id of the address to delete.</param>
        /// <returns>An asynchronous task with the result.</returns>
        public Task<bool> DeleteAddress(string id);
    }
}
