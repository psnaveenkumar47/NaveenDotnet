using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProductStoreWithEF.Models;


namespace ProductStoreWithEF.Controllers
{
    public class ProductController : ApiController
    {
        static readonly IProductRepository repository = new ProductRepository();
        public IEnumerable<Product> GetAllProducts()
        {
            return repository.GetAll();
        }

        public Product GetProduct(int id)
        {
            Product item = repository.Get(id);
            if (item == null)
            {

                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }
            return item;
        }

        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            return repository.GetAll().Where(p => string.Equals(p.Category, category, StringComparison.OrdinalIgnoreCase));
        }
        public HttpResponseMessage PostProduct(Product item)
        {
            item = repository.AddProduct(item);
            var response = Request.CreateResponse<Product>(HttpStatusCode.Created, item);
            string uri = Url.Link("DefaultApi", new { id = item.Id });
            response.Headers.Location = new Uri(uri);
            return response;

        }
        public void PutProduct(int id, Product product)
        {

            product.Id = id;

            if (repository.Update(product))
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
            }
        }
        public void DeleteProduct(int id)
        {
            Product item = repository.Get(id);

            if (item == null)
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);

            }
            repository.Remove(id);

        }
    }
}
