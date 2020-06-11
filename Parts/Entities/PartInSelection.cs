using System.Collections.Generic;

namespace Parts.Entities
{
    public class PartInSelection
    {
        public int PartId { get; set; }
        public Part Part { get; set; }
        public int SelectionId { get; set; }
        public Selection Selection { get; set; }
    }
}
