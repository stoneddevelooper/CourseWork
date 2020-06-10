using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.DataAccess.CRUDInterfaces;
using Parts.Entities;

namespace Infrastructure.DataAccess
{
    interface ISelectionOfPartsRepository : ICanAddEntity<Selection>, ICanDeleteEntity<Selection>, ICanGetEntity<Selection>, ICanUpdateEntiry<Selection>
    {
    }
}
