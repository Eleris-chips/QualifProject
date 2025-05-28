using Task = QualifProject.Business.Task.Task;

namespace QualifProject.Application.Repositories;

public interface ITaskRepository
{
    #region Public Methods

    void AddTask(Task task);

    void DeleteTask(int id);

    IEnumerable<Task> GetAllTasks();

    Task? GetTaskById(int id);

    void UpdateTask(Task task);

    #endregion Public Methods
}