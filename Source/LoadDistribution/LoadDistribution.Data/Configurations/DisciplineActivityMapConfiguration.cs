﻿using LoadDistribution.Core.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LoadDistribution.Data.Configurations
{
      internal class DisciplineActivityMapConfiguration : IEntityTypeConfiguration<DisciplineActivityMap>
      {
            public void Configure(EntityTypeBuilder<DisciplineActivityMap> builder)
            {
                  builder.HasKey(k => k.Id);

                  builder.Property(p => p.Created).HasConversion(new DateTimeOffsetToBinaryConverter());
                  builder.Property(p => p.Updated).HasConversion(new DateTimeOffsetToBinaryConverter());

                  builder.HasIndex(p => new { p.ProjectId, p.DisciplineId, p.ActivityId });

                  builder
                        .HasOne(p => p.Project)
                        .WithMany(p => p!.DisciplineActivityMaps)
                        .HasForeignKey(fk => fk.ProjectId)
                        .OnDelete(DeleteBehavior.Cascade);
                  builder
                        .HasOne(p => p.Discipline)
                        .WithMany(p => p!.DisciplineActivityMaps)
                        .HasForeignKey(fk => fk.DisciplineId)
                        .OnDelete(DeleteBehavior.Cascade);
                  builder
                        .HasOne(p => p.Activity)
                        .WithMany(p => p!.DisciplineActivityMaps)
                        .HasForeignKey(fk => fk.ActivityId)
                        .OnDelete(DeleteBehavior.Cascade);
            }
      }
}
