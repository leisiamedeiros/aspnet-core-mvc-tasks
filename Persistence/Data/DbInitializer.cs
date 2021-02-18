using Microsoft.EntityFrameworkCore;
using Tasks.Persistence.Contexts;

namespace Tasks.Persistence.Data
{
    public class DbInitializer
    {
        public static void Initialize(TaskContext context)
        {
            context.Database.Migrate();
        }
    }
}