using Microsoft.EntityFrameworkCore;
using System;
using masteryBlog.Models;
using System.Collections.Generic;


namespace masteryBlog
{
    public class BlogContext: DbContext

    {
        public DbSet<BlogModel> Blog { get; set; }

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
                    BlogId = 1,
                    Title = "First Blog",
                    Content = "Here's some content about parenting",
                    Author = "Svetlana",
                    PublishDate = DateTime.Now,
                    Category = "Parenting",
                    Tag = "young parent life"
                },
                
                new BlogModel()
                {
                    BlogId = 2,
                    Title = "Second Blog",
                    Content = "Here's some more content about parenting",
                    Author = "Viktor",
                    PublishDate = DateTime.Now,
                    Category = "Parenting",
                    Tag = "young parent life"
               
                });
            base.OnModelCreating(modelBuilder);
        }

    }
}