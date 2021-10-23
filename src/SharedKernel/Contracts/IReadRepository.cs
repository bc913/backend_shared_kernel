using Ardalis.Specification;

namespace Bcan.Backend.SharedKernel.Contracts
{
    public interface IReadRepository<T> : 
        IReadRepositoryBase<T> where T : class, IAggregateRoot
    {

    }
}