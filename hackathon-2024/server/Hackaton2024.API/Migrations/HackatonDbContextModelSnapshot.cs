﻿// <auto-generated />
using Hackaton2024.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hackaton2024.API.Migrations
{
    [DbContext(typeof(HackatonDbContext))]
    partial class HackatonDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Hackaton2024.API.Entities.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stage")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Activities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Bieganie",
                            Stage = 0
                        },
                        new
                        {
                            Id = 2,
                            Name = "Czytanie",
                            Stage = 0
                        },
                        new
                        {
                            Id = 3,
                            Name = "Gotowanie",
                            Stage = 0
                        },
                        new
                        {
                            Id = 4,
                            Name = "Kolarstwo",
                            Stage = 0
                        },
                        new
                        {
                            Id = 5,
                            Name = "Pływanie",
                            Stage = 0
                        },
                        new
                        {
                            Id = 6,
                            Name = "Malowanie",
                            Stage = 0
                        },
                        new
                        {
                            Id = 7,
                            Name = "Hiking",
                            Stage = 0
                        },
                        new
                        {
                            Id = 8,
                            Name = "Taniec",
                            Stage = 0
                        },
                        new
                        {
                            Id = 9,
                            Name = "Ogrodnictwo",
                            Stage = 0
                        },
                        new
                        {
                            Id = 10,
                            Name = "Pisanie",
                            Stage = 0
                        });
                });

            modelBuilder.Entity("Hackaton2024.API.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Hackaton2024.API.Entities.UserActivity", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ActivityId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ActivityId");

                    b.HasIndex("ActivityId");

                    b.ToTable("UserActivities");
                });

            modelBuilder.Entity("Hackaton2024.API.Entities.UserActivity", b =>
                {
                    b.HasOne("Hackaton2024.API.Entities.Activity", "Activity")
                        .WithMany("UserActivities")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hackaton2024.API.Entities.User", "User")
                        .WithMany("UserActivities")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Hackaton2024.API.Entities.Activity", b =>
                {
                    b.Navigation("UserActivities");
                });

            modelBuilder.Entity("Hackaton2024.API.Entities.User", b =>
                {
                    b.Navigation("UserActivities");
                });
#pragma warning restore 612, 618
        }
    }
}
