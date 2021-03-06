using System;


namespace PetGram.Domain.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public int Like { get; set; }

        public Guid PostId { get; set; }
        
        public Post Post { get; set; }
    }
}