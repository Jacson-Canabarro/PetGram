using PetGram.Domain.Entities;
using PetGram.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetGram.Infra.Repositories
{
    public class PetRepository : BaseRepository<Pet>
    {
        private readonly PetGramContext _ctx;
        public PetRepository(PetGramContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }


        public Pet GetByUserEmailAndPassword(string email, string password)
        {
            return _ctx.Pets.Where(p => p.Password.Equals(email.ToLower()) && p.Password.Equals(password.ToLower())).FirstOrDefault() ;
        }



    }
}
