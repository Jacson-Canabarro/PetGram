using PetGram.Domain.Entities;
using PetGram.Infra.Repositories;

namespace PetGram.Infra.Interfaces
{
    public interface IPetRepository: IBaseRepository<Pet>
    {


    }
}
