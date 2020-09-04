using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entites.ministry
{
    public class Phone
    {
        [Key]
        public int Id { get; set; }
        public string Number { get; set; }
        public bool Whatsapp { get; set; }
        public bool Primary_Contact { get; set; }
        public string Name_Contact { get; set; }
        public People People { get; set; }
    }
}
