using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetGram.Domain.Entities {
    public class Profile {

        public Guid Id { get; set; }

        public string Bio { get; set; }

        public string Hobbies { get; set; }

        public string Photo { get; set; }

        public Pet Pet { get; set; }

        public ICollection<Photo> Photos { get; set; }

        public ICollection<Pet> Friends { get; set; }
    }
}
