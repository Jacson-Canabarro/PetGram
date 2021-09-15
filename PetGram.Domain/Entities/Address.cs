using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetGram.Domain.Entities {

    [Table("Address")]
    public class Address {

        [Key]
        public Guid Id { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

    }
}
