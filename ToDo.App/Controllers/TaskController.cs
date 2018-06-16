using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Rest.TransientFaultHandling;
using ToDo.App.ViewModels;
using ToDo.Model.Model;
using ToDo.DBConnection.DatabaseAccess;

namespace ToDo.App.Controllers
{
    [Route("api/[controller]")]
    public class TaskController : Controller
    {
        private readonly ServerContext _serverContext;
        private readonly ITaskMapper _taskMapper;

        public TaskController(ServerContext serverContext, ITaskMapper taskMapper)
        {
            _serverContext = serverContext;
            _taskMapper = taskMapper;
        }

        [HttpPost]
        public void AddTask([FromBody] TaskDto taskDto)
        {
            if (taskDto != null)
            {
                var task = _taskMapper.ConvertToTask(taskDto);
                _serverContext.Add(task);
                _serverContext.SaveChanges();
            }
            else
            {           
                throw new HttpRequestWithStatusException("Pusty obiekt"){StatusCode = HttpStatusCode.BadRequest};
            }

        }

        [HttpDelete("{id}")]
        public void DeleteTask(int id)
        {
            
        }

        [HttpGet("{id}")]
        public TaskDto GetTask()
        {
            return new TaskDto
            {
                Title = "Zadanie2",
                Deadline = DateTime.Now,
                Description = "Opis2",
                Priority = PriorityState.Low
            };
        }

        [HttpGet]
        public IEnumerable<TaskDto> GetTasks()
        {
            return new List<TaskDto>
            {
                new TaskDto
                {
                    Title = "Zadanie1",
                    Deadline = DateTime.Today,
                    Description = "Opis",
                    Priority = PriorityState.High
                },
                new TaskDto
                {
                    Title = "Zadanie2",
                    Deadline = DateTime.Now,
                    Description = "Opis2",
                    Priority = PriorityState.Low
        }
            };
        }

        [HttpPatch("{id}")]
        public void PatchTask()
        {

        }
    }
}
