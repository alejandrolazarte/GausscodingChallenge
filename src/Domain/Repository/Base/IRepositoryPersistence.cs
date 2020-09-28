using Domain.Entities;
using System.Threading.Tasks;

namespace Domain.Repository.Base
{
    public interface IRepositoryPersistence<T> where T : EntityBase
    {
        Task Add(T entity);

        Task Update(T entity);

        Task Delete(T entity);
    }
}
