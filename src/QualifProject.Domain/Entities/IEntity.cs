namespace QualifProject.Domain.Entities;

public interface IEntity
{
    #region Public Properties

    /// <summary>
    /// The entity's id.
    /// </summary>
    public int Id { get; }

    #endregion Public Properties

    #region Public Methods

    /// <summary>
    /// Set the entity's id.
    /// </summary>
    /// <param name="id">The id.</param>
    public void SetId(int id);

    #endregion Public Methods
}