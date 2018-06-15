using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Rest.TransientFaultHandling;
using Newtonsoft.Json;
using ToDo.App.ViewModels;

namespace ToDo.App.Controllers
{
    [Route("api/[controller]")]
    public class TaskController : Controller
    {
        [HttpPost]
        public void AddTask([FromBody] TaskDto task)
        {
            if (task != null)
            {
                // add to base
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
            return new TaskDto();
        }

        [HttpGet]
        public IEnumerable<TaskDto> GetTasks()
        {
            return new List<TaskDto>{new TaskDto(), new TaskDto()};
        }

        [HttpPatch("{id}")]
        public void PatchTask()
        {

        }
    }
}
