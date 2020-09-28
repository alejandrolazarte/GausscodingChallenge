using Domain.Entities;

namespace Domain.Repository.Base
{
    public interface IRepository<T> : 
        IRepositoryQuery<T>, 
        IRepositoryPersistence<T> 
        where T : EntityBase
    {
    }
}
