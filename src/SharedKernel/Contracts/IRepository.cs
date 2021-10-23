using Ardalis.Specification;

namespace Bcan.Backend.SharedKernel.Contracts
{
    public interface IRepository<T> : 
        IRepositoryBase<T> where T : class, IAggregateRoot
    {

    }
}