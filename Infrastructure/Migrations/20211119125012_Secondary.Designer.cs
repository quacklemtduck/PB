﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PB.Infrastructure;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(PBContext))]
    [Migration("20211119125012_Secondary")]
    partial class Secondary
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("PB.Infrastructure.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProjectID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StudentID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProjectID");

                    b.HasIndex("StudentID");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("PB.Infrastructure.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Deadline")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int>("SupervisorID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<bool>("getNotification")
                        .HasColumnType("INTEGER");

                    b.Property<int>("numberOfStudents")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SupervisorID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("PB.Infrastructure.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("PB.Infrastructure.Supervisor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContactInfo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Supervisors");
                });

            modelBuilder.Entity("PB.Infrastructure.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("PB.Infrastructure.University", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("University");
                });

            modelBuilder.Entity("ProjectStudent", b =>
                {
                    b.Property<int>("CollabStudentsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProjectsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CollabStudentsId", "ProjectsId");

                    b.HasIndex("ProjectsId");

                    b.ToTable("ProjectStudent");
                });

            modelBuilder.Entity("PB.Infrastructure.Application", b =>
                {
                    b.HasOne("PB.Infrastructure.Project", "Project")
                        .WithMany("Applications")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PB.Infrastructure.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("PB.Infrastructure.Project", b =>
                {
                    b.HasOne("PB.Infrastructure.Supervisor", "Supervisor")
                        .WithMany("Projects")
                        .HasForeignKey("SupervisorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supervisor");
                });

            modelBuilder.Entity("PB.Infrastructure.Tag", b =>
                {
                    b.HasOne("PB.Infrastructure.Project", null)
                        .WithMany("Tags")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("PB.Infrastructure.University", b =>
                {
                    b.HasOne("PB.Infrastructure.Project", null)
                        .WithMany("Universities")
                        .HasForeignKey("ProjectId");
                });

            modelBuilder.Entity("ProjectStudent", b =>
                {
                    b.HasOne("PB.Infrastructure.Student", null)
                        .WithMany()
                        .HasForeignKey("CollabStudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PB.Infrastructure.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PB.Infrastructure.Project", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("Tags");

                    b.Navigation("Universities");
                });

            modelBuilder.Entity("PB.Infrastructure.Supervisor", b =>
                {
                    b.Navigation("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
