using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetGram.Domain.Entities;
using PetGram.Infra.Repositories;
using PetGram.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace PetGram.Application.services {
    public class CommentService : ICommentService{

        private readonly CommentRepository _ptr;

        public CommentService(CommentRepository commentRepository) {
            _ptr = commentRepository;

        }

        public void Delete(Comment id) {
            _ptr.Delete(id);
        }

        public async Task<Comment> Get(Guid id) {
            return await _ptr.Get(id);
        }

        public List<Comment> GetAll() {
            return _ptr.GetAll().ToList();
        }

        public void Save(Comment entity) {
            _ptr.Save(entity);
        }

        public void Update(Comment entity) {
            _ptr.Update(entity);
        }
    }
}
