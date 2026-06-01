using System.Data.Entity;
using WorkProgressManagement.Models;

namespace WorkProgressManagement.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("WorkProgressDb")
        {
        }

        public DbSet<Project> Projects { get; set; }

        public DbSet<WorkTask> WorkTasks { get; set; }
    }
}