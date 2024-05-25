using AlbatrosPOS.Database.Context;
using AlbatrosPOS.Database.Models;

namespace AlbatrosPOS.Database.Repositories
{
    public class ClientRepository : AlbatrosDbContextRepositoryBase<Client>
    {
        public ClientRepository(AlbatrosDbContext context) : base(context)
        {
            this.Context = context;
        }

        public override IQueryable<Client> All()
        {
            return this.Context.Clients;
        }

        protected override Client MapNewValuesToOld(Client oldEntity, Client newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
