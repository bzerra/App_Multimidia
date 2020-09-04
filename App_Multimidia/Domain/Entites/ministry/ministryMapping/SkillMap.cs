using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entites.ministry.ministryMapping
{
    public class SkillMap : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            //name table
            builder.ToTable("Skill");
            //key primary
            builder.HasKey(t => t.Id);
            //properties
            builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
            builder.Property(t => t.Skill_Name).HasColumnName("Skill_Name").IsRequired();
            builder.Property(t => t.Level).HasColumnName("Level").IsRequired() ;
            //relationship
            builder.HasOne(t => t.People).WithMany(t => t.Skills).HasConstraintName("Id_People").IsRequired();
        }
    }
}
