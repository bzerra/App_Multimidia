using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entites.ministry.ministryMapping
{
    public class Monthly_AvailabilityMap : IEntityTypeConfiguration<Monthly_Availability>
    {
        public void Configure(EntityTypeBuilder<Monthly_Availability> builder)
        {
            //name table
            builder.ToTable("Monthly_Availability");
            //key primary
            builder.HasKey(t => t.Id);
            //properties
            builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
            builder.Property(t => t.Monthy_Name).HasColumnName("Monthy_Name").IsRequired();
            //relationship
            builder.HasOne(t => t.People).WithMany(t => t.Availabilities).HasConstraintName("MonthlyAv_People").IsRequired();            
        }
    }
}
