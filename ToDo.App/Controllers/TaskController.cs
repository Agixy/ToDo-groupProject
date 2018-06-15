using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Rest.TransientFaultHandling;
using Newtonsoft.Json;
using ToDo.App.ViewModels;
using ToDo.Model.Model;

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
            //logika przycisku delete, usuwanie rekordu z bazy
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
