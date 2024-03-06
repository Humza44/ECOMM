using ECOMM.Common.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOMM.Persistence.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<int> CreateProductAsync(ProductCreateModel model);
        Task<List<ProductListModel>> GetAllProductAsync();
    }
}
