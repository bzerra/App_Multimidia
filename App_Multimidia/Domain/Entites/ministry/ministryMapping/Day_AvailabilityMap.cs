using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entites.ministry.ministryMapping
{
    public class Day_AvailabilityMap : IEntityTypeConfiguration<Day_Availability>
    {
        public void Configure(EntityTypeBuilder<Day_Availability> builder)
        {
            //name table
            builder.ToTable("Day_Availability");
            //key primary
            builder.HasKey(t => t.Id);
            //properties
            builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
            builder.Property(t => t.Day).HasColumnName("Day").IsRequired();
            builder.Property(t => t.Availability).HasColumnName("Availability").IsRequired();
            builder.Property(t => t.Justification).HasColumnName("Justification").HasColumnType("varchar(70)");
            //relationship
            builder.HasOne(t => t.Monthly_Availability).WithMany(t => t.availability).HasConstraintName("DayAv_MonthlyAv").HasForeignKey("Id_Monthly").IsRequired();
        }
    }
}
