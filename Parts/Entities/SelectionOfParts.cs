using System.Collections.Generic;

namespace Parts.Entities
{
    public class SelectionOfParts : AuditableEntity
    {
        public int PartId { get; set; }
        public string Name { get; set; }

        public SelectionOfParts()
        {

        }

        public SelectionOfParts(string name)
        {
            Name = name;
        }
    }
}
