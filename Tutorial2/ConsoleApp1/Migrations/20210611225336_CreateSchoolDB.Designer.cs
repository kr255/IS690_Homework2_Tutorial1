﻿// <auto-generated />
using ConsoleApp1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleApp1.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20210611225336_CreateSchoolDB")]
    partial class CreateSchoolDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("ConsoleApp1.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CourseName")
                        .HasColumnType("TEXT");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ConsoleApp1.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("StudentName")
                        .HasColumnType("TEXT");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}