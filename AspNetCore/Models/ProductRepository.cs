
using Microsoft.EntityFrameworkCore;
using AspNetCore.DataAccessLayer;
using AspNetCore.Models;
namespace AspNetCore.Repository
{
    public class ProductRepository : IProductRepository
    {
        ProductsDataLayer DAL;
        //private int _nextId = 1;
        public ProductRepository(ProductsDataLayer _DAL)
        {
            DAL = _DAL;
        }
        public async Task<List<Product>> GetAll()
        {
            if (DAL != null)
            {
                return await DAL.Products.ToListAsync();
            }
            return null;
        }
        public async Task<int> AddProduct(Product prod)
        {
            if (DAL != null)
            {
                await DAL.Products.AddAsync(prod);
                await DAL.SaveChangesAsync();
                return prod.Id;
            }
            return 0;
        }
        public async Task<Product> GetProduct(int? prodid)
        {
            if (DAL != null)
            {
                return await (from u in DAL.Products where u.Id == prodid select u).FirstOrDefaultAsync();


            }
            return null;
        }
        public async Task<int> DeleteProduct(int? proid)
        {
            int result = 0;
            if (DAL != null)
            {
                var prod = await DAL.Products.FirstOrDefaultAsync(x => x.Id == proid);
                if (proid != null)
                {
                    Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<Product> entityEntry = DAL.Products.Remove(prod);
                    result = await DAL.SaveChangesAsync();
                }
                return result;
            }
            return result;
        }


    }
}
