using Microsoft.EntityFrameworkCore;
using Parts.Entities;

namespace Infrastructure.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Part> Parts { get; set; }
        public DbSet<Maker> Makers { get; set; }
        public DbSet<Selection> Selections { get; set; }
    }
}
