using System;
using PetGram.Domain.Entities;

namespace PetGram.Api.models
{
    public class PostCreateDto
    {
        public string Description { get; set; }

        public Guid petId { get; set; }
        
        public string Photo { get; set; }
    }
}