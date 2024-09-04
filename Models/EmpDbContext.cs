using Microsoft.EntityFrameworkCore;
namespace WebApplication2.Models
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext(DbContextOptions<EmpDbContext> x ) :base(x) {}

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasKey(a => a.E_Id);
        }
    }
}
