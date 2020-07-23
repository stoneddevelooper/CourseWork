using Parts.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.DataAccess
{
    public class SelectionRepository : AuditableRepository<Selection>, ISelectionRepository
    {
        private readonly AppDbContext _dbContext;
        public SelectionRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public override Selection Get(int id)
        {
            return _dbContext.Selections.Include(b => b.PartInSelelections).FirstOrDefault(b => b.Id == id);
        }
        public IReadOnlyList<Selection> GetAllSets()
        {
            return _dbContext.Selections.Include(b => b.PartInSelelections).ToList();
        }

        public IReadOnlyList<Selection> GetSetByName(string name)
        {
            return _dbContext.Selections.Where(x => x.Name.ToLower().Contains(name.ToLower())).Include(x => x.PartInSelelections).ToList();
        }
    }
}
