using Domain.Entites;
using Domain.Entites.ministry;
using Domain.Interface.repository.ministry;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repository.ministry
{
    public class AddressRepository : BaseRepository<Address, ContextEntites>, IAddressRepository
    {
        public AddressRepository(ContextEntites context) : base(context)
        {
            
        }
    }
}
