using PetGram.Domain.Entities;
using PetGram.Infra.Context;
using System.Linq;

namespace PetGram.Infra.Repositories {

    public class PostRepository : BaseRepository<Post> {

        private readonly PetGramContext _ctx;

        public PostRepository(PetGramContext ctx) : base(ctx) {
            _ctx = ctx;
        }
    }
}
