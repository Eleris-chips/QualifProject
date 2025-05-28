using QualifProject.Application.Repositories;
using QualifProject.Domain.Entities;

namespace QualifProject.Infrastructure.Repository;

public class Repository<TEntity> : IRepository<TEntity>
    where TEntity : class, IEntity, IAggregateRoot
{
    #region Private Fields

    private readonly List<TEntity> _entities = [];
    private int _nextId = 0;

    #endregion Private Fields

    #region Public Methods

    /// <inheritdoc/>
    public void Add(TEntity entity)
    {
        _nextId++;
        entity.SetId(_nextId);
        _entities.Add(entity);
    }

    /// <inheritdoc/>
    public void Delete(TEntity entity)
    {
        _entities.Remove(entity);
    }

    /// <inheritdoc/>
    public IEnumerable<TEntity> GetAll()
    {
        return _entities;
    }

    /// <inheritdoc/>
    public TEntity? GetById(int id)
    {
        return _entities.FirstOrDefault(t => t.Id == id);
    }

    /// <inheritdoc/>
    public void Update(TEntity entity)
    {
        // No real database, so no actions.
    }

    #endregion Public Methods
}