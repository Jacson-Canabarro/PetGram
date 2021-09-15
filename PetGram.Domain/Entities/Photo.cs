using System;
using System.Collections.Generic;
using System.Text;


namespace PetGram.Domain.Entities {
    public class Photo {

        public Guid Id { get; set; }

        public string Url { get; set; }

        public Profile Profile { get; set; }
    }
}
