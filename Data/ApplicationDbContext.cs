using Microsoft.EntityFrameworkCore;

namespace pagination.NewFolder
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
            
        }


        
    }
}
