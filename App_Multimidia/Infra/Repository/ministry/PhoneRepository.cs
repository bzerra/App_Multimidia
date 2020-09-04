using Domain.Entites;
using Domain.Entites.ministry;
using Domain.Interface.repository.ministry;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repository.ministry
{
    public class PhoneRepository : BaseRepository<Phone, ContextEntites>, IPhoneRepository
    {
        public PhoneRepository(ContextEntites context) : base(context)
        {
        }
    }
}
