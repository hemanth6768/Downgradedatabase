﻿// <auto-generated />
using Downgradedatabase.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Downgradedatabase.Migrations
{
    [DbContext(typeof(Student1context))]
    partial class Student1contextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Downgradedatabase.Model.Student1", b =>
                {
                    b.Property<int>("rollnumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<string>("section")
                        .HasColumnType("text");

                    b.HasKey("rollnumber");

                    b.ToTable("student1");
                });
#pragma warning restore 612, 618
        }
    }
}
