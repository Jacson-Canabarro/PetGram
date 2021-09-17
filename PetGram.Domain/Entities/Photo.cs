using System;


namespace PetGram.Domain.Entities {
    public class Photo {

        public Guid Id { get; set; }

        public string Url { get; set; }

        public Profile Profile { get; set; }

        public Guid PostId { get; set; }
        
        public Post Post { get; set; }
    }
}
