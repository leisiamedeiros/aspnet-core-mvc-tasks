using Microsoft.EntityFrameworkCore;

namespace Tasks.Models.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        { }

        public DbSet<Task> Tasks { get; set; }
        
    }
}