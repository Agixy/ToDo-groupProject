using System.Collections.Generic;

namespace ToDo.Model.Model
{
    class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public IList<Task> Tasks { get; set; }
    }
}
