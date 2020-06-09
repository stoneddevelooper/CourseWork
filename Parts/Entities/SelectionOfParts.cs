using System.Collections.Generic;

namespace Parts.Entities
{
    public class SelectionOfParts
    {
        public ISet<int> PartsId { get; set; }
        public int SelectionId { get; set; }
        public string Name { get; set; }
    }
}
