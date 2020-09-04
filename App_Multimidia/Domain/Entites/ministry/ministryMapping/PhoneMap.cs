using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entites.ministry.ministryMapping
{
    public class PhoneMap : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            //Name table
            builder.ToTable("Phone");
            // key primary
            builder.HasKey(t => t.Id);
            // properties
            builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
            builder.Property(t => t.Number).HasColumnName("Number").HasColumnType("varchar(17)"); //# (32) 9 9159-7617 || (32) 4002-8922
            builder.Property(t => t.Whatsapp).HasColumnName("Whatsapp").IsRequired();
            builder.Property(t => t.Primary_Contact).HasColumnName("Primary_Contact").IsRequired();
            builder.Property(t => t.Name_Contact).HasColumnName("Name_Contact").HasColumnType("varchar(15)");
            // relationship 
            builder.HasOne(t => t.People).WithMany(t => t.Phones).HasConstraintName("Phone_People").HasForeignKey("Id_People").IsRequired();
            
        }
    }
}
