using Domain.Entites;
using Domain.Entites.ministry;
using Domain.Interface.repository.ministry;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repository.ministry
{
    public class Monthly_AvailabilityRepository : BaseRepository<Monthly_Availability, ContextEntites>, IMonthly_AvailabilityRepository
    {
        public Monthly_AvailabilityRepository(ContextEntites context) : base(context)
        {
        }
    }
}
