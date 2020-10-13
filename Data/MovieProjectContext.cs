using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieProject.Models;

namespace MovieProject.Data
{
    public class MovieProjectContext : DbContext {
        public MovieProjectContext(DbContextOptions<MovieProjectContext> options)
            : base(options) {
        }

        public DbSet<MovieProject.Models.Movie> Movie { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            // modelBuilder.Entity<Students>().HasData();
            modelBuilder.Entity<Movie>().HasData(
                new Movie() { Id = 1, Name = "Capen Philips", Rate = 6 },
                new Movie() { Id = 2, Name = "Cast Away", Rate = 5 },
                 new Movie() { Id = 3, Name = " Dolemite is My Name", Rate = 5 },
                new Movie() { Id = 4, Name = "It Chapter Two", Rate = 8 },
                 new Movie() { Id = 5, Name = "Invisible Life", Rate = 7 },
                new Movie() { Id = 6, Name = " I Lost My Body", Rate = 8 },
                 new Movie() { Id = 7, Name = " American Factory", Rate = 6 },
                new Movie() { Id = 8, Name = " Plus One", Rate = 3 },
                 new Movie() { Id = 9, Name = "Crawl", Rate = 7 },

                new Movie() { Id = 10, Name = "Space fighter", Rate = 9 });



        }
    }
    }
