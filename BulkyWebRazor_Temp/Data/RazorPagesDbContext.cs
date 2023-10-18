﻿using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using BulkyWebRazor_Temp.Models;

namespace BulkyWebRazor_Temp.Data
{
    public class RazorPagesDbContext : DbContext
    {
        public RazorPagesDbContext(DbContextOptions<RazorPagesDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 4 }
                );
        }
    }
}
