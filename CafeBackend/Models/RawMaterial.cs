namespace CafeBackend.Models
{
    public class RawMaterial
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal StockQuantity { get; set; }
        public string Unit { get; set; } = string.Empty;

        public ICollection<ProductRecipe>? ProductRecipes { get; set; }
    }
}