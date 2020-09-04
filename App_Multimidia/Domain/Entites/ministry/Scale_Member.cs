using Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entites.ministry
{
    public class Scale_Member
    {
        [Key]
        public int Id { get; set; }
        public EOccupation Occupation { get; set; }
        public People People { get; set; }
        public Scale Scale { get; set; }
    }
}
