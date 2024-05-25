using System.Linq.Expressions;

namespace AlbatrosPOS.Database.Repositories
{
    /// <summary>
    /// A generic interface for creating repositories of entities.
    /// </summary>
    /// <typeparam name="TEntity">The generic entity type.</typeparam>
    public interface IRepository<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// Gets all the values of an entity.
        /// </summary>
        /// <returns>A collection of values.</returns>
        IQueryable<TEntity> All();

        /// <summary>
        /// Creates a new entity.
        /// </summary>
        /// <returns>The entity created.</returns>
        TEntity Create();

        /// <summary>
        /// Creates the specified entity.
        /// </summary>
        /// <param name="entity">The entity to create.</param>
        /// <returns>The created entity.</returns>
        TEntity Create(TEntity entity);

        /// <summary>
        /// Deletes a specified entity.
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        /// <returns>The result entity.</returns>
        TEntity Delete(TEntity entity);

        /// <summary>
        /// Filters an entity based on the specified conditions.
        /// </summary>
        /// <param name="predicate">The filtering conditions.</param>
        /// <returns>The result queryable entities.</returns>
        // IQueryable<TEntity> Filter(IEnumerable<PropertyFilter> filters);
        IQueryable<TEntity> Filter(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Finds an entity based on its keys.
        /// </summary>
        /// <param name="keys">The keys of the entity to find.</param>
        /// <returns>The result entity.</returns>
        TEntity? Find(params object[] keys);

        /// <summary>
        /// Finds an entity based on its keys asynchronously.
        /// </summary>
        /// <param name="keys">The keys of the entity to find.</param>
        /// <returns>The result entity.</returns>
        ValueTask<TEntity?> FindAsync(params object[] keys);

        /// <summary>
        /// Finds an entity based on its key asynchronously.
        /// </summary>
        /// <param name="token">A token used to cancel the operation.</param>
        /// <param name="keys">The keys of the entity to find.</param>
        /// <returns>The result entity.</returns>
        ValueTask<TEntity?> FindAsync(CancellationToken token, params object[] keys);

        /// <summary>
        /// Gets the first entity based on a predicate.
        /// </summary>
        /// <param name="predicate">The conditions used to filter the entity.</param>
        /// <returns>The first entity based on the predicate.</returns>
        // TEntity First(IEnumerable<PropertyFilter> filters);
        TEntity First(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Gets the first entity based on a predicate asynchronously.
        /// </summary>
        /// <param name="predicate">The conditions used to filter the entity.</param>
        /// <returns>The first entity based on the predicate.</returns>
        // TEntity First(IEnumerable<PropertyFilter> filters);
        Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Gets the first entity based on a predicate or its default value.
        /// </summary>
        /// <param name="predicate">The conditions used to filter the entity.</param>
        /// <returns>The first entity based on the predicate.</returns>
        // TEntity FirstOrDefault(IEnumerable<PropertyFilter> filters);
        TEntity? FirstOrDefault(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Gets the first entity based on a predicate or its default value asynchronously.
        /// </summary>
        /// <param name="predicate">The conditions used to filter the entity.</param>
        /// <returns>The first entity based on the predicate.</returns>
        // Task<TEntity> FirstOrDefaultAsync(IEnumerable<PropertyFilter> filters);
        Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Saves the changes made to the repository.
        /// </summary>
        /// <returns>The number of state entries written to the underlying database.</returns>
        int SaveChanges();

        /// <summary>
        /// Saves the changes made to the repository asynchronously.
        /// </summary>
        /// <returns>The number of state entries written to the underlying database.</returns>
        Task<int> SaveChangesAsync();

        /// <summary>
        /// Transforms an entity based on a predicate.
        /// </summary>
        /// <typeparam name="TResult">The generic result type.</typeparam>
        /// <param name="predicate">The conditions to transform.</param>
        /// <returns>A queryable result.</returns>
        IQueryable<TResult> Transform<TResult>(Expression<Func<TEntity, TResult>> predicate);

        /// <summary>
        /// Updates a specified entity.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        /// <returns>The result entity.</returns>
        TEntity Update(TEntity entity);

        /// <summary>
        /// Updates a specified entity.
        /// </summary>
        /// <param name="oldEntity">The former entity.</param>
        /// <param name="newEntity">The new entity.</param>
        /// <returns>The result entity.</returns>
        TEntity Update(TEntity oldEntity, TEntity newEntity);

        /// <summary>
        /// Sets the original value to an entity.
        /// </summary>
        /// <typeparam name="TValue">The generic value type.</typeparam>
        /// <param name="entity">The entity to update.</param>
        /// <param name="propertyName">The name of the property to update.</param>
        /// <param name="value">The value to update.</param>
        void SetOriginalValue<TValue>(TEntity entity, string propertyName, TValue value);
    }
}
