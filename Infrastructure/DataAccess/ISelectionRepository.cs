using Parts.Entities;
using System.Collections.Generic;

namespace Infrastructure.DataAccess
{
    public interface ISelectionRepository
    {
        IReadOnlyList<Selection> GetAllSets();

        Selection Get(int id);
        void Add(Selection selection);
        void Update(Selection selection);
        void Remove(Selection selection);

        IReadOnlyList<Selection> GetSetByName(string name);
    }
}
