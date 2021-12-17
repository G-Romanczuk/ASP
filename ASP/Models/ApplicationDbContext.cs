using Microsoft.EntityFrameworkCore;

namespace ASP.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
