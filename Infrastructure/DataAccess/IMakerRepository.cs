using Parts.Entities;
using Infrastructure.DataAccess.CRUDInterfaces;
using System.Collections.Generic;


namespace Infrastructure.DataAccess
{
    public interface IMakerRepository : ICanAddEntity<Maker>, ICanUpdateEntiry<Maker>, ICanGetEntity<Maker>
    {
        IReadOnlyList<Maker> GetMakerByName(string name);
        IReadOnlyList<Maker> GetMakerByFullName(string fullNameCompany);
    }
}
