using AlbatrosPOS.Database.Context;
using AlbatrosPOS.Database.Models;

namespace AlbatrosPOS.Database.Repositories
{
    public class UserRepository : AlbatrosDbContextRepositoryBase<User>
    {
        public UserRepository(AlbatrosDbContext context) : base(context)
        {
            this.Context = context;
        }

        public override IQueryable<User> All()
        {
            return this.Context.Users;
        }

        protected override User MapNewValuesToOld(User oldEntity, User newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
