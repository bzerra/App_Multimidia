using Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entites.ministry
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }
        public ESkill Skill_Name { get; set; }
        public ELevel Level { get; set; }
        public People People { get; set; }
    }
}
