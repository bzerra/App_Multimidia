using Domain.Entites;
using Domain.Entites.ministry;
using Domain.Interface.repository.ministry;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repository.ministry
{
    public class SkillRepository : BaseRepository<Skill, ContextEntites>, ISkillRepository
    {
        public SkillRepository(ContextEntites context) : base(context)
        {
        }
    }
}
