using System;
using System.Collections.Generic;
using System.Text;


namespace PetGram.Domain.Entities {
    public class Comment {

        public Guid Id { get; set; }

        public string Description { get; set; }

        public int Like { get; set; }

        public Profile Profile { get; set; }
    }
}
