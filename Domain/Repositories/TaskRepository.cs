using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tasks.Persistence.Contexts;
using TTask = Tasks.Domain.Models.Task;

namespace Tasks.Domain.Repositories
{
    public class TaskRepository
    {
        protected readonly TaskContext _context;
        public TaskRepository(TaskContext context)
        {
            _context = context;
        }

        public async Task AddAsync(TTask task)
        {
            await _context.Tasks.AddAsync(task);
        }

        public async Task<TTask> FindByIdAsync(int id)
        {
            return await _context.Tasks.FindAsync(id);
        }

        public async Task<List<TTask>> ListAsync()
        {
            return await _context.Tasks.ToListAsync();
        }

        public void Remove(TTask task)
        {
            _context.Remove(task);
        }

        public void Update(TTask task)
        {
            _context.Update(task);
        }

        public bool Exists(int id)
        {
            return _context.Tasks.Any(e => e.Id == id);
        }

    }
}