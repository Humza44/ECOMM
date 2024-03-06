using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOMM.Common.Models.Product
{
    public class ProductListModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string SKU { get; set; } = null!;
        public string Image { get; set; } = null!;
        public string Thumbnail { get; set; } = null!;
    }
}
