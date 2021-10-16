using System.Collections.Generic;

namespace Bcan.Backend.SharedKernel
{
    /// <summary>
    /// Base type for all entities which tracks state using a given Id.
    /// </summary>
    /// <typeparam name="TypeId">Generic type to represent the id.</typeparam>
    public abstract class BaseEntity<TypeId>
    {
        public TypeId Id { get; set; }

        public List<BaseDomainEvent> Events = new List<BaseDomainEvent>();
    }
}