using NFluent;
using QualifProject.Application.Models;
using QualifProject.Application.Services.Description;

namespace QualifProject.Tests
{
    [TestClass]
    public class TaskServiceTests : ServiceTestBase<ITaskService>
    {
        #region Public Methods

        #region AddTask

        [TestMethod]
        public void GivenNewTaskWhenAddTaskThenOk()
        {
            var newTask = new TaskToCreateDto(new TaskInfosDto("MyTitle", "MyDescription"));

            var taskCreated = Service.AddTask(newTask);

            Check.That(taskCreated.Id).IsEqualTo(1);
            Check.That(taskCreated.Infos.Title).IsEqualTo("MyTitle");
            Check.That(taskCreated.Infos.Description).IsEqualTo("MyDescription");
        }

        #endregion AddTask

        #region UpdateTask

        [TestMethod]
        public void GivenTaskToUpdateWhenUpdateTaskThenOk()
        {
            var taskId = PopulateSystem();
            var taskToUpdate = new TaskToUpdateDto(taskId, new TaskInfosDto("NewTitle", "NewDescription"));
            var updatedTask = Service.UpdateTask(taskToUpdate);

            Check.That(updatedTask.Id).IsEqualTo(taskId);
            Check.That(updatedTask.Infos.Title).IsEqualTo("NewTitle");
            Check.That(updatedTask.Infos.Description).IsEqualTo("NewDescription");
        }

        #endregion UpdateTask

        #region CompleteTask

        [TestMethod]
        public void GivenTaskIdWhenCompleteTaskThenOk()
        {
            var taskId = PopulateSystem();

            var updatedTask = Service.CompleteTask(taskId);

            Check.That(updatedTask.Id).IsEqualTo(taskId);
            Check.That(updatedTask.CompletionDate).IsNotEqualTo(default(DateTime));
        }

        #endregion CompleteTask

        #region GetTask

        [TestMethod]
        public void GivenTaskIdWhenGetTaskThenTaskReturned()
        {
            var taskId = PopulateSystem();

            var task = Service.GetTaskById(taskId);

            Check.That(task).IsNotNull();
            Check.That(task.Id).IsEqualTo(taskId);
        }

        #endregion GetTask

        #region GetAllTasks

        [TestMethod]
        public void GivenPopulatedDatabaseWhenGetAllTasksThenReturnAllTasks()
        {
            PopulateSystem();

            var tasks = Service.GetAllTasks();

            Check.That(tasks.Count()).IsGreaterOrEqualThan(1);
        }

        #endregion GetAllTasks

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// Populate the system to have objects in the memory.
        /// </summary>
        /// <returns>The id of the task created.</returns>
        private int PopulateSystem()
        {
            var newTask = new TaskToCreateDto(new TaskInfosDto("MyTitle", "MyDescription"));
            var taskCreated = Service.AddTask(newTask);

            return taskCreated.Id;
        }

        #endregion Private Methods
    }
}