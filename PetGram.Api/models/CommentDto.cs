using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetGram.Domain.Entities;

namespace PetGram.Api.models {
    public class CommentDto {

        public string Description { get; set; }

        public int Like { get; set; }

        public Guid PostId;

        public Post Post;

    }
}
