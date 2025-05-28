using QualifProject.Application.Models;
using QualifProject.Application.Repositories;
using QualifProject.Application.Services.Description;
using QualifProject.Domain.Task;

namespace QualifProject.Application.Services;

public class TaskService : ITaskService
{
    #region Private Fields

    /// <summary>
    /// The task repository.
    /// </summary>
    private readonly IRepository<TaskAggregate> _taskRepository;

    #endregion Private Fields

    #region Public Constructors

    public TaskService(IRepository<TaskAggregate> taskRepository)
    {
        _taskRepository = taskRepository;
    }

    #endregion Public Constructors

    #region Public Methods

    /// <inheritdoc/>
    public TaskDto AddTask(TaskToCreateDto task)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TaskCompletedDto CompleteTask(int id)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public void DeleteTask(int id)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public IEnumerable<TaskDto> GetAllTasks()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TaskDto GetTaskById(int id)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public TaskDto UpdateTask(TaskToUpdateDto task)
    {
        throw new NotImplementedException();
    }

    #endregion Public Methods
}