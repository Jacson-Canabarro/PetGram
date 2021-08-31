using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PetGram.Infra.Interfaces
{
   public interface IBaseService<T> where T : class
    {

        Task<T> Get(Guid id);
        List<T> GetAll();
        void Save(T entity);
        void Update(T entity);
        void Delete(T id);
    }
}
