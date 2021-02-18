using Microsoft.EntityFrameworkCore;
using Tasks.Domain.Models;

namespace Tasks.Persistence.Contexts
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        { }

        public DbSet<Task> Tasks { get; set; }

    }
}