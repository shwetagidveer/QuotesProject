using Microsoft.EntityFrameworkCore;

namespace CrudApi
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Thought> Thoughts { get; set; }
    }
}
