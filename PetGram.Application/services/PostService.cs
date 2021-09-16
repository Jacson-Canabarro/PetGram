using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetGram.Domain.Entities;
using PetGram.Domain.Interfaces.Services;
using PetGram.Infra.Repositories;

namespace PetGram.Application.services {

    public class PostService : IPostService {

        private readonly PostRepository _ptr;

        public PostService(PostRepository postRepository) {
            _ptr = postRepository;
        }

        public void Delete(Post id) {
            _ptr.Delete(id);
        }

        public async Task<Post> Get(Guid id) {
            return await _ptr.Get(id);
        }

        public List<Post> GetAll() {
            return _ptr.GetAll().ToList();
        }

        public void Save(Post entity) {
            _ptr.Save(entity);
        }

        public void Update(Post entity) {
            _ptr.Update(entity);
        }
    }
}
