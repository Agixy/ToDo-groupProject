using System;
using System.Linq;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using ToDo.DBConnection.DatabaseAccess;

namespace ToDo.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //BuildWebHost(args).Run();
            var optionsBuilder = new DbContextOptionsBuilder<ServerContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ToDoDB;Trusted_Connection=True;");

            using (var context = new ServerContext(optionsBuilder.Options))
            { 
                //var users = context.Users.ToList();
                //foreach (var user in users)
                //{
                //    Console.WriteLine(user.Name);
                //}
            }
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args).UseStartup<Startup>().Build();
    }
}
