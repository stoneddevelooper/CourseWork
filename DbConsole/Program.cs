using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Infrastructure.DataAccess;
using System;
using Parts.Entities;

namespace DbConsole
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PartsConfig;Trusted_Connection=True;", b => b.MigrationsAssembly("Infrastructure"));
            return new AppDbContext(optionsBuilder.Options);
        }
    }
    class Program
    {
        private static readonly AppDbContext _appContext;
        private static IPartRepository _partRepository;
        private static IMakerRepository _makerRepository;
        private static ISelectionRepository _selectionRepository;

        static Program()
        {
            AppDbContextFactory factory = new AppDbContextFactory();
            _appContext = factory.CreateDbContext(null);
            _makerRepository = new MakerRepository(_appContext);
            _partRepository = new PartRepository(_appContext);
            _selectionRepository = new SelectionRepository(_appContext);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            Maker maker = new Maker("Intel", "USA", "Intel Corp.");
            _makerRepository.Add(maker);
            Part part = new Part(1, "Core I7 - 9700K OEM", 25_850.0, "CPU", "LGA 1151-v2, 8 x 3600 Ã√ˆ, L2 - 2 Ã¡, L3 - 12 Ã·, 2ıDDR4-2666 Ã√ˆ, Intel UHD Graphics 630, TDP 95 ¬Ú");
            _partRepository.Add(part);
            Part part_1 = new Part(1, "Intel 545s Series", 7_599.0, "SSD", "512 √¡, SATA III, TLC 3D NAND, 500 Ã·‡ÈÚ / ÒÂÍ");
            _partRepository.Add(part_1);
            Selection selection = new Selection("High qiality");
            _selectionRepository.Add(selection);
        }
    }
}
