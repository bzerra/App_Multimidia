using Domain.Entites.ministry;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Domain.Entites
{
    public class ContextEntites : DbContext
    {
        public ContextEntites(DbContextOptions<ContextEntites> options) : base(options) { }

        public DbSet<Address> Address { get; set; }
        public DbSet<Day_Availability> Day_Availability { get; set; }
        public DbSet<Monthly_Availability> Monthly_Availability { get; set; }
        public DbSet<People> People { get; set; }
        public DbSet<Phone> Phone { get; set; }
        public DbSet<Scale> Scale { get; set; }
        public DbSet<Scale_Member> Scale_Member { get; set; }
        public DbSet<Skill> Skill { get; set; }        

    }
}

//COMANDS EF 

// (CRIAR) PM> Add-Migration -Context Domain.Entites.ContextEntites Inicial -OutputDir "Migrations/Context"
// (RODAR SCRIPT) PM> Update-Database -Migration 20200904002158_Inicial -Context Domain.Entites.ContextEntites