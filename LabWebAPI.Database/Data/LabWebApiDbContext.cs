﻿using LabWebAPI.Contracts.Data.Entities;
using LabWebAPI.Database.Data.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace LabWebAPI.Database.Data
{
    public class LabWebApiDbContext : IdentityDbContext<User>
    {
        public LabWebApiDbContext(DbContextOptions<LabWebApiDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
        public override DbSet<User> Users { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
    }
}