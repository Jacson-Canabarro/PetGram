using System;
using System.Collections.Generic;
using System.Text;
using PetGram.Domain.Entities;
using PetGram.Infra.Context;

namespace PetGram.Infra.Repositories {
    class CommentRepository : BaseRepository<Comment>{

        private readonly PetGramContext _ctx;

        public CommentRepository(PetGramContext ctx) : base(ctx) {
            _ctx = ctx;
        }
    }
}
