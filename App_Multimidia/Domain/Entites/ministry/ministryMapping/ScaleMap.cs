using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entites.ministry.ministryMapping
{
    public class ScaleMap : IEntityTypeConfiguration<Scale>
    {
        public void Configure(EntityTypeBuilder<Scale> builder)
        {
            //name table
            builder.ToTable("Scale");
            //key primary
            builder.HasKey(t => t.Id);
            //properties
            builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
            builder.Property(t => t.Date).HasColumnName("Date").IsRequired();
            builder.Property(t => t.Period).HasColumnName("Period").IsRequired();
            builder.Property(t => t.Day).HasColumnName("Day").IsRequired();
            builder.Property(t => t.Name_Event).HasColumnName("Name_Event").HasColumnType("varchar(25)");
            //relationship
            builder.HasMany(t => t.Team).WithOne(t => t.Scale).HasConstraintName("Scale_Member");

        }
    }
}
