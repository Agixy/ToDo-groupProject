using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Rest.TransientFaultHandling;
using ToDo.App.ViewModels;

namespace ToDo.App.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [HttpPost]
        public void AddUser([FromBody] UserDto user)
        {
            if (user != null)
            {
                // add to base
            }
            else
            {
                throw new HttpRequestWithStatusException("Pusty obiekt");
            }

        }

        public void DeleteUser()
        {

        }

        public TaskDto GetUser()
        {
            return new TaskDto();
        }

        //public IEnumerable<UserDto> GetUsers()
        //{
        //    //return new List<TaskDto> { new TaskDto(), new TaskDto() };
        //}
    }
}
