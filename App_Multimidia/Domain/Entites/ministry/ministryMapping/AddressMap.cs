using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entites.ministry.ministryMapping
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            //name table
            builder.ToTable("Andress");
            //key primary
            builder.HasKey(t => t.Id);
            //properties
            builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
            builder.Property(t => t.Zip_code).HasColumnName("Zip_code").HasColumnType("varchar(10)").IsRequired();
            builder.Property(t => t.Street).HasColumnName("Street").HasColumnType("varchar(50)");
            builder.Property(t => t.Neighborhood).HasColumnName("Neighborhood").HasColumnType("varchar(25)");
            builder.Property(t => t.Number).HasColumnName("Number").HasColumnType("varchar(10)");
            builder.Property(t => t.Complement).HasColumnName("Complement").HasColumnType("varchar(15)");
            builder.Property(t => t.City).HasColumnName("City").HasColumnType("varchar(25)");
            builder.Property(t => t.State).HasColumnName("State").HasColumnType("varchar(20)");
            builder.Property(t => t.Reference).HasColumnName("Reference").HasColumnType("varchar(30)");
            //relationship
            builder.HasOne(t => t.People).WithOne().HasForeignKey("Id_People").IsRequired();

        }
    }
}
