
using Microsoft.EntityFrameworkCore;
using System;

namespace DataLayer
{
    public class BoatContext : DbContext
    {
       
       
        public DbSet<Users> Users { get; set; }                             // creating dbset properties
        public DbSet<BoatDetails> BoatDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if (!optionBuilder.IsConfigured)                                        // configuring connection with sql-server db
            {
                optionBuilder.UseSqlServer(@"Server =.\SQLEXPRESS; Database = BoatContext; Trusted_Connection = True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Users>(entity =>                                // validation for customer's unique EmailID
            {  
                entity.HasIndex(e => e.EmailID).IsUnique();
            });
         
        }
    }
}

