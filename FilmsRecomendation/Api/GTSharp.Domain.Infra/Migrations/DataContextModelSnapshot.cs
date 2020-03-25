﻿// <auto-generated />
using System;
using GTSharp.Domain.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GTSharp.Domain.Infra.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GTSharp.Domain.Entities.Genre", b =>
                {
                    b.Property<int>("IdGenre")
                        .HasColumnType("int");

                    b.Property<int?>("MovieIdMovie")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.HasKey("IdGenre");

                    b.HasIndex("MovieIdMovie");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("GTSharp.Domain.Entities.Movie", b =>
                {
                    b.Property<int>("IdMovie")
                        .HasColumnType("int");

                    b.Property<decimal>("Budget")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("OriginalTitle")
                        .HasColumnType("nvarchar(400)")
                        .HasMaxLength(400);

                    b.Property<string>("Overview")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Popularity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PosterPath")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("VoteAverage")
                        .HasColumnType("float");

                    b.Property<double>("VoteCount")
                        .HasColumnType("float");

                    b.HasKey("IdMovie");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("GTSharp.Domain.Entities.Genre", b =>
                {
                    b.HasOne("GTSharp.Domain.Entities.Movie", "Movie")
                        .WithMany("Genres")
                        .HasForeignKey("MovieIdMovie");
                });
#pragma warning restore 612, 618
        }
    }
}
