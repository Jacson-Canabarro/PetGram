using System.Linq;
using Microsoft.EntityFrameworkCore;
using PetGram.Domain.Entities;
using PetGram.Domain.Interfaces.Repositories;
using PetGram.Infra.Context;

namespace PetGram.Infra.Repositories
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        private readonly PetGramContext _ctx;

        public PostRepository(PetGramContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }


        public IQueryable<Post> GetAll()
        {
            return _ctx.Posts.Include(p => p.Comments);
        }
    }
}