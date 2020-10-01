using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuoteProject.Models;

namespace QuoteProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Quote> Quote { get; set; }
        public DbSet<QuoteTag> QuoteTag { get; set; }
        public DbSet<Tag> Tag { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Tag>().HasData(new Tag { ID = 1, Name = "Me", Category = Category.prvni });
            builder.Entity<Tag>().HasData(new Tag { ID = 2, Name = "Me", Category = Category.druhy });
            builder.Entity<Tag>().HasData(new Tag { ID = 3, Name = "Me", Category = Category.treti });
            builder.Entity<Tag>().HasData(new Tag { ID = 4, Name = "Me", Category = Category.ctvrty });

            builder.Entity<Quote>().HasData(new Quote { ID = 1, Text = "Ahoj, jak se máš?" });
            builder.Entity<Quote>().HasData(new Quote { ID = 2, Text = "ajojk" });
            builder.Entity<Quote>().HasData(new Quote { ID = 3, Text = "asdasdasd" });
            builder.Entity<Quote>().HasData(new Quote { ID = 4, Text = "qweqweqeqw" });

            builder.Entity<QuoteTag>().HasData(new QuoteTag {Id = 1 ,QuoteId = 1, TagId = 1 });
            builder.Entity<QuoteTag>().HasData(new QuoteTag {Id = 2,QuoteId = 2, TagId = 2 });
            builder.Entity<QuoteTag>().HasData(new QuoteTag {Id = 3,QuoteId = 3, TagId = 3 });
            builder.Entity<QuoteTag>().HasData(new QuoteTag {Id = 4,QuoteId = 4, TagId = 4 });
        }
    }
}
