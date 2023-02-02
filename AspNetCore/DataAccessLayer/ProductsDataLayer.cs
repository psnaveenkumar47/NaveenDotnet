
using AspNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.DataAccessLayer
{
    public class ProductsDataLayer : DbContext
    {
        public ProductsDataLayer()
        {

        }
        public ProductsDataLayer(DbContextOptions<ProductsDataLayer> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}