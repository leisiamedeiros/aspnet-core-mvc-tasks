using Microsoft.EntityFrameworkCore;

namespace Tasks.Models.Data
{
    public class DbInitializer 
    {
        public static void Initialize(TaskContext context)
        {
            context.Database.Migrate();
        }    
    }
}