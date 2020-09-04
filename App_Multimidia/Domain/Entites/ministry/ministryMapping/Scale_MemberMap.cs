using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entites.ministry.ministryMapping
{
    public class Scale_MemberMap : IEntityTypeConfiguration<Scale_Member>
    {
        public void Configure(EntityTypeBuilder<Scale_Member> builder)
        {
            //name table
            builder.ToTable("Scale_Member");
            //key primary
            builder.HasKey(t => t.Id);
            //properties
            builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
            builder.Property(t => t.Occupation).HasColumnName("Occupation").IsRequired();
            //relationship
            builder.HasOne(t => t.People).WithOne().IsRequired();
            builder.HasOne(t => t.Scale).WithMany(t => t.Team).HasConstraintName("Scale_Member_Scale").HasForeignKey("Id_Scale").IsRequired();

        }
    }
}
