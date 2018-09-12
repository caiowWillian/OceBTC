using Microsoft.EntityFrameworkCore;
using Domain.Models;

namespace Data.Context
{
    public class OceannicContext : DbContext
    {
        public DbSet<Currency> Currency { get; set; }
        public DbSet<Deposit> Deposit { get; set; }
        public DbSet<Wallet> Wallet { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<ImgUser> ImgUser { get; set; }
        public DbSet<Transfer> Transfer { get; set; }
        public DbSet<TransactionType> TransactionType { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<TransactionAlter> TransactionAlter { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer("Server=LAPTOP-U845959I\\SQLEXPRESS;Database=OcennicPortal;Trusted_Connection=True;");
    }
}
