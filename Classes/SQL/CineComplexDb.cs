using CineComplex.Models;
using CineComplex.Services;
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

        /// <summary>
        /// Migration tools needs parameterless constructor because it instantiates while doing migration process
        /// dotnet ef migrations add CreateAuthTable
        /// dotnet ef database update
        /// </summary>
        public CineComplexDb() { }

        public CineComplexDb(DbConnection connection)
        {
            _connection = connection;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Auth> Auths { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<CinePlex> Cineplexes { get; set; }

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

                // Set unique constraints
                entity.HasIndex(e => e.Email).IsUnique();
                entity.HasIndex(e => e.Contact).IsUnique();
            });
        
            modelBuilder.Entity<Auth>(entity => 
            { 
                entity.HasKey(e => e.UserId); 
                entity.Property(e => e.Password).IsRequired();
                entity.Property(e => e.PrivilegeLevel).IsRequired();
            });

            modelBuilder.Entity<Session>(entity => 
            {
                entity.ToTable("Sessions");
                entity.HasKey(e => e.Id); 
                entity.Property(e => e.UserId).IsRequired(); 
                entity.Property(e => e.Token).IsRequired().HasMaxLength(256); 
                entity.Property(e => e.LoginTimestamp).IsRequired(); 
                entity.Property(e => e.ExpirationTimestamp).IsRequired(); 
                entity.HasIndex(e => e.Token).IsUnique(); 
                entity.HasOne<Auth>().WithMany().HasForeignKey(s => s.UserId); 
            });

            modelBuilder.Entity<BankAccount>(entity =>
            {
                entity.HasKey(e => e.Id); // Setting primary key

                entity.Property(e => e.AccountNumber)
                      .IsRequired()
                      .HasMaxLength(50); 

                entity.Property(e => e.GSTNumber)
                      .HasMaxLength(15); 

                entity.Property(e => e.BankName)
                      .IsRequired()
                      .HasMaxLength(100); 

                entity.Property(e => e.IFSCNumber)
                      .IsRequired()
                      .HasMaxLength(11); 

                entity.Property(e => e.AccountHolderName)
                      .IsRequired()
                      .HasMaxLength(100); 
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(e => e.Id); // Configure primary key

                entity.Property(e => e.Area)
                      .IsRequired()
                      .HasMaxLength(100); // Example configuration

                entity.Property(e => e.StreetName)
                      .IsRequired()
                      .HasMaxLength(100); // Example configuration

                entity.Property(e => e.City)
                      .IsRequired()
                      .HasMaxLength(50); // Example configuration

                entity.Property(e => e.State)
                      .IsRequired()
                      .HasMaxLength(50); // Example configuration

                entity.Property(e => e.ZipCode)
                      .IsRequired()
                      .HasMaxLength(10); // Example configuration
            });

            modelBuilder.Entity<CinePlex>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.FranchiseOperator).IsRequired().HasMaxLength(100);

                // Configure relationships
                entity.HasOne(e => e.UserAccount)
                      .WithOne()
                      .HasForeignKey<CinePlex>(e => e.Id);

                entity.HasOne(e => e.BankDetails)
                      .WithOne()
                      .HasForeignKey<CinePlex>(e => e.BankAccountId);

                entity.HasOne(e => e.AddressDetails)
                      .WithOne()
                      .HasForeignKey<CinePlex>(e => e.AddressId);
            });
        
        }

    }
}
