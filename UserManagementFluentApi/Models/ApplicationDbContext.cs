using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagementFluentApi.Entities;

namespace UserManagementFluentApi.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserPassword> UserPasswords { get; set; }
        public DbSet<UserIdentityCard> UserIdentityCards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=UserManagement;Trusted_Connection=True;");
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=UserManagement;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>().
            //    HasOne(u => u.UserIdentityCard)
            //   .WithOne(g => g.User)
            //   .HasForeignKey<UserIdentityCard>(s => s.UserIdentityCardId);

            ////modelBuilder.Entity<City>()
            ////       .HasOne(e => e.Country)
            ////       .WithMany(e => e.City)
            ////       .HasForeignKey(e => e.FKCountry)
            ////       .OnDelete(DeleteBehavior.Cascade); ;

            //modelBuilder.Entity<UserPassword>()
            //       .HasOne(e => e.User)
            //       .WithMany(e => e.UserPasswords)
            //       .HasForeignKey(e => e.UserPasswordId)
            //       .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(r => r.Roles)
                .WithOne(u => u.User)
                .HasForeignKey(r => r.UserRoleId)
                .OnDelete(DeleteBehavior.Restrict);
            //modelBuilder.Entity<User>()
            //    .HasMany(p => p.UserPasswords)
            //    .WithOne(u => u.User)
            //    .HasForeignKey(p => p.UserPasswordId)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
