using AlbatrosPOS.Database.Context;
using AlbatrosPOS.Database.Models;
using System.Linq.Expressions;

namespace AlbatrosPOS.Database.Repositories
{
    public class OrderDetailRepository : AlbatrosDbContextRepositoryBase<OrderDetail>
    {
        public OrderDetailRepository(AlbatrosDbContext context) : base(context)
        {
            this.Context = context;
        }

        public override IQueryable<OrderDetail> All()
        {
            return this.Context.OrderDetails;
        }

        protected override OrderDetail MapNewValuesToOld(OrderDetail oldEntity, OrderDetail newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
