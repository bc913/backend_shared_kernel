using System.Collections.Generic;

namespace Bcan.Backend.SharedKernel.Contracts
{
    public interface IHasDomainEvents
    {
        public IReadOnlyCollection<DomainEvent> DomainEvents { get; }
    }
}