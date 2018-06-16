using System;
using System.Collections.Generic;
using System.Linq;
using ToDo.Model.Model;

namespace ToDo.App.ViewModels
{
    public class TaskMapper : ITaskMapper
    {
        public Task ConvertToTask(TaskDto taskDto)
        {
            return new Task()
            {
                Deadline = taskDto.Deadline,
                Priority = taskDto.Priority,
                Description = taskDto.Description,
                Title = taskDto.Title,
                Status = taskDto.Status
            };
        }
    }
}
