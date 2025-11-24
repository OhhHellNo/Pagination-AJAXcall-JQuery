using Microsoft.EntityFrameworkCore;
using pagination.Models;

namespace pagination.NewFolder
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Add DbSets for your models
        public DbSet<UserModel> Users { get; set; }
        public DbSet<TodoModel> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // You can add configurations here later if needed
        }
    }
}
