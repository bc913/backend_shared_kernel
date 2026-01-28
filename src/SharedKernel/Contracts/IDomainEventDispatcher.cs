using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bcan.Backend.SharedKernel.Contracts
{
    /// <summary>
    /// Simple interface for sending domain events   
    /// </summary>
    public interface IDomainEventDispatcher
    {
        Task DispatchAndClearEvents(IEnumerable<IHasDomainEvents> entitiesWithEvents);
    }
}