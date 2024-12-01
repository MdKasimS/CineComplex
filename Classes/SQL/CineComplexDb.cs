using CineComplex.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Classes.SQL
{
    public class CineComplexDb : DbContext
    {
        public DbSet<User> Users
        {
            get; set;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string dbPath = Path.Combine(basePath, "CineComplexDatabase.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Contact)
                .IsUnique(); 
            
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email).IsUnique(); 
        }
    }
}
