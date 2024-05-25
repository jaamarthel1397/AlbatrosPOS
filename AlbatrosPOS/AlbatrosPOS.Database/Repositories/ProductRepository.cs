using AlbatrosPOS.Database.Context;
using AlbatrosPOS.Database.Models;
using System.Linq.Expressions;

namespace AlbatrosPOS.Database.Repositories
{
    /// <summary>
    /// A repository that handles the <see cref="Product"/> database data.
    /// </summary>
    public class ProductRepository : AlbatrosDbContextRepositoryBase<Product>
    {
        public ProductRepository(AlbatrosDbContext context) : base(context)
        {
            this.Context = context;
        }

        public override IQueryable<Product> All()
        {
            return this.Context.Products;
        }

        protected override Product MapNewValuesToOld(Product oldEntity, Product newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
