using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDBFirst
{
    internal class Program
    {
        static NorthwindEntities NWEntities = new NorthwindEntities();
        static IEnumerable<Product> beverages;
        static void AddProduct()
        {
            Product newproduct = new Product { ProductName = "new test product" };
            NWEntities.Products.Add(newproduct);
            NWEntities.SaveChanges();
            Console.WriteLine("Added a new product with name 'new test product'");
        }
        static void UpdateProduct()
        {
            Product bevl = beverages.ElementAtOrDefault(10);
            Console.WriteLine(bevl.ProductName);
            if(bevl!= null)
            {
                decimal newprice = (decimal)bevl.UnitPrice + 10.00m;
                Console.WriteLine("the price of {0} is{1}. update to {2} ",bevl.ProductName,bevl.UnitPrice,newprice);
                bevl.UnitPrice = newprice;
                NWEntities.SaveChanges();
            }
        }
        static void JoiningTwoTable()
        {
            var CategoryProducts = from c in NWEntities.Categories
                                   join p in NWEntities.Products
                                 on c.CategoryID equals p.CategoryID
                                 into productsByCategory
                                   select new
                                   {
                                       c.CategoryName,
                                       productCount = productsByCategory.Count()
                                   };
            foreach(var cp in CategoryProducts)
            {
                Console.WriteLine("there are {0} products in category {1}", cp.productCount, cp.CategoryName);
            }
            Console.WriteLine("**********************************");
            var currentProducts = from p in NWEntities.Products
                                  select p;
            foreach(var p in currentProducts)
            {
                Console.WriteLine("Product ID: {0} Product Name: {1}", p.ProductID, p.ProductName);
            }
        }
        static void DeleteProduct()
        {
             IQueryable<Product> ProductsToDelete = from p in NWEntities.Products where p.ProductName == "new test product" select p;
            
            if (ProductsToDelete.Count() > 0)
            {
                foreach (var p in ProductsToDelete)
                {
                    NWEntities.Entry(p).State=System.Data.Entity.EntityState.Deleted;
                    Console.WriteLine("Delete Product {0}",p.ProductID);
                }
                NWEntities.SaveChanges();

 

            }
        }
        static void Main()
        {
            SelectProducts();
            SelectOrder_Details();
            AddProduct();
            UpdateProduct();
            DeleteProduct();
            JoiningTwoTable();
        }

        private static void SelectProducts()
        {
            beverages = from p in NWEntities.Products where p.Category.CategoryName == "Beverages" orderby p.ProductName select p;
            foreach (Product prod in beverages)
            {
                Console.WriteLine(prod.ProductName);
            }
            Console.WriteLine("Total no of products :" + beverages.Count());
            Console.WriteLine("-------------");
        }

        private static void SelectOrder_Details()
        {
            var pro = from od in NWEntities.Order_Details where od.Product.ProductID == 11 select od;
            foreach (Order_Detail o in pro)
            {
                Console.WriteLine(o.OrderID);
            }
            Console.WriteLine("Total Number :" + pro.Count());
            Console.WriteLine("-------------");
        }
    }
}
