using ECOMM.Common.Models;
using ECOMM.Common.Models.Product;
using ECOMM.Persistence.Repositories.ProductRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOMM.BusinessServices.Services.ProductService
{
    public class ProductService : BaseService, IProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository) 
        {
            _productRepository = productRepository;
        }

        /// <summary>
        /// Create product
        /// </summary>
        /// <param name="model">product create model</param>
        /// <returns>common response with last inserted id</returns>
        public async Task<Response> CreateProductAsync(ProductCreateModel model)
        {
            var id = await _productRepository.CreateProductAsync(model);

            return Success(id);
        }

        /// <summary>
        /// Fetch all records
        /// </summary>
        /// <returns>common response with list of products</returns>
        public async Task<Response> GetAllProductAsync()
        {
            var listOfObjects = await _productRepository.GetAllProductAsync();

            return Success(listOfObjects);
        }
    }
}
