using QualifProject.Application.Models;

namespace QualifProject.Application.Services.Description;

public interface ITaskService
{
    #region Public Methods

    /// <summary>
    /// Add the task to create in the system.
    /// </summary>
    /// <param name="task">The task to create.</param>
    /// <returns>The created task.</returns>
    TaskDto AddTask(TaskToCreateDto task);

    /// <summary>
    /// Complete a given task.
    /// </summary>
    /// <param name="id">The task id.</param>
    /// <returns>The task in dto format.</returns>
    TaskCompletedDto CompleteTask(int id);

    /// <summary>
    /// Delete task.
    /// </summary>
    /// <param name="id">The task id to delete.</param>
    void DeleteTask(int id);

    /// <summary>
    /// Get all tasks in the system.
    /// </summary>
    /// <returns>The tasks in dto format.</returns>
    IEnumerable<TaskDto> GetAllTasks();

    /// <summary>
    /// Get a task by its identifier.
    /// </summary>
    /// <param name="id">The task id.</param>
    /// <returns>The task in dto format.</returns>
    TaskDto GetTaskById(int id);

    /// <summary>
    /// Update a task in the system.
    /// </summary>
    /// <param name="task">The task to update.</param>
    /// <returns>The task in dto format.</returns>
    TaskDto UpdateTask(TaskToUpdateDto task);

    #endregion Public Methods
}