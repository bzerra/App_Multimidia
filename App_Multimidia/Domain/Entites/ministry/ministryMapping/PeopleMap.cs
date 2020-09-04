using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entites.ministry.ministryMapping
{
    public class PeopleMap : IEntityTypeConfiguration<People>
    {
        public void Configure(EntityTypeBuilder<People> builder)
        {
            //name table
            builder.ToTable("People");
            // key primary
            builder.HasKey(t => t.Id);
            // properties
            builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
            builder.Property(t => t.Name).HasColumnName("Name").HasColumnType("varchar(40)");
            builder.Property(t => t.Nickname).HasColumnName("Nickname").HasColumnType("varchar(15)");
            builder.Property(t => t.Sex).HasColumnName("Sex").IsRequired();
            builder.Property(t => t.Date_Birth).HasColumnName("Date_Birth").IsRequired();
            builder.Property(t => t.Baptized).HasColumnName("Baptized").IsRequired();
            builder.Property(t => t.Email).HasColumnName("Email").HasColumnType("varchar(45)").IsRequired();
            builder.Property(t => t.School_level).HasColumnName("School_level").IsRequired();
            builder.Property(t => t.Ministry_level).HasColumnName("Ministry_level").IsRequired();
            builder.Property(t => t.Login).HasColumnName("Login").HasColumnType("varchar(40)");
            builder.Property(t => t.Password).HasColumnName("Password").HasColumnType("varchar(40)");
            //relationship            
            builder.HasMany(t => t.Skills).WithOne(t => t.People).HasConstraintName("People_Skill");
            builder.HasMany(t => t.Phones).WithOne(t => t.People).HasConstraintName("People_Phone");
            builder.HasMany(t => t.Availabilities).WithOne(t => t.People).HasConstraintName("People_Availability");
            
        }
    }
}
