using Microsoft.EntityFrameworkCore;
using System;
using Domain;

namespace EntityFrameWork
{
    public class ApplicationDbContext : DbContext
    {
        protected ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        DbSet<Account> Accounts { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Transaction> Transactions {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
            base.OnConfiguring(optionsBuilder);
        }
      /*  protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            
        }*/
    }
}
