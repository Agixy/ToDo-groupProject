using ToDo.Model.Model;

namespace ToDo.App.ViewModels
{
    public class TaskPatchDto
    {
        public Status? NewStatus { get; set; }
    }
}