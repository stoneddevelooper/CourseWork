using Newtonsoft.Json;
using System.Collections.Generic;

namespace Parts.Entities
{
    public class Selection : AuditableEntity
    {
        public Selection()
        {

        }
        public Selection(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        
        
        [JsonIgnore]
        public virtual ISet<Part> Parts { get; set; }
    }
}
