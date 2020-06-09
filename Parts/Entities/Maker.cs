using Newtonsoft.Json;
using System.Collections.Generic;

namespace Parts.Entities
{
    public class Maker : AuditableEntity
    {
        public Maker()
        {

        }

        public string Name { get; set; }
        public string Country { get; set; }
        public string FullNameCompany { get; set; }


        public Maker(string name, string country, string fullNameCompany)
        {
            Name = name;
            Country = country;
            FullNameCompany = fullNameCompany;
        }

        [JsonIgnore] //connection between several details and 1 maker
        public virtual ICollection<Part> Parts { get; set; }
    }
}
