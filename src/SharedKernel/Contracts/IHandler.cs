using System.Threading.Tasks;

namespace Bcan.Backend.SharedKernel.Contracts
{
    public interface IHandler<T> where T : DomainEvent
    {
        Task HandleAsync(T args);
    }
}