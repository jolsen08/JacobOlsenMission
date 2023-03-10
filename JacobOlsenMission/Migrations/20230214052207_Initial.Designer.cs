// <auto-generated />
using JacobOlsenMission.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JacobOlsenMission.Migrations
{
    [DbContext(typeof(MovieFormContext))]
    [Migration("20230214052207_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("JacobOlsenMission.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<short>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            Category = "Adventure",
                            Director = "David Soren",
                            Edited = false,
                            LentTo = "No one",
                            Notes = "Greatest Movie.",
                            Rating = "PG",
                            Title = "Turbo",
                            Year = (short)2013
                        },
                        new
                        {
                            MovieID = 2,
                            Category = "Adventure",
                            Director = "Joel Crawford",
                            Edited = false,
                            LentTo = "No one",
                            Notes = "Excellent Movie.",
                            Rating = "PG",
                            Title = "Puss In Boots: The Last Wish",
                            Year = (short)2022
                        },
                        new
                        {
                            MovieID = 3,
                            Category = "Sports/Drama",
                            Director = "David Soren",
                            Edited = false,
                            LentTo = "No one",
                            Notes = "Inspirational.",
                            Rating = "PG13",
                            Title = "Miracle On Ice",
                            Year = (short)1981
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
