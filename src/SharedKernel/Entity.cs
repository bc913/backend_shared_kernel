using System.Collections.Generic;

namespace Bcan.Backend.SharedKernel
{
    public abstract class Entity<IdType> : BaseEntity<IdType>, Contracts.IHasDomainEvents
    {
        public Entity(IdType id) : base(id) {}

        #region Fields & Properties
        private List<DomainEvent> _domainEvents;
        public IReadOnlyCollection<DomainEvent> DomainEvents => _domainEvents?.AsReadOnly();

        #endregion

        public void AddDomainEvent(DomainEvent eventObj)
        {
            _domainEvents = _domainEvents ?? new List<DomainEvent>();
            _domainEvents.Add(eventObj);
        }

        public void RemoveDomainEvent(DomainEvent eventObj)
        {
            _domainEvents?.Remove(eventObj);
        }

        public void ClearDomainEvents()
        {
            _domainEvents?.Clear();
        }
    }
}