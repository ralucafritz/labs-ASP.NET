﻿// <auto-generated />
using System;
using Lab210.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lab210.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220530223736_AddedStudentGrade")]
    partial class AddedStudentGrade
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lab210.DAL.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Lab210.DAL.Entities.StudentAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("Zipcode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("StudentAdresses");
                });

            modelBuilder.Entity("Lab210.DAL.Entities.StudentGrade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Grade")
                        .HasColumnType("decimal(4,2)");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentGrades");
                });

            modelBuilder.Entity("Lab210.DAL.Entities.StudentAddress", b =>
                {
                    b.HasOne("Lab210.DAL.Entities.Student", "Student")
                        .WithOne("StudentAddress")
                        .HasForeignKey("Lab210.DAL.Entities.StudentAddress", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Lab210.DAL.Entities.StudentGrade", b =>
                {
                    b.HasOne("Lab210.DAL.Entities.Student", "Student")
                        .WithMany("StudentGrades")
                        .HasForeignKey("StudentId");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Lab210.DAL.Entities.Student", b =>
                {
                    b.Navigation("StudentAddress");

                    b.Navigation("StudentGrades");
                });
#pragma warning restore 612, 618
        }
    }
}
