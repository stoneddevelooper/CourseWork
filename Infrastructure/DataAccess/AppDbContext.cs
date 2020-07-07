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

        public AppDbContext ()
        {
            Database.EnsureCreated();
        }

        public DbSet<Part> Parts { get; set; }
        public DbSet<Maker> Makers { get; set; }
        public DbSet<Selection> Selections { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PartInSelection>().HasKey(cs => new { cs.PartId, cs.SelectionId });
            modelBuilder.Entity<PartInSelection>().HasOne(cs => cs.Selection)
                .WithMany(c => c.PartInSelelections)
                .HasForeignKey(cs => cs.SelectionId);
            modelBuilder.Entity<PartInSelection>().HasOne(cs => cs.Part)
                .WithMany(s => s.PartInSelelections)
                .HasForeignKey(cs => cs.PartId);
        }
    }
}
