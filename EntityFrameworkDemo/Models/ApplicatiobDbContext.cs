using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkDemo.Models
{
    public class ApplicatiobDbContext:DbContext
    {
        public ApplicatiobDbContext(DbContextOptions<ApplicatiobDbContext> options):base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
