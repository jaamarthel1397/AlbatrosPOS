using AlbatrosPOS.Database.Context;
using AlbatrosPOS.Database.Models;
using System.Linq.Expressions;

namespace AlbatrosPOS.Database.Repositories
{
    public class OrderHeaderRepository : AlbatrosDbContextRepositoryBase<OrderHeader>
    {
        public OrderHeaderRepository(AlbatrosDbContext context) : base(context)
        {
            this.Context = context;
        }

        public override IQueryable<OrderHeader> All()
        {
            return this.Context.OrderHeaders;
        }

        protected override OrderHeader MapNewValuesToOld(OrderHeader oldEntity, OrderHeader newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
