namespace ProductsAPIdemoV1.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string? Title { get; set; }
        public string? Category { get; set; }
        public DateTime CreatedDate { get; set; }
        public double Price { get; internal set; }
    }
}
