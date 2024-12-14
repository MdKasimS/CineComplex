using CineComplex.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineComplex.Classes.SQL
{
    public class CineComplexDb : DbContext
    {
        private readonly DbConnection _connection;

        public CineComplexDb(DbConnection connection)
        {
            _connection = connection;
        }

        public DbSet<User> Users
        {
            get; set;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_connection != null)
            {
                optionsBuilder.UseSqlite(_connection);
            }
            else
            {
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string dbPath = Path.Combine(basePath, "CineComplexDatabase.db");

                optionsBuilder.UseSqlite($"Data Source={dbPath}");
                //                .LogTo(Console.WriteLine, LogLevel.Information);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id); // Primary Key
                entity.Property(e => e.Username).IsRequired().HasMaxLength(50); // Name is required, max length 50 
                entity.Property(e => e.Email).IsRequired().HasMaxLength(50); // Email is required, max length 50 
                entity.Property(e => e.Contact).IsRequired().HasMaxLength(15); // Contact is required, max length 15
                entity.Property(e => e.Password).IsRequired().HasMaxLength(15);

                // Set unique constraints
                entity.HasIndex(e => e.Email).IsUnique();
                entity.HasIndex(e => e.Contact).IsUnique();
            });

        }
    }
}
