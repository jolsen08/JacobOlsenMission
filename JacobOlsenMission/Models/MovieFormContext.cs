using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JacobOlsenMission.Models
{
    public class MovieFormContext : DbContext
    {
        //Constructor
        public MovieFormContext (DbContextOptions<MovieFormContext> options) : base (options)
        {
            
        }

        public DbSet<ApplicationResponse> Responses { get; set; }
        public DbSet<Category> Categorys { get; set; }

        /*Here I am seeding the database. This data will appear in the first 3 rows in the database.*/
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Action/Adventure"},
                new Category {  CategoryId = 2, CategoryName = "Comedy"},
                new Category { CategoryId = 3, CategoryName = "Drama"}, 
                new Category { CategoryId = 4, CategoryName = "Fantasy"},
                new Category { CategoryId = 5, CategoryName = "Horror"},
                new Category { CategoryId = 6, CategoryName = "Mystery"},
                new Category { CategoryId = 7, CategoryName = "Romance" },
                new Category { CategoryId = 8, CategoryName = "Thriller" },
                new Category { CategoryId = 9, CategoryName = "Crime" },
                new Category { CategoryId = 10, CategoryName = "Musical" },
                new Category { CategoryId = 11, CategoryName = "Family" },
                new Category { CategoryId = 12, CategoryName = "Science Fiction" },
                new Category { CategoryId = 13, CategoryName = "Other" }
            );

            mb.Entity<ApplicationResponse>().HasData(
                /*Creating a new ApplicationResponse object for each row of seeded data.*/
                new ApplicationResponse
                {
                    MovieID = 1,
                    CategoryId = 1,
                    Title = "Turbo",
                    Year = 2013,
                    Director = "David Soren",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "No one",
                    Notes = "Greatest Movie."
                },
                new ApplicationResponse
                {
                    MovieID = 2,
                    CategoryId = 2,
                    Title = "Puss In Boots: The Last Wish",
                    Year = 2022,
                    Director = "Joel Crawford",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "No one",
                    Notes = "Excellent Movie."
                },
                new ApplicationResponse
                {
                    MovieID = 3,
                    CategoryId = 3,
                    Title = "Miracle On Ice",
                    Year = 1981,
                    Director = "David Soren",
                    Rating = "PG13",
                    Edited = false,
                    LentTo = "No one",
                    Notes = "Inspirational."
                }
            );
        }
    }
}
