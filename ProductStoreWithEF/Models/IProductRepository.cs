using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductStoreWithEF.Models
{
    interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product AddProduct(Product item);
        void Remove(int id);
        bool Update(Product item);
        Product Get(int id);
    }
}