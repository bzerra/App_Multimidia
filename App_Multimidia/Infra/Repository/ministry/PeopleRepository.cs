using Domain.Entites;
using Domain.Entites.ministry;
using Domain.Interface.repository.ministry;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repository.ministry
{
    public class PeopleRepository : BaseRepository<People, ContextEntites>, IPeopleRepository
    {
        public PeopleRepository(ContextEntites context) : base(context)
        {
        }
    }
}
