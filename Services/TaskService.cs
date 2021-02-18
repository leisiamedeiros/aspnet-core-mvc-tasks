using System.Collections.Generic;
using System.Threading.Tasks;
using Tasks.Domain.Repositories;
using Tasks.Domain.Services;

namespace Tasks.Services
{
    public class TaskService : ITaskService
    {
        private readonly TaskRepository _repository;

        public TaskService(TaskRepository repository)
        {
            _repository = repository;
        }

        public async System.Threading.Tasks.Task AddAsync(Domain.Models.Task task)
        {
            await _repository.AddAsync(task);
        }

        public bool Exists(int id)
        {
            return _repository.Exists(id);
        }

        public async Task<Domain.Models.Task> FindByIdAsync(int id)
        {
            return await _repository.FindByIdAsync(id);
        }

        public async Task<IEnumerable<Domain.Models.Task>> ListAsync()
        {
            return await _repository.ListAsync();
        }

        public void Remove(Domain.Models.Task task)
        {
            _repository.Remove(task);
        }

        public void Update(Domain.Models.Task task)
        {
            _repository.Update(task);
        }
    }
}