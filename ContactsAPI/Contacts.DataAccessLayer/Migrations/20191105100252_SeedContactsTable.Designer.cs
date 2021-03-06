﻿// <auto-generated />
using Contacts.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Contacts.DataAccessLayer.Migrations
{
    [DbContext(typeof(ContactDbContext))]
    [Migration("20191105100252_SeedContactsTable")]
    partial class SeedContactsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Contacts.DataAccessLayer.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "mail1@o2.pl",
                            Name = "Name1",
                            PhoneNumber = "123456789",
                            Surname = "Surname1"
                        },
                        new
                        {
                            Id = 2,
                            Email = "mail2@o2.pl",
                            Name = "Name2",
                            PhoneNumber = "9876543",
                            Surname = "Surname2"
                        },
                        new
                        {
                            Id = 3,
                            Email = "mail3@o2.pl",
                            Name = "Name3",
                            PhoneNumber = "333333333",
                            Surname = "Surname3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
