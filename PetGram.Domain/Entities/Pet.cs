using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PetGram.Domain.Entities
{
    [Table("Pet")]
    public class Pet
    {
//
        [Key]
        public Guid Id { get; set; }
        
        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime BirthDay { get; set; }

        public string Gender { get; set; }

        public string Breed { get; set; }

        public string Password { get; set; }

    }
}
