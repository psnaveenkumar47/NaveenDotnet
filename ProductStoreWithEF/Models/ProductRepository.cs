using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProductStoreWithEF.Controllers;
using ProductStoreWithEF.DataAccessLayer;

namespace ProductStoreWithEF.Models
{
    public class ProductRepository : IProductRepository
    {
        ProductsDataLayer productsDal;
        private int _nextId = 1;
        public ProductRepository()
        {
            productsDal = new ProductsDataLayer();
        }
        public IEnumerable<Product> GetAll()
        {
            return productsDal.Products.ToList();
        }
        public Product Get(int id)
        {
            return productsDal.Products.ToList().Find(x => x.Id == id);
        }
        public Product AddProduct(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            productsDal.Products.Add(item);
            productsDal.SaveChanges();
            return item;
        }
        public bool Update(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            Product found = productsDal.Products.Find(item.Id);
            if (found == null)
            {
                return false;
            }
            found.Name = item.Name;
            found.Category = item.Category;
            found.Price = item.Price;
            productsDal.SaveChanges();
            return true;

        }
        public void Remove(int id)
        {
            Product found = productsDal.Products.Find(id);
            if (found == null)
            {
                throw new ArgumentNullException("item");
            }
            productsDal.Products.Remove(found);
            productsDal.SaveChanges();
        }

    }
}