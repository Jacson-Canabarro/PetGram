using PetGram.Infra.Context;
using System;
using System.Threading.Tasks;
using System.Linq;
using PetGram.Domain.Interfaces;

namespace PetGram.Infra.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {

        private readonly PetGramContext _ctx;

        protected BaseRepository(PetGramContext ctx)
        {
            _ctx = ctx;

        }
        public void  Delete(T entity)
        {
           _ctx.Set<T>().Remove(entity);
           _ctx.SaveChanges();
        }

        public async Task<T> Get(Guid id)
        {
           return await _ctx.Set<T>().FindAsync(id);

        }

        public IQueryable<T> GetAll()
        {
           return _ctx.Set<T>();

        }

        public async Task Save(T entity)
        {
           await _ctx.Set<T>().AddAsync(entity);
           await _ctx.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _ctx.Set<T>().Update(entity);
            _ctx.SaveChanges();
        }
    }
}
