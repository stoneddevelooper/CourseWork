using Parts.Entities;
using System.Collections.Generic;

namespace Infrastructure.DataAccess
{
    public interface IPartRepository
    {
        IReadOnlyList<Part> GetAll();

        Part Get(int id);
        void Add(Part part);
        void Update(Part part);

        IReadOnlyList<Part> GetPartsByName(string name);
    }
}
