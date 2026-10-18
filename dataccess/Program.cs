using Microsoft.EntityFrameworkCore;

namespace EF_project2
{
    internal class ApplictionDbcontecxt : DbContext
    {
        public DbSet<Prodacts> prodacts { get; set; }
        public DbSet<Store> stores { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Sale> sales { get; set; }
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            

        {
           
             base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=EIntegrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;");
        } 
       
        static void Main(string[] args)
        {
           

            Console.WriteLine("Hello, World");
        }
    }
}
