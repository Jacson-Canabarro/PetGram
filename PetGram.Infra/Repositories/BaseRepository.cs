using PetGram.Domain.Entities;
using PetGram.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace PetGram.Infra.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {

        private readonly PetGramContext _ctx;

        public BaseRepository(PetGramContext ctx)
        {
            _ctx = ctx;

        }
        public void  Delete(T entity)
        {
           _ctx.Set<T>().Remove(entity);
        }

        public async Task<T> Get(Guid id)
        {
           return await _ctx.Set<T>().FindAsync(id);

        }

        public IQueryable<T> GetAll()
        {
           return _ctx.Set<T>();

        }

        public void Save(T entity)
        {
            _ctx.Set<T>().AddAsync(entity);
        }

        public void Update(T entity)
        {
            _ctx.Set<T>().Update(entity);
        }
    }
}
