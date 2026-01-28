using System;

namespace Bcan.Backend.SharedKernel
{
    public abstract class Entity : HasDomainEventsBase
    {
        public int Id { get; set; }
    }

    public abstract class Entity<IdType> : HasDomainEventsBase
        where IdType : struct, IEquatable<IdType>
    {
        public IdType Id { get; set; } = default!;
    }
}