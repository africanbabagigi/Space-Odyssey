﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Space_Odyssey.Data;

#nullable disable

namespace Space_Odyssey.Migrations
{
    [DbContext(typeof(SpaceDbContext))]
    partial class SpaceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Space_Odyssey.Models.Astronaut", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BirthDate")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sirname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Astronauts");
                });

            modelBuilder.Entity("Space_Odyssey.Models.AstronautRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AstronautRoles");
                });

            modelBuilder.Entity("Space_Odyssey.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(56)
                        .HasColumnType("nvarchar(56)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Space_Odyssey.Models.Manifacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Manifacturers");
                });

            modelBuilder.Entity("Space_Odyssey.Models.Mission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DurationHours")
                        .HasColumnType("int");

                    b.Property<int>("DurationMinutes")
                        .HasColumnType("int");

                    b.Property<int>("MaximumDistanceKM")
                        .HasColumnType("int");

                    b.Property<int>("SpaceshipId")
                        .HasColumnType("int");

                    b.Property<int>("StartDate")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SpaceshipId");

                    b.ToTable("Missions");
                });

            modelBuilder.Entity("Space_Odyssey.Models.MissionAstronautRole", b =>
                {
                    b.Property<int>("AstronautRoleId")
                        .HasColumnType("int");

                    b.Property<int>("AstronautId")
                        .HasColumnType("int");

                    b.Property<int>("MissionId")
                        .HasColumnType("int");

                    b.HasKey("AstronautRoleId", "AstronautId", "MissionId");

                    b.HasIndex("AstronautId");

                    b.HasIndex("MissionId");

                    b.ToTable("MissionAstronautRole");
                });

            modelBuilder.Entity("Space_Odyssey.Models.Spaceship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("ManifacturerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ManifacturerId");

                    b.ToTable("Spaceships");
                });

            modelBuilder.Entity("Space_Odyssey.Models.Astronaut", b =>
                {
                    b.HasOne("Space_Odyssey.Models.Country", "Country")
                        .WithMany("Astronauts")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Space_Odyssey.Models.Manifacturer", b =>
                {
                    b.HasOne("Space_Odyssey.Models.Country", "Country")
                        .WithMany("Manifacturers")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Space_Odyssey.Models.Mission", b =>
                {
                    b.HasOne("Space_Odyssey.Models.Spaceship", "Spaceship")
                        .WithMany("Missions")
                        .HasForeignKey("SpaceshipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Spaceship");
                });

            modelBuilder.Entity("Space_Odyssey.Models.MissionAstronautRole", b =>
                {
                    b.HasOne("Space_Odyssey.Models.Astronaut", "Astronaut")
                        .WithMany("MissionAstronautRoles")
                        .HasForeignKey("AstronautId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Space_Odyssey.Models.AstronautRole", "AstronautRole")
                        .WithMany("MissionAstronautRoles")
                        .HasForeignKey("AstronautRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Space_Odyssey.Models.Mission", "Mission")
                        .WithMany("MissionAstronautRoles")
                        .HasForeignKey("MissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Astronaut");

                    b.Navigation("AstronautRole");

                    b.Navigation("Mission");
                });

            modelBuilder.Entity("Space_Odyssey.Models.Spaceship", b =>
                {
                    b.HasOne("Space_Odyssey.Models.Manifacturer", "Manifacturer")
                        .WithMany("Spaceships")
                        .HasForeignKey("ManifacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manifacturer");
                });

            modelBuilder.Entity("Space_Odyssey.Models.Astronaut", b =>
                {
                    b.Navigation("MissionAstronautRoles");
                });

            modelBuilder.Entity("Space_Odyssey.Models.AstronautRole", b =>
                {
                    b.Navigation("MissionAstronautRoles");
                });

            modelBuilder.Entity("Space_Odyssey.Models.Country", b =>
                {
                    b.Navigation("Astronauts");

                    b.Navigation("Manifacturers");
                });

            modelBuilder.Entity("Space_Odyssey.Models.Manifacturer", b =>
                {
                    b.Navigation("Spaceships");
                });

            modelBuilder.Entity("Space_Odyssey.Models.Mission", b =>
                {
                    b.Navigation("MissionAstronautRoles");
                });

            modelBuilder.Entity("Space_Odyssey.Models.Spaceship", b =>
                {
                    b.Navigation("Missions");
                });
#pragma warning restore 612, 618
        }
    }
}
