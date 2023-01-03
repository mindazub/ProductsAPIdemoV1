using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductsAPIdemoV1.Data;
using ProductsAPIdemoV1.Models;

namespace ProductsAPIdemoV1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _dbContext;

        public ProductController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            //return  await _dbContext.Products.ToListAsync();
            Product[] products = {
    new Product { Id=1, Title = "Product 51", Price = 0.99, Category = "Category 1" },
    new Product { Id=2, Title = "Product 82", Price = 15.99, Category = "Category 2" },
    new Product { Id=3, Title = "Product 38", Price = 29.99, Category = "Category 3" },
    new Product { Id=4, Title = "Product 44", Price = 69.69, Category = "Category 4" }
};

            return products;


        }
    }
}
