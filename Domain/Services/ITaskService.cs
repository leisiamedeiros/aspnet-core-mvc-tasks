using System.Collections.Generic;
using System.Threading.Tasks;
using TTask = Tasks.Domain.Models.Task;

namespace Tasks.Domain.Services
{
    public interface ITaskService
    {
        Task<IEnumerable<TTask>> ListAsync();
        Task<TTask> FindByIdAsync(int ind);
        Task AddAsync(TTask task);
        void Update(TTask task);
        void Remove(TTask task);
        bool Exists(int id);
    }
}