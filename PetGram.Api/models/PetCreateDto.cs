using System;

namespace PetGram.Api.models
{
    public class PetCreateDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDay { get; set; }
        public string Gender { get; set; }
        public string Breed { get; set; }
    }
}