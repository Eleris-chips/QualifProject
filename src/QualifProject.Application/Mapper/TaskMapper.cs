using QualifProject.Application.Models;
using QualifProject.Domain.Task;

namespace QualifProject.Application.Mapper;

public static class TaskMapper
{
    #region Public Methods

    /// <summary>
    /// Map a task aggregate to a dto.
    /// </summary>
    /// <param name="entity">The entity to map.</param>
    /// <returns>A Task Dto.</returns>
    public static TaskDto ToDto(this TaskAggregate entity)
    => throw new NotImplementedException();

    #endregion Public Methods
}