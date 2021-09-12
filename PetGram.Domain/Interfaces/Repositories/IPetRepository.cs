using PetGram.Domain.Entities;

namespace PetGram.Domain.Interfaces.Repositories
{
    public interface IPetRepository: IBaseRepository<Pet>
    {

        public Pet GetByUserEmailAndPassword(string email, string password);
    }
}