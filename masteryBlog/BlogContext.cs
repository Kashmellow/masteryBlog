using Microsoft.EntityFrameworkCore;
using System;
using masteryBlog.Models;
using System.Collections.Generic;


namespace masteryBlog
{
    public class BlogContext: DbContext

    {
        public DbSet<BlogModel> Blog { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Blog;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogModel>().HasData(
                new BlogModel()
                {
                    Id = 1,
                    Title = "Pooping Faces",
                    Content = "Kids make the craziest faces when they poop",
                    Author = "lilmama1037",
                    PublishDate = DateTime.Now,
                    CategoryId = 1,
                    TagId = 1
                },
                
                new BlogModel()
                {
                    Id = 2,
                    Title = "Gettin sleep",
                    Content = "Tips on sleeping when your kids seem like they wont",
                    Author = "BigZaddy",
                    PublishDate = DateTime.Now,
                    CategoryId = 1,
                    TagId = 1
               
                });


            modelBuilder.Entity<Category>().HasData(
              new Category()
              {
                  CategoryId = 1,
                  CategoryName = "Young Parenting"
              });

            modelBuilder.Entity<Tag>().HasData(
            new Tag()
            {
                TagId = 1,
                TagName = "Recipes for Kids"
            });

            base.OnModelCreating(modelBuilder);
        }

    }
}