using PetGram.Domain.Entities;
using PetGram.Infra.Interfaces;
using PetGram.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetGram.Application.services
{
    public class PetService : IBaseService<Pet>
    {

        private readonly PetRepository _ptr;

        public PetService(PetRepository PetRepository)
        {
            _ptr = PetRepository;

        }

        public void Delete(Pet id)
        {
            _ptr.Delete(id);
        }

        public async Task<Pet> Get(Guid id)
        {
            return await _ptr.Get(id);
        }

        public List<Pet> GetAll()
        {
            return _ptr.GetAll().ToList();
        }

        public void Save(Pet entity)
        {
            _ptr.Save(entity);
        }

        public void Update(Pet entity)
        {
            _ptr.Update(entity);
        }

        public Pet Login(string email, string password)
        {
           return _ptr.GetByUserEmailAndPassword(email, password);
        }
    }
}
