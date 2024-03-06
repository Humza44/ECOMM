using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOMM.Persistence.Data
{
    public class Product : SystemModel
    {
        public int ProductId { get; set; }
        [MaxLength(255)]
        public string Name { get; set; } = null!;
        [MaxLength(1000)]
        public string Description { get; set; } = null!;
        [MaxLength(255)]
        public string SKU { get; set; } = null!;
        [MaxLength(1000)]
        public string Image { get; set; } = null!;
        [MaxLength(1000)]
        public string Thumbnail { get; set; } = null!;
    }
}
