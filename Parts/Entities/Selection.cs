using Newtonsoft.Json;
using System.Collections.Generic;

namespace Parts.Entities
{
    public class Selection : SelectionOfParts
    {
        public Selection()
        {

        }
        public Selection(string name) : base(name)
        {
            
        }
        
        [JsonIgnore]
        public virtual ISet<Part> Parts { get; set; }
    }
}
