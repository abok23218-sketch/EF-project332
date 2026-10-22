using EF_project2.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_project2
{
    internal class SalesContext : DbContext
    {
        public DbSet<Prodacts> Prodacts { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sale> Sales { get; set; }
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            

        {
           
             base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SalesDb;Integrated Security=True;TrustServerCertificate=True;");
        } 
            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sale>()
                .Property(s => s.Date)
                .HasDefaultValueSql("GETDATE()");
        }
       
        static void Main(string[] args)
        {
           

            Console.WriteLine("Hello, World");
        }
    }
}
