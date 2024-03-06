namespace ECOMM.API.Models.Product
{
    public class ProductListViewModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string SKU { get; set; } = null!;
        public string Image { get; set; } = null!;
        public string Thumbnail { get; set; } = null!;
    }
}
