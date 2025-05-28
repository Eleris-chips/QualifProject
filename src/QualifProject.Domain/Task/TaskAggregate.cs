using QualifProject.Domain.Entities;

namespace QualifProject.Domain.Task;

public class TaskAggregate : IEntity, IAggregateRoot
{
    #region Public Constructors

    public TaskAggregate(string description, bool isCompleted, string title)
    {
        CreatedDate = DateTime.Now;
        Description = description;
        IsCompleted = isCompleted;
        Title = title;
    }

    #endregion Public Constructors

    #region Public Properties

    public DateTime? CompletionDate { get; private set; }
    public DateTime CreatedDate { get; }
    public string Description { get; private set; }
    public int Id { get; private set; }
    public bool IsCompleted { get; private set; }
    public string Title { get; private set; }

    #endregion Public Properties

    #region Public Methods

    /// <summary>
    /// Complete the current task.
    /// </summary>
    public void CompleteTask()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Configure the current task.
    /// </summary>
    /// <param name="title">The title to set.</param>
    /// <param name="description">The description to set.</param>
    public void ConfigureTask(string title, string description)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Set the current task id.
    /// </summary>
    /// <param name="taskId">The id to set.</param>
    public void SetId(int taskId) => Id = taskId;

    #endregion Public Methods
}