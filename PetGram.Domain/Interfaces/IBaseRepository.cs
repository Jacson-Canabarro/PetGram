using System;
using System.Linq;
using System.Threading.Tasks;

namespace PetGram.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> Get(Guid id);
        IQueryable<T> GetAll();
        Task Save(T entity);
        void Update(T entity);
        void Delete(T id);


    }
}
