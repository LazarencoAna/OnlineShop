using Microsoft.AspNetCore.Mvc;
using OnlineShop.DAL.Context;
using OnlineShop.DAL.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private ShopDbContext _shopDbContext;

        public ProductsController(ShopDbContext shopDbContext)
        {
            _shopDbContext = shopDbContext;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            var products = _shopDbContext.Products.Where(i => i.Price > 0);
            return products;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _shopDbContext.Products.FirstOrDefault(i => i.DeliveryTypeId == id);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] Product value)
        {
            _shopDbContext.Products.Add(value);
            _shopDbContext.SaveChanges();
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product value)
        {
            _shopDbContext.Products.Update(value);
            _shopDbContext.SaveChanges();
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var productToDelete = _shopDbContext.Products.FirstOrDefault(i => i.ProductId == id);
            if (productToDelete != null)
            {
                //delete images
                productToDelete.IsDeleted = true;
                _shopDbContext.Products.Update(productToDelete);
                _shopDbContext.SaveChanges();
            }
        }
    }
}
