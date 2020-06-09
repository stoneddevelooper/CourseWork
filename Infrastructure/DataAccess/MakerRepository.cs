using Parts.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.DataAccess
{
    public class MakerRepository : AuditableRepository<Maker>, IMakerRepository
    {
        private readonly AppDbContext _dbContext;
        public MakerRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public IReadOnlyList<Maker> GetMakerByName(string name)
        {
            return _dbContext.Makers.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();
        }

        public IReadOnlyList<Maker> GetMakerByFullName(string fullNameCompany)
        {
            return _dbContext.Makers.Where(x => x.FullNameCompany.ToLower().Contains(fullNameCompany.ToLower())).ToList();
        }
    }
}
