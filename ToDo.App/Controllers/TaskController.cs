using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ToDo.App.Controllers
{
    [Route("api/[controller]")]
    public class TaskController : Controller
    {
        [HttpPost]
        public void AddTask([FromBody])
        {

        }

        public void DeleteTask()
        {

        }

        public void GetTask()
        {

        }

        public void PatchTask()
        {

        }
    }
}
