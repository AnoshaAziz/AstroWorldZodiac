using System;
using System.Collections.Generic;
using System.Text;
using AstroWorldZodiac.Models;
using AstroWorldZodiac.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AstroWorldZodiac.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<GemStone>().HasData(
                new GemStone() { Id = 1, Name = "Ruby", Description = "A good building stone should have compact fine crystalline structure free from cavities, cracks or patches of soft or loose material. The stones with such texture are strong and durable." },
                new GemStone() { Id = 2, Name = "Pearl", Description = "A good building stone should have compact fine crystalline structure free from cavities, cracks or patches of soft or loose material. The stones with such texture are strong and durable." },
                new GemStone() { Id = 3, Name = "Red Coral", Description = "A good building stone should have compact fine crystalline structure free from cavities, cracks or patches of soft or loose material. The stones with such texture are strong and durable." },
                new GemStone() { Id = 4, Name = "Emerald", Description = "A good building stone should have compact fine crystalline structure free from cavities, cracks or patches of soft or loose material. The stones with such texture are strong and durable." },
                new GemStone() { Id = 5, Name = "Topaz", Description = "A good building stone should have compact fine crystalline structure free from cavities, cracks or patches of soft or loose material. The stones with such texture are strong and durable." },
                new GemStone() { Id = 6, Name = "Diamond", Description = "A good building stone should have compact fine crystalline structure free from cavities, cracks or patches of soft or loose material. The stones with such texture are strong and durable." },
                new GemStone() { Id = 7, Name = "Yellow Sapphire", Description = "A good building stone should have compact fine crystalline structure free from cavities, cracks or patches of soft or loose material. The stones with such texture are strong and durable." },
                new GemStone() { Id = 8, Name = "Blue Sapphire", Description = "A good building stone should have compact fine crystalline structure free from cavities, cracks or patches of soft or loose material. The stones with such texture are strong and durable." },
                new GemStone() { Id = 9, Name = "Cat's Eyes", Description = "A good building stone should have compact fine crystalline structure free from cavities, cracks or patches of soft or loose material. The stones with such texture are strong and durable." }
                );
               
            base.OnModelCreating(builder);
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<GemStone> GemStone { get; set; }

    }
}
