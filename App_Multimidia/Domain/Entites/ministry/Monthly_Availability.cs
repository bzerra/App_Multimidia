using Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entites.ministry
{
    public class Monthly_Availability
    {
        [Key]
        public int Id { get; set; }
        public EMonthy Monthy_Name { get; set; }
        public People People { get; set; }
        public IEnumerable<Day_Availability> availability { get; set; }
    }
}
