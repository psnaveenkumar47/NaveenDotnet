using Microsoft.AspNetCore.Mvc;
using Product.DataAccessLayer;
using Product.Models;

namespace Product.Controllers
{
    [Route("api/[Controller]")]
    public class ProductController : Controller
    {
        private DataLayer dal;
        public ProductController(DataLayer dal)
        {
            this.dal = dal;
        }
        [HttpGet]
        public List<Products> Get()
        {
            return dal.products.ToList();
        }
        [HttpGet("{Id}")]
        public Products GetProduct(int id)
        {
            var product = dal.products.Where(x => x.Id == id).SingleOrDefault();
            return product;
        }
        [HttpPost]
        public IActionResult PostProduct([FromBody] Products product)
        {
            if (!ModelState.IsValid)
                return BadRequest("not valid model");
            dal.products.Add(product);
            dal.SaveChanges();
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await dal.products.FindAsync(id);
            if (product == null)
            {
                return NotFound();

            }
            dal.products.Remove(product);
            await dal.SaveChangesAsync();
            return NoContent();
        }
    }
}
