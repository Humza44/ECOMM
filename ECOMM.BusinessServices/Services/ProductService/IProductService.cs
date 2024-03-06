using ECOMM.Common.Models;
using ECOMM.Common.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOMM.BusinessServices.Services.ProductService
{
    public interface IProductService
    {
        Task<Response> CreateProductAsync(ProductCreateModel model);
        Task<Response> GetAllProductAsync();
    }
}
