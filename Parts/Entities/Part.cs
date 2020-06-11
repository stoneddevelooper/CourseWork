using Newtonsoft.Json;
using System.Collections.Generic;

namespace Parts.Entities
{
    public enum PriceCategory
    {
        Low = 3, Average = 2, High = 1
    }
    public class Part : AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int MakerId { get; set; }
        public virtual Maker Maker { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public PriceCategory PriceId { get; set; }


        public Part(int makerId, string model, double price, string name, string description)
        {
            MakerId = makerId;
            Model = model;
            Price = price;
            Name = name;
            Description = description;
            PriceId = price < 10_000 ? PriceCategory.Low
                : price >= 10_000 && price < 30_000 ? PriceCategory.Average
                : PriceCategory.High;
        }
        public Part()
        {

        }
        /*
                [JsonIgnore]
                public virtual ISet<Selection> Selections { get; set; }*/
        //public List<PartInSelection> PartInSelelections { get; set; }
    }
}
