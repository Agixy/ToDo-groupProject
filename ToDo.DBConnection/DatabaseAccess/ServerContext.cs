﻿using Microsoft.EntityFrameworkCore;
using ToDo.Model.Model;

namespace ToDo.DBConnection.DatabaseAccess
{
    public class ServerContext : DbContext
    {
        public ServerContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}
