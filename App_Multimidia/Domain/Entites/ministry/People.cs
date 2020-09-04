using Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entites.ministry
{
    public class People
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public ESex Sex { get; set; }
        public DateTime Date_Birth { get; set; }
        public bool Baptized { get; set; }               
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public ESchoolLevel School_level { get; set; }
        public EMinistryLevel Ministry_level { get; set; }        
        public IEnumerable<Skill> Skills { get; set; }
        public IEnumerable<Phone> Phones { get; set; }
        public IEnumerable<Monthly_Availability> Availabilities { get; set; }

    }
}
