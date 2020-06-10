using Newtonsoft.Json;
using System.Collections.Generic;

namespace Parts.Entities
{
    public class Selection : AuditableEntity
    {
        public Selection()
        {

        }

        public string Name { get; set; }
        public Selection(string name)
        {
            Name = name;
        }
        
        [JsonIgnore]
        public virtual ISet<Part> Parts { get; set; }
    }
}
