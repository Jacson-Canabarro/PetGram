using PetGram.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetGram.Domain.Interfaces.Services;
using PetGram.Infra.Repositories;

namespace PetGram.Application.services
{
    public class PetService : IPetService
    {

        private readonly PetRepository _ptr;

        public PetService(PetRepository petRepository)
        {
            _ptr = petRepository;

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
