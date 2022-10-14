using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Model;
using Bogus;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class DataContext: IdentityDbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }

        public DbSet <BlogPost> BlogPosts { get; set; }
        public DbSet <Author> Authors { get; set; }
        public DbSet <RefreshToken> RefreshTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var AuthorId = 1;
            var BlogPostId = 1;

            var authorSeeder = new Faker<Author>()
                .RuleFor(a => a.Id, f => AuthorId++)
                .RuleFor(a => a.Name, f => f.Person.FullName);
                modelBuilder.Entity<Author>().HasData(authorSeeder.GenerateBetween(10, 10));

            var blogPostSeeder = new Faker<BlogPost>()
                .RuleFor(bp => bp.Id, f => BlogPostId++)
                .RuleFor(bp => bp.AuthorId, f => f.Random.Int(1, 10))
                .RuleFor(bp => bp.Title, f => f.Lorem.Sentence(4))
                .RuleFor(bp => bp.Body, f => f.Lorem.Sentences(10));
            modelBuilder.Entity<BlogPost>().HasData(blogPostSeeder.GenerateBetween(30, 30));

        }
    }
}