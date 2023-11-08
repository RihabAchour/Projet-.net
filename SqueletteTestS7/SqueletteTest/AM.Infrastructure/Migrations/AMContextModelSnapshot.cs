﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AMContext))]
    partial class AMContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApplicationCore.Domain.Artiste", b =>
                {
                    b.Property<int>("ArtisteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtisteId"));

                    b.Property<string>("Contact")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DateNaissance")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nationalite")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nom")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Prenom")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ArtisteId");

                    b.ToTable("Artistes");
                });

            modelBuilder.Entity("ApplicationCore.Domain.Chanson", b =>
                {
                    b.Property<int>("ChansonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChansonId"));

                    b.Property<int>("ArtisteFk")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateSortie")
                        .HasColumnType("datetime2");

                    b.Property<int>("Duree")
                        .HasColumnType("int");

                    b.Property<int>("StyleMusical")
                        .HasColumnType("int");

                    b.Property<string>("Titre")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("VuesYoutube")
                        .HasColumnType("int");

                    b.HasKey("ChansonId");

                    b.HasIndex("ArtisteFk");

                    b.ToTable("Chansons");
                });

            modelBuilder.Entity("ApplicationCore.Domain.Concert", b =>
                {
                    b.Property<DateTime>("DateConcert")
                        .HasColumnType("datetime2");

                    b.Property<int>("ArtisteFk")
                        .HasColumnType("int");

                    b.Property<int>("Festivalfk")
                        .HasColumnType("int");

                    b.Property<double>("Cachet")
                        .HasColumnType("float");

                    b.Property<int>("Duree")
                        .HasColumnType("int");

                    b.HasKey("DateConcert", "ArtisteFk", "Festivalfk");

                    b.HasIndex("ArtisteFk");

                    b.HasIndex("Festivalfk");

                    b.ToTable("Concerts");
                });

            modelBuilder.Entity("ApplicationCore.Domain.Festival", b =>
                {
                    b.Property<int>("FestivalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FestivalId"));

                    b.Property<int>("Capacite")
                        .HasColumnType("int");

                    b.Property<string>("Label")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ville")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("FestivalId");

                    b.ToTable("Festivales");
                });

            modelBuilder.Entity("ApplicationCore.Domain.Chanson", b =>
                {
                    b.HasOne("ApplicationCore.Domain.Artiste", "Artiste")
                        .WithMany("Chansons")
                        .HasForeignKey("ArtisteFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artiste");
                });

            modelBuilder.Entity("ApplicationCore.Domain.Concert", b =>
                {
                    b.HasOne("ApplicationCore.Domain.Artiste", "Artiste")
                        .WithMany("Concerts")
                        .HasForeignKey("ArtisteFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApplicationCore.Domain.Festival", "Festival")
                        .WithMany("Concerts")
                        .HasForeignKey("Festivalfk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artiste");

                    b.Navigation("Festival");
                });

            modelBuilder.Entity("ApplicationCore.Domain.Artiste", b =>
                {
                    b.Navigation("Chansons");

                    b.Navigation("Concerts");
                });

            modelBuilder.Entity("ApplicationCore.Domain.Festival", b =>
                {
                    b.Navigation("Concerts");
                });
#pragma warning restore 612, 618
        }
    }
}
