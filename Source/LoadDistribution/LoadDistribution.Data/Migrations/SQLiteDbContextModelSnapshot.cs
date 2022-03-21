﻿// <auto-generated />
using LoadDistribution.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LoadDistribution.Data.Migrations
{
    [DbContext(typeof(SQLiteDbContext))]
    partial class SQLiteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("LoadDistribution.Core.Domain.Models.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Created")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DependencyType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<int>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Updated")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("LoadDistribution.Core.Domain.Models.Discipline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BudgetStudentCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ComercialStudentCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Course")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Created")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EducationForm")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<string>("EducationLevel")
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupAbbreviation")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<int>("GroupCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Institute")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PlanIndex")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<int>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Speciality")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<int>("StudentCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubgroupCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Term")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ThreadCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<int>("UniversityId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Updated")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UniversityId");

                    b.ToTable("Disciplines");
                });

            modelBuilder.Entity("LoadDistribution.Core.Domain.Models.Lecturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Created")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<int>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Updated")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Lecturers");
                });

            modelBuilder.Entity("LoadDistribution.Core.Domain.Models.LecturerDisciplineActivityMap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ActivityId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Created")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DisciplineId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LecturerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Rate")
                        .HasColumnType("TEXT");

                    b.Property<long>("Updated")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("DisciplineId");

                    b.HasIndex("LecturerId");

                    b.HasIndex("ProjectId", "LecturerId", "DisciplineId", "ActivityId")
                        .IsUnique();

                    b.ToTable("LecturerDisciplineActivityMaps");
                });

            modelBuilder.Entity("LoadDistribution.Core.Domain.Models.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Created")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Details")
                        .HasMaxLength(4096)
                        .HasColumnType("TEXT");

                    b.Property<string>("ExceptionType")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("LoadDistribution.Core.Domain.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Created")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(1024)
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<long>("Updated")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("LoadDistribution.Core.Domain.Models.University", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Created")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<int>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Updated")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Universities");
                });

            modelBuilder.Entity("LoadDistribution.Core.Domain.Models.UniversityLecturerMap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Created")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LecturerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UniversityId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Updated")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("LecturerId");

                    b.HasIndex("UniversityId");

                    b.HasIndex("ProjectId", "UniversityId", "LecturerId")
                        .IsUnique();

                    b.ToTable("UniversityLecturerMaps");
                });

            modelBuilder.Entity("LoadDistribution.Core.Domain.Models.Activity", b =>
                {
                    b.HasOne("LoadDistribution.Core.Domain.Models.Project", "Project")
                        .WithMany("Activities")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("LoadDistribution.Core.Domain.Models.Discipline", b =>
                {
                    b.HasOne("LoadDistribution.Core.Domain.Models.Project", "Project")
                        .WithMany("Disciplines")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LoadDistribution.Core.Domain.Models.University", "University")
                        .WithMany("Disciplines")
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("University");
                });

            modelBuilder.Entity("LoadDistribution.Core.Domain.Models.Lecturer", b =>
                {
                    b.HasOne("LoadDistribution.Core.Domain.Models.Project", "Project")
                        .WithMany("Lecturers")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("LoadDistribution.Core.Domain.Models.LecturerDisciplineActivityMap", b =>
                {
                    b.HasOne("LoadDistribution.Core.Domain.Models.Activity", "Activity")
                        .WithMany("LecturerDisciplineActivityMaps")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LoadDistribution.Core.Domain.Models.Discipline", "Discipline")
                        .WithMany("LecturerDisciplineActivityMaps")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LoadDistribution.Core.Domain.Models.Lecturer", "Lecturer")
                        .WithMany("LecturerDisciplineActivityMaps")
                        .HasForeignKey("LecturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LoadDistribution.Core.Domain.Models.Project", "Project")
                        .WithMany("LecturerDisciplineActivityMaps")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");

                    b.Navigation("Discipline");

                    b.Navigation("Lecturer");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("LoadDistribution.Core.Domain.Models.University", b =>
                {
                    b.HasOne("LoadDistribution.Core.Domain.Models.Project", "Project")
                        .WithMany("Universities")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("LoadDistribution.Core.Domain.Models.UniversityLecturerMap", b =>
                {
                    b.HasOne("LoadDistribution.Core.Domain.Models.Lecturer", "Lecturer")
                        .WithMany("UniversityLectureMaps")
                        .HasForeignKey("LecturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LoadDistribution.Core.Domain.Models.Project", "Project")
                        .WithMany("UniversityLecturerMaps")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LoadDistribution.Core.Domain.Models.University", "University")
                        .WithMany("UniversityLectureMaps")
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lecturer");

                    b.Navigation("Project");

                    b.Navigation("University");
                });

            modelBuilder.Entity("LoadDistribution.Core.Domain.Models.Activity", b =>
                {
                    b.Navigation("LecturerDisciplineActivityMaps");
                });

            modelBuilder.Entity("LoadDistribution.Core.Domain.Models.Discipline", b =>
                {
                    b.Navigation("LecturerDisciplineActivityMaps");
                });

            modelBuilder.Entity("LoadDistribution.Core.Domain.Models.Lecturer", b =>
                {
                    b.Navigation("LecturerDisciplineActivityMaps");

                    b.Navigation("UniversityLectureMaps");
                });

            modelBuilder.Entity("LoadDistribution.Core.Domain.Models.Project", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("Disciplines");

                    b.Navigation("LecturerDisciplineActivityMaps");

                    b.Navigation("Lecturers");

                    b.Navigation("Universities");

                    b.Navigation("UniversityLecturerMaps");
                });

            modelBuilder.Entity("LoadDistribution.Core.Domain.Models.University", b =>
                {
                    b.Navigation("Disciplines");

                    b.Navigation("UniversityLectureMaps");
                });
#pragma warning restore 612, 618
        }
    }
}
