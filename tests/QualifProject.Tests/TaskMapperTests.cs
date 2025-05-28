using NFluent;
using QualifProject.Application.Mapper;
using QualifProject.Domain.Task;

namespace QualifProject.Tests;

[TestClass]
public class TaskMapperTests
{
    #region Public Methods

    [TestMethod]
    public void GivenTaskAggregateWhenToDtoThenTaskDto()
    {
        var task = new TaskAggregate("MyTask", false, "My task");
        task.SetId(1);

        var taskDto = task.ToDto();

        Check.That(taskDto.Id).IsEqualTo(task.Id);
        Check.That(taskDto.Infos.Description).IsEqualTo(task.Description);
        Check.That(taskDto.Infos.Title).IsEqualTo(task.Title);
    }

    #endregion Public Methods
}