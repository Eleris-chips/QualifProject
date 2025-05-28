using QualifProject.Domain.Entities;

namespace QualifProject.Application.Repositories;

public interface IRepository<TEntity>
    where TEntity : class, IEntity, IAggregateRoot
{
    #region Public Methods

    /// <summary>
    /// Add a task to the repository.
    /// </summary>
    /// <param name="entity">The entity to add.</param>
    void Add(TEntity entity);

    /// <summary>
    /// Delete a entity from the repository.
    /// </summary>
    /// <param name="entity">The entity to delete.</param>
    void Delete(TEntity entity);

    /// <summary>
    /// Get all the entities from the repository.
    /// </summary>
    /// <returns>The entities.</returns>
    IEnumerable<TEntity> GetAll();

    /// <summary>
    /// Get the entity by id.
    /// </summary>
    /// <param name="id">The entity id to get.</param>
    /// <returns>The entity.</returns>
    TEntity? GetById(int id);

    /// <summary>
    /// Update the entity in the repository.
    /// </summary>
    /// <param name="entity">The entity to update.</param>
    void Update(TEntity entity);

    #endregion Public Methods
}