using Domain.Entites;
using Domain.Entites.ministry;
using Domain.Interface.repository.ministry;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repository.ministry
{
    public class Scale_MemberRepository : BaseRepository<Scale_Member, ContextEntites>, IScale_MemberRepository
    {
        public Scale_MemberRepository(ContextEntites context) : base(context)
        {
        }
    }
}
