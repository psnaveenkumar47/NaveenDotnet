using Microsoft.EntityFrameworkCore;
using Product.Models;
namespace Product.DataAccessLayer
{
    public class DataLayer : DbContext
    {


        public DataLayer(DbContextOptions<DataLayer> options) : base(options)
        {

        }
        public DbSet<Products> products { get; set; }


    }
}
