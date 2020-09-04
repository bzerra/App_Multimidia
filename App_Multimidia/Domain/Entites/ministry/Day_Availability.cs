using Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entites.ministry
{
    public class Day_Availability
    {
        [Key]
        public int Id { get; set; }
        public EDay Day { get; set; }
        public bool Availability { get; set; }
        public string Justification { get; set; }
        public Monthly_Availability Monthly_Availability { get; set; }
    }
}
