using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetGram.Infra.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> Get(Guid id);
        IQueryable<T> GetAll();
        void Save(T entity);
        void Update(T entity);
        void Delete(T id);


    }
}
