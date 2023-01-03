using Microsoft.EntityFrameworkCore;
using ProductsAPIdemoV1.Models;

namespace ProductsAPIdemoV1.Data
{
    public class DataContext : DbContext
    {
        private DbSet<Cart> carts;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public DataContext(DbContextOptions<DataContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {

        }

        public DbSet<Product> Products { get; set; }

        public DataContext(DbSet<Product> products) => Products = products;

        public DbSet<Cart> Carts { get => carts; set => carts = value; }
        public object Movies { get; internal set; }

        public DataContext(DbSet<Cart> carts) => Carts = carts;
    }
}
