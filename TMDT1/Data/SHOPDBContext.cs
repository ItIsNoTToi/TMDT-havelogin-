using Microsoft.EntityFrameworkCore;
using TMDT1.Models;

namespace TMDT1.Data
{
    public class SHOPDBContext : DbContext
    {
        public SHOPDBContext(DbContextOptions<SHOPDBContext> options) 
            : base(options)
        { }
        public DbSet<Carts> Carts { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductReviews> ProductReviews { get; set; }
        public DbSet<Categories> Categories { get; set; } 
        public DbSet<PaymentInformation> PaymentInformation { get; set; }
        public DbSet<Payment> Payment{ get; set; } 
        public DbSet<PaymentHistory> PaymentHistory { get; set; } 
        public DbSet<Whilelists> Whilelists { get; set; } 
    }
}
