using Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entites.ministry
{
    public class Scale
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public  EPeriod Period { get; set; }
        public EDay Day { get; set; }
        public string Name_Event { get; set; }
        public IEnumerable<Scale_Member> Team { get; set; }
    }
}
