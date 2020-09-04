using Domain.Entites;
using Domain.Entites.ministry;
using Domain.Interface.repository.ministry;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repository.ministry
{
    public class Day_AvailabilityRepository : BaseRepository<Day_Availability, ContextEntites>, IDay_AvailabilityRepository
    {
        public Day_AvailabilityRepository(ContextEntites context) : base(context)
        {
        }
    }
}
