
using Microsoft.AspNetCore.Mvc;

namespace TaskManagerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private static readonly List<string> Tasks = new()
        {
            "Learn ASP.NET Core",
            "Build Task Manager API",
            "Upload project to GitHub"
        };

        [HttpGet]
        public IActionResult GetTasks()
        {
            return Ok(Tasks);
        }

        [HttpGet("{id}")]
        public IActionResult GetTask(int id)
        {
            if (id < 1 || id > Tasks.Count)
                return NotFound("Task not found.");

            return Ok(Tasks[id - 1]);
        }

        [HttpPost]
        public IActionResult AddTask([FromBody] string task)
        {
            if (string.IsNullOrWhiteSpace(task))
                return BadRequest("Task cannot be empty.");

            Tasks.Add(task);

            return Ok(new
            {
                message = "Task added successfully",
                task
            });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id, [FromBody] string task)
        {
            if (id < 1 || id > Tasks.Count)
                return NotFound("Task not found.");

            if (string.IsNullOrWhiteSpace(task))
                return BadRequest("Task cannot be empty.");

            Tasks[id - 1] = task;

            return Ok("Task updated successfully.");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            if (id < 1 || id > Tasks.Count)
                return NotFound("Task not found.");

            Tasks.RemoveAt(id - 1);

            return Ok("Task deleted successfully.");
        }
    }
}
