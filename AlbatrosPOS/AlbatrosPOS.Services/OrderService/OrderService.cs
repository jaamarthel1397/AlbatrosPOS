using AlbatrosPOS.Database.Models;
using AlbatrosPOS.Database.Repositories;
using AlbatrosPOS.Services.OrderService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AlbatrosPOS.Services.OrderService
{
    /// <inheritdoc/>
    public class OrderService : IOrderService
    {
        private readonly IRepository<OrderHeader> orderHeaderRepository;
        private readonly IRepository<OrderDetail> orderDetailRepository;
        private readonly ILogger<OrderService> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderService"/> class.
        /// </summary>
        /// <param name="orderHeaderRepository">A repository that handles order header data.</param>
        /// <param name="orderDetailRepository">A repository that handles order detail data.</param>
        /// <param name="logger">A generic interface for logging.</param>
        public OrderService(
            IRepository<OrderHeader> orderHeaderRepository,
            IRepository<OrderDetail> orderDetailRepository,
            ILogger<OrderService> logger)
        {
            this.orderHeaderRepository = orderHeaderRepository;
            this.orderDetailRepository = orderDetailRepository;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task<bool> CreateOrder(Order order)
        {
            try
            {
                this.logger.LogInformation("Attempting to create a new order");

                this.orderHeaderRepository.Create(order.Header);
                await this.orderHeaderRepository.SaveChangesAsync();
                this.logger.LogInformation("Successfuly created the new order header with id {id}", order.Header.Id);

                foreach (var item in order.Details)
                {
                    this.orderDetailRepository.Create(item);
                }

                await this.orderDetailRepository.SaveChangesAsync();
                
                return true;
            }
            catch (Exception ex)
            {
                this.logger.LogError("An error ocurred while attempting to create the order." + ex.Message);
                return false;
            }
        }

        /// <inheritdoc/>
        public async Task<bool> DeleteOrder(string id)
        {
            try
            {
                this.logger.LogInformation("Attempting to delete the order with id {id}", id);
                var result = await this.GetOrderById(id);

                if (result == null)
                {
                    this.logger.LogError("An order with the id {id} does not exist.", id);
                    return false;
                }

                foreach (var item in result.Details)
                {
                    await this.DeleteOrderDetail(item.Id);
                }

                this.orderHeaderRepository.Delete(result.Header);
                await this.orderHeaderRepository.SaveChangesAsync();
                this.logger.LogInformation("Successfuly deleted the order with id {id}", id);
                return true;
            }
            catch (Exception ex)
            {
                this.logger.LogInformation("An error ocurred while attempting to delete the order with id {id}", id);
                return false;
            }
        }

        /// <inheritdoc/>
        public async Task<bool> DeleteOrderDetail(string id)
        {
            try
            {
                this.logger.LogInformation("Attempting to delete the order detail with id {id}", id);
                var result = await this.GetOrderDetailById(id);
                this.orderDetailRepository.Delete(result!);
                await this.orderDetailRepository.SaveChangesAsync();
                this.logger.LogInformation("Successfuly deleted the order detail with id {id}", id);
                return true;
            }
            catch (Exception ex)
            {
                this.logger.LogInformation("An error ocurred while attempting to delete the order detail with id {id}", id);
                return false;
            }
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<OrderHeader>> GetAllOrderHeaders()
        {
            try
            {
                this.logger.LogInformation("Attempting to get all the available order headers.");
                var result = await this.orderHeaderRepository.All().ToListAsync();
                return result;
            }
            catch (Exception e)
            {
                this.logger.LogInformation("An error ocurred while attempting to get all the available order headers.");
                throw;
            }
        }

        /// <inheritdoc/>
        public async Task<Order?> GetOrderById(string id)
        {
            try
            {
                this.logger.LogInformation("Attempting to get the order with id {id}", id);
                var header = await this.orderHeaderRepository.FindAsync(id);
                if (header == null)
                {
                    this.logger.LogError("An order header with the id {id} does not exist.", id);
                    return null;
                }
                var details = await this.orderDetailRepository.Filter(x => x.HeaderId == id).ToListAsync();

                var order = new Order
                {
                    Header = header,
                    Details = details,
                };

                return order;
            }
            catch (Exception e)
            {
                this.logger.LogInformation("An error ocurred while attempting to get the order with id {id}", id);
                throw;
            }
        }

        /// <inheritdoc/>
        public async Task<bool> UpdateOrder(Order order)
        {
            try
            {
                this.logger.LogInformation("Attempting to update the order with id {id}", order.Header.Id);
                this.orderHeaderRepository.Update(order.Header);
                await this.orderHeaderRepository.SaveChangesAsync();

                foreach (var item in order.Details)
                {
                    if (item.Id != null)
                    {
                        orderDetailRepository.Update(item);
                    }
                    else
                    {
                        orderDetailRepository.Create(item);
                    }
                }

                await this.orderDetailRepository.SaveChangesAsync();

                this.logger.LogInformation("Successfuly updated the order with id {id}", order.Header.Id);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the specified order detail.
        /// </summary>
        /// <param name="id">The id of the order detail to get.</param>
        /// <returns></returns>
        private async Task<OrderDetail?> GetOrderDetailById(string id)
        {
            try
            {
                this.logger.LogInformation("Attempting to get the order detail with id {id}", id);
                var result = await this.orderDetailRepository.FindAsync(id);
                return result;
            }
            catch (Exception e)
            {
                this.logger.LogInformation("An error ocurred while attempting to get the order detail with id {id}", id);
                throw;
            }
        }
    }
}
