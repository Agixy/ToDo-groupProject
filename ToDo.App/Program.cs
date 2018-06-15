using System;
using System.Linq;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using ToDo.DBConnection.DatabaseAccess;
using ToDo.Model.Model;

namespace ToDo.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //BuildWebHost(args).Run();
            var optionsBuilder = new DbContextOptionsBuilder<ServerContext>();
            optionsBuilder.UseSqlServer("Server=(local);Database=ToDoDB;Integrated Security=true;");

            using (var context = new ServerContext(optionsBuilder.Options))
            {

            }

            Console.ReadKey();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args).UseStartup<Startup>().Build();
    }
}
