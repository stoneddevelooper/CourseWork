using Newtonsoft.Json;
using System.Collections.Generic;

namespace Parts.Entities
{
    public class Selection : AuditableEntity
    {
        public Selection()
        {
            PartInSelelections = new List<PartInSelection>();
        }

        public string Name { get; set; }
        public int PartId { get; set; }
        public Selection(string name)
        {
            Name = name;
        }
        
        public List<PartInSelection> PartInSelelections { get; set; }
    }
}
