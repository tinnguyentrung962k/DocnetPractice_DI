using Microsoft.EntityFrameworkCore;

namespace DemoProject
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=(local);database=CarStore;uid=sa;pwd=12345;TrustServerCertificate=True");
        }
        public DbSet<Car> Cars { get; set; }
    }
}
