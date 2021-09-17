using PetGram.Domain.Entities;
using PetGram.Infra.Context;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PetGram.Domain.Interfaces.Repositories;

namespace PetGram.Infra.Repositories
{
    public class PetRepository : BaseRepository<Pet>, IPetRepository
    {
        private readonly PetGramContext _ctx;
        public PetRepository(PetGramContext ctx): base(ctx)
        {
            _ctx = ctx;
        }


        public Pet GetByUserEmailAndPassword(string email, string password)
        {
            return _ctx.Pets.FirstOrDefault(p => p.Email.Equals(email.ToLower()) && p.Password.Equals(password.ToLower())) ;
        }
    }
}
