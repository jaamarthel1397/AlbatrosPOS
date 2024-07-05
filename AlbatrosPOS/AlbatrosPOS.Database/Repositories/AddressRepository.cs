using AlbatrosPOS.Database.Context;
using AlbatrosPOS.Database.Models;

namespace AlbatrosPOS.Database.Repositories
{
    public class AddressRepository : AlbatrosDbContextRepositoryBase<Address>
    {
        public AddressRepository(AlbatrosDbContext context) : base(context)
        {
            this.Context = context;
        }

        public override IQueryable<Address> All()
        {
            return this.Context.Addresses;
        }

        protected override Address MapNewValuesToOld(Address oldEntity, Address newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
