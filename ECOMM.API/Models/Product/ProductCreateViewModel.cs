using System.ComponentModel.DataAnnotations;

namespace ECOMM.API.Models.Product
{
    public class ProductCreateViewModel
    {
        [Required(ErrorMessage = "Product name is required.")]
        [Display(Name = "Product Name")]
        public string Name { get; set; } = null!;
        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; } = null!;
        public string SKU { get; set; } = null!;
        public string Image { get; set; } = null!;
        public string Thumbnail { get; set; } = null!;
    }
}
