﻿// <auto-generated />
using System;
using GraphQLDotNetCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GraphQLDotNetCore.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20190321075540_InitialDbMigration")]
    partial class InitialDbMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GraphQLDotNetCore_Start.Entities.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<Guid>("OwnerId");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cb9ffd28-1fb2-4ce9-9f39-497bdf8a5096"),
                            Description = "Cash account for our users",
                            OwnerId = new Guid("514c3bc3-14df-4515-bc13-256e75dd2e9f"),
                            Type = 0
                        },
                        new
                        {
                            Id = new Guid("4855d973-eb70-48f1-a619-a2d62ce124d3"),
                            Description = "Savings account for our users",
                            OwnerId = new Guid("791716be-7eff-4370-814e-3884d27ae682"),
                            Type = 1
                        },
                        new
                        {
                            Id = new Guid("c810d02e-5235-45ff-80b4-34bca427479f"),
                            Description = "Income account for our users",
                            OwnerId = new Guid("791716be-7eff-4370-814e-3884d27ae682"),
                            Type = 3
                        });
                });

            modelBuilder.Entity("GraphQLDotNetCore_Start.Entities.Owner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            Id = new Guid("514c3bc3-14df-4515-bc13-256e75dd2e9f"),
                            Address = "John Doe's address",
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = new Guid("791716be-7eff-4370-814e-3884d27ae682"),
                            Address = "Jane Doe's address",
                            Name = "Jane Doe"
                        });
                });

            modelBuilder.Entity("GraphQLDotNetCore_Start.Entities.Account", b =>
                {
                    b.HasOne("GraphQLDotNetCore_Start.Entities.Owner", "Owner")
                        .WithMany("Accounts")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
