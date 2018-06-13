using System.Collections.Generic;

namespace ToDo.Model.Model
{
    public class User : BaseModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public IList<Task> Tasks { get; set; }
    }
}
