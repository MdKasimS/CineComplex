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
        public DbSet<UserProfile> UserProfiles { get; set; }

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

            modelBuilder.Entity<UserProfile>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.HasOne(up => up.UserAccount)
                      .WithOne()
                      .HasForeignKey<UserProfile>(up => up.UserId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(up => up.AddressDetails)
                      .WithOne()
                      .HasForeignKey<UserProfile>(up => up.AddressId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(up => up.BankDetails)
                  .WithOne()
                  .HasForeignKey<UserProfile>(up => up.BankAccountId)
                  .OnDelete(DeleteBehavior.Restrict);

                //What if need only single association but UI can suggest multiple.
                entity.HasOne(up => up.BankDetails)
                      .WithMany()
                      .HasForeignKey(up => up.BankAccountId)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Auth>(entity => 
            { 
                entity.HasKey(e => e.UserId); 
                entity.Property(e => e.Password).IsRequired();
                entity.Property(e => e.PrivilegeLevel).IsRequired();
            });

            modelBuilder.Entity<Session>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Token).IsRequired().HasMaxLength(200);
                entity.Property(e => e.LoginTimestamp).IsRequired();
                entity.Property(e => e.ExpirationTimestamp).IsRequired();

                entity.HasOne(s => s.User)
                      .WithMany()
                      .HasForeignKey(s => s.UserId)
                      .OnDelete(DeleteBehavior.Cascade);
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

                entity.Property(e => e.Country)
                      .IsRequired()
                      .HasMaxLength(15); // Example configuration

                entity.Property(e => e.PinCode)
                      .IsRequired()
                      .HasMaxLength(10); // Example configuration
            });

            modelBuilder.Entity<CinePlex>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.FranchiseOperator)
                      .IsRequired().HasMaxLength(100);

                entity.Property(e => e.NumberOfTheatres).IsRequired();

                // Configure relationships
                entity.HasOne(e => e.Profile)
                      .WithOne()
                      .HasForeignKey<CinePlex>(e => e.UserProfileId)
                      .OnDelete(DeleteBehavior.Cascade);

            });
        
        }

    }
}
