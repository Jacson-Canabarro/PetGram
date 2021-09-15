using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetGram.Domain.Entities {

    [Table("Post")]
    public class Post {

        [Key]
        public Guid Id { get; set; }

        public string Description { get; set; }

        public int Like { get; set; }

        public DateTime Date { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Photo> Photos { get; set; }
    }
}
