using System;

namespace Parts.Entities
{
    public abstract class AuditableEntity : Entity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; } //? - null is accepted
    }
}