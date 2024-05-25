using AlbatrosPOS.Database.Models;
using System.Linq.Expressions;

namespace AlbatrosPOS.Database.Repositories
{
    /// <summary>
    /// A repository that handles the <see cref="Product"/> database data.
    /// </summary>
    public class ProductRepository : IRepository<Product>
    {
        /// <inheritdoc/>
        public IQueryable<Product> All()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Product Create()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Product Create(Product entity)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Product Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public IQueryable<Product> Filter(Expression<Func<Product, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Product? Find(params object[] keys)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public ValueTask<Product?> FindAsync(params object[] keys)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public ValueTask<Product?> FindAsync(CancellationToken token, params object[] keys)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Product First(Expression<Func<Product, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<Product> FirstAsync(Expression<Func<Product, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Product? FirstOrDefault(Expression<Func<Product, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<Product?> FirstOrDefaultAsync(Expression<Func<Product, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void SetOriginalValue<TValue>(Product entity, string propertyName, TValue value)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public IQueryable<TResult> Transform<TResult>(Expression<Func<Product, TResult>> predicate)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Product Update(Product entity)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Product Update(Product oldEntity, Product newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
