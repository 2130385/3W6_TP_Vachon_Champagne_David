﻿using Microsoft.EntityFrameworkCore;
using JuliePro.Models.Data;
using ZombieParty.Data;

namespace JuliePro.Models.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.GenerateData();
        }

        public DbSet<Speciality> Specialities { get; set; }
    }
}
