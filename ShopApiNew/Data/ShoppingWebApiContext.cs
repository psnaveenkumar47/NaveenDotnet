using Microsoft.EntityFrameworkCore;

namespace ShopApiNew.Data
{
    public class ShopApiNewContext : DbContext
    {
        public ShopApiNewContext (DbContextOptions<ShopApiNewContext> options)
            : base(options)
        {
        }

        public DbSet<ShopApiNew.Models.User> User { get; set; }

        public DbSet<ShopApiNew.Models.Product> Product { get; set; }

        public DbSet<ShopApiNew.Models.Cart> Cart { get; set; }

        public DbSet<ShopApiNew.Models.Order> Order { get; set; }

        public DbSet<ShopApiNew.Models.Card> Card { get; set; }
    }
}
