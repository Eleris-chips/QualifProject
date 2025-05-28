using Microsoft.AspNetCore.Mvc;
using QualifProject.Application.Models;
using QualifProject.Application.Services.Description;

namespace QualifProject.Controllers;

[ApiController]
[Route("[controller]")]
public class TasksController : ControllerBase
{
    #region Private Fields

    private readonly ITaskService _taskService;

    #endregion Private Fields

    #region Public Constructors

    public TasksController(ITaskService taskService)
    {
        _taskService = taskService;
    }

    #endregion Public Constructors

    #region Public Methods

    [HttpPost]
    public ActionResult<Task> CreateTask(TaskToCreateDto taskToCreate)
    {
        var task = _taskService.AddTask(taskToCreate);
        return CreatedAtAction(nameof(GetTask), new { id = task?.Id }, task);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteTask(int id)
    {
        _taskService.DeleteTask(id);
        return NoContent();
    }

    [HttpGet("{id}")]
    public ActionResult<Task> GetTask(int id)
    {
        var task = _taskService.GetTaskById(id);
        if (task == null)
        {
            return NotFound();
        }
        return Ok(task);
    }

    [HttpGet]
    public ActionResult<IEnumerable<Task>> GetTasks()
    {
        return Ok(_taskService.GetAllTasks());
    }

    [HttpPut("{id}")]
    public IActionResult UpdateTask(int id, TaskToUpdateDto task)
    {
        if (id != task.Id)
        {
            return BadRequest();
        }
        var existingTask = _taskService.GetTaskById(id);
        if (existingTask == null)
        {
            return NotFound();
        }
        _taskService.UpdateTask(task);
        return NoContent();
    }

    #endregion Public Methods
}