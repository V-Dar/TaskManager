using Microsoft.EntityFrameworkCore;

namespace TaskManager.Api.Models.Data
{
    public class ApplitacionContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Desk> Desks { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public ApplitacionContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
            if(Users.Any(u => u.Status == UserStatus.Admin) == false)
            {
                Users.Add(new User("Viktor", "Dar", "admin", "qwerty", UserStatus.Admin));
            }
        }
    }
}
