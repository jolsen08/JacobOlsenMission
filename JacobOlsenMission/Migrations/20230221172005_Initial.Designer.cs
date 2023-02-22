﻿// <auto-generated />
using JacobOlsenMission.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JacobOlsenMission.Migrations
{
    [DbContext(typeof(MovieFormContext))]
    [Migration("20230221172005_Initial")]
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

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

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

                    b.HasIndex("CategoryId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            CategoryId = 1,
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
                            CategoryId = 2,
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
                            CategoryId = 3,
                            Director = "David Soren",
                            Edited = false,
                            LentTo = "No one",
                            Notes = "Inspirational.",
                            Rating = "PG13",
                            Title = "Miracle On Ice",
                            Year = (short)1981
                        });
                });

            modelBuilder.Entity("JacobOlsenMission.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categorys");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Action/Adventure"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Fantasy"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Horror"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Mystery"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Romance"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "Thriller"
                        },
                        new
                        {
                            CategoryId = 9,
                            CategoryName = "Crime"
                        },
                        new
                        {
                            CategoryId = 10,
                            CategoryName = "Musical"
                        },
                        new
                        {
                            CategoryId = 11,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryId = 12,
                            CategoryName = "Science Fiction"
                        },
                        new
                        {
                            CategoryId = 13,
                            CategoryName = "Other"
                        });
                });

            modelBuilder.Entity("JacobOlsenMission.Models.ApplicationResponse", b =>
                {
                    b.HasOne("JacobOlsenMission.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
