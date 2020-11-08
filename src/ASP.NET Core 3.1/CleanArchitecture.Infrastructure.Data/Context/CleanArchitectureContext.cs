using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
namespace CleanArchitecture.Infrastructure.Data.Context
{
    public class CleanArchitectureContext : DbContext
    {
        private const string LocalConn = "Server=(localdb)\\MSSQLLocalDB;Database=CleanArchitectureDb;Trusted_Connection=True;";
        
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(LocalConn);
        }
    }
}