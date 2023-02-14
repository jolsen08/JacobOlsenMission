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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    MovieID = 1,
                    Category = "Adventure",
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
                    Category = "Adventure",
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
                    Category = "Sports/Drama",
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
