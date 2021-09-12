using PetGram.Domain.Entities;

namespace PetGram.Domain.Interfaces.Services
{
    public interface IPetService : IBaseService<Pet>
    {

        public Pet Login(string email, string password);

    }
}