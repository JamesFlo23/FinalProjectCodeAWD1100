﻿// <auto-generated />
using Final;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Final.Migrations
{
    [DbContext(typeof(CustomerContext))]
    [Migration("20230504051251_creation")]
    partial class creation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Final.CustomerAccount", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AccountNumber")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Balance")
                        .HasColumnType("real");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SSN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            ID = 112233,
                            AccountNumber = 101000,
                            Address = "178 Bikini Bottom Rd",
                            Balance = 600f,
                            FirstName = "Patrick",
                            LastName = "Star",
                            SSN = "123-45-6789"
                        },
                        new
                        {
                            ID = 223344,
                            AccountNumber = 101001,
                            Address = "182 Bikini Bottom Rd",
                            Balance = 78000f,
                            FirstName = "Spongebob",
                            LastName = "Squarepants",
                            SSN = "465-78-7878"
                        },
                        new
                        {
                            ID = 334455,
                            AccountNumber = 101002,
                            Address = "126 Conch Street",
                            Balance = 500000f,
                            FirstName = "Sandy",
                            LastName = "Cheeks",
                            SSN = "111-11-1118"
                        },
                        new
                        {
                            ID = 445566,
                            AccountNumber = 101003,
                            Address = "3541 Anchor Way",
                            Balance = 1000000f,
                            FirstName = "Eugene",
                            LastName = "Krabs",
                            SSN = "345-77-6658"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
