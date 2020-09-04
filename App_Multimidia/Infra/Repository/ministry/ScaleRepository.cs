using Domain.Entites;
using Domain.Entites.ministry;
using Domain.Interface.repository.ministry;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repository.ministry
{
    public class ScaleRepository : BaseRepository<Scale, ContextEntites>, IScaleRepository
    {
        public ScaleRepository(ContextEntites context) : base(context)
        {
        }
    }
}
