using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetCore.Models
{
    public interface IProductRepository
    {
        Task<int> AddProduct(Product prod);
        Task<List<Product>> GetAll();


        Task<int> DeleteProduct(int? id);
        Task<Product> GetProduct(int? id);
    }
}