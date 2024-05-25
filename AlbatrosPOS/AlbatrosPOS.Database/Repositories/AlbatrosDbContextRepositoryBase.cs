using AlbatrosPOS.Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbatrosPOS.Database.Repositories
{
    public abstract class AlbatrosDbContextRepositoryBase<TEntity> : RepositoryBase<TEntity, AlbatrosDbContext>
        where TEntity : class
    {
        protected AlbatrosDbContextRepositoryBase(AlbatrosDbContext context) : base(context)
        {
            this.Context = context;
        }
    }
}
