namespace CafeBackend.Models
{
    public class ProductRecipe
    {
        public int ProductId { get; set; }
        public int RawMaterialId { get; set; }
        public decimal RequiredAmount { get; set; }

        public Product? Product { get; set; }
        public RawMaterial? RawMaterial { get; set; }
    }
}