using System.Collections.Generic;

namespace Bcan.Backend.SharedKernel
{
    public abstract class HasDomainEventsBase : Contracts.IHasDomainEvents
    {
        #region Fields & Properties
        private List<DomainEvent> _domainEvents;
        public IReadOnlyCollection<DomainEvent> DomainEvents => _domainEvents?.AsReadOnly();
        #endregion

        #region API
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
        #endregion
    }
}