using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entites.ministry
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public People People { get; set; }
        public string Zip_code { get; set; }
        public string Street { get; set; }
        public string Neighborhood { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Reference { get; set; }
    }
}
