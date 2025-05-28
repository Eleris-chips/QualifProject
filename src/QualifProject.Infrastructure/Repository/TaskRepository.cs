using QualifProject.Application.Repositories;
using Task = QualifProject.Domain.Task.Task;

namespace QualifProject.Infrastructure.Repository;

public class TaskRepository : ITaskRepository
{
    #region Private Fields

    private readonly List<Task> _tasks = [];
    private int _nextId = 0;

    #endregion Private Fields

    #region Public Methods

    public void AddTask(Task task)
    {
        _nextId++;
        task.SetTaskId(_nextId);
        _tasks.Add(task);
    }

    public void DeleteTask(int id)
    {
        var task = GetTaskById(id);
        if (task != null)
        {
            _tasks.Remove(task);
        }
    }

    public IEnumerable<Task> GetAllTasks()
    {
        return _tasks;
    }

    public Task? GetTaskById(int id)
    {
        return _tasks.FirstOrDefault(t => t.Id == id);
    }

    public void UpdateTask(Task task)
    {
        // No real database, so no actions.
    }

    #endregion Public Methods
}