﻿// <auto-generated />
using System;
using Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200722180920_init2")]
    partial class init2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Parts.Entities.Maker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullNameCompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Makers");
                });

            modelBuilder.Entity("Parts.Entities.Part", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MakerId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("PriceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MakerId");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("Parts.Entities.PartInSelection", b =>
                {
                    b.Property<int>("PartId")
                        .HasColumnType("int");

                    b.Property<int>("SelectionId")
                        .HasColumnType("int");

                    b.HasKey("PartId", "SelectionId");

                    b.HasIndex("SelectionId");

                    b.ToTable("PartInSelection");
                });

            modelBuilder.Entity("Parts.Entities.Selection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PartId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Selections");
                });

            modelBuilder.Entity("Parts.Entities.Part", b =>
                {
                    b.HasOne("Parts.Entities.Maker", "Maker")
                        .WithMany("Parts")
                        .HasForeignKey("MakerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Parts.Entities.PartInSelection", b =>
                {
                    b.HasOne("Parts.Entities.Part", "Part")
                        .WithMany("PartInSelelections")
                        .HasForeignKey("PartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Parts.Entities.Selection", "Selection")
                        .WithMany("PartInSelelections")
                        .HasForeignKey("SelectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
