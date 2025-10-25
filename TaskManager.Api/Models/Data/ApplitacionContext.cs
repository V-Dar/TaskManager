﻿using Microsoft.EntityFrameworkCore;
using TaskManager.Common.Models;

namespace TaskManager.Api.Models.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Desk> Desks { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public ApplicationContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
            if(Users.Any(u => u.Status == UserStatus.Admin) == false)
            {
                Users.Add(new User("Viktor", "Dar", "admin", "qwerty", UserStatus.Admin));
            }
        }
    }
}
