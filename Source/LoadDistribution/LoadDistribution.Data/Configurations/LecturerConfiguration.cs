﻿using LoadDistribution.Core.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LoadDistribution.Data.Configurations;

public class LecturerConfiguration : IEntityTypeConfiguration<Lecturer>
{
      public void Configure(EntityTypeBuilder<Lecturer> builder)
      {
            builder.HasKey(k => k.Id);

            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(256);
            builder.Property(p => p.MiddleName).IsRequired().HasMaxLength(256);
            builder.Property(p => p.LastName).IsRequired().HasMaxLength(256);
            builder.Property(p => p.Created).HasConversion(new DateTimeOffsetToBinaryConverter());
            builder.Property(p => p.Updated).HasConversion(new DateTimeOffsetToBinaryConverter());

            builder
                .HasOne(p => p.Project)
                .WithMany(p => p!.Lecturers)
                .HasForeignKey(fk => fk.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);
      }
}
