namespace CafeBackend.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool IsActive { get; set; }

        public Category? Category { get; set; }
        public ICollection<ProductRecipe>? ProductRecipes { get; set; }
    }
}