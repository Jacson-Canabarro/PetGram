using System;
using System.Collections.Generic;
using System.Text;
using PetGram.Domain.Entities;
using PetGram.Domain.Interfaces.Repositories;
using PetGram.Infra.Context;

namespace PetGram.Infra.Repositories {
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository{

        private readonly PetGramContext _ctx;

        public CommentRepository(PetGramContext ctx) : base(ctx) {
            _ctx = ctx;
        }
    }
}
