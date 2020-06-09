using Parts.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.DataAccess
{
    public class PartRepository : AuditableRepository<Part>, IPartRepository
    {
        private readonly AppDbContext _dbContext;
        public PartRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public override Part Get(int id)
        {
            return _dbContext.Parts.Include(b => b.Maker)
                .Include(b => b.Selections).FirstOrDefault(b => b.Id == id);
        }

        public IReadOnlyList<Part> GetAll()
        {
            return _dbContext.Parts.Include(b => b.Maker)
                .Include(b => b.Selections).ToList();
        }

        public IReadOnlyList<Part> GetPartsByName(string name)
        {
            return _dbContext.Parts.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();
        }
    }
}
