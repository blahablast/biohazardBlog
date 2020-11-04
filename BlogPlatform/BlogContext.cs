using blog_template_practice.Models;
using Microsoft.Data.SqlClient.DataClassification;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_template_practice
{
    public class BlogContext : DbContext
    {
        public DbSet<Content> Contents { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BlogDB_templatetest;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    Name = "Traversing Spencer Mansion",
                    Image = "spencer.jpg"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Dealing with Zombies and how to kill them!",
                    Image = "leon.jpg"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Finding and destroying the Arklay Laboratory",
                    Image = "lab.jpg"
                }

                );

            
            modelBuilder.Entity<Content>().HasData(
                new Content()
                {
                    Id = 1,
                    Title = "This Mansion is a real downer",
                    Body = "Thanks to Brad and his awful piloting skills, we have crashed and stuck in this creepy mansion! Thank God we have Wesker here to take care of us!",
                    Author = "Jill Valentine",
                    PublishDate = DateTime.Parse(DateTime.Today.ToString()),
                    CategoryId = 1

                },
                new Content()
                {
                    Id = 2,
                    Title = "Is it just me or are all these 'residents evil...'",
                    Body = "I open a door, Zombie! Go down a hall, Zombie! Check out the dormitory, a giant plant trying to eat Jill! Always something else with this place!",
                    Author = "Barry Burton",
                    PublishDate = DateTime.Parse(DateTime.Today.ToString()),
                    CategoryId = 2
                },
                new Content()
                {
                    Id = 3,
                    Title = "So I drained a fountain and found a Laboratory!",
                    Body = "I was stuck, with nowhere to go and decided to insert a couple of disks (that were hidden all too well...) into statues and the next thing I know, I'm decending into an underground laboratory!",
                    Author = "Chris Redfield",
                    PublishDate = DateTime.Parse(DateTime.Today.ToString()),
                    CategoryId = 3
                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
