using System.ComponentModel.DataAnnotations;

namespace ProductsAPIdemoV1.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public List<Product> Items { get; set; }

        public Cart() { 
        
            Items = new List<Product>();
        
        }

        public void AddToCart(Product product)
        {
            Items.Add(product);
        }
    }
}
