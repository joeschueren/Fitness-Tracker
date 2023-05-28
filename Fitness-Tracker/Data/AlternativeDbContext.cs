﻿using Microsoft.EntityFrameworkCore;
using Fitness_Tracker.Models;

namespace Fitness_Tracker.Data
{
    public class AlternativeDbContext : DbContext
    {
        public AlternativeDbContext(DbContextOptions<AlternativeDbContext> options) : base(options) 
        { 
        }

        public DbSet<Day> Days { get; set; }
    }
}
