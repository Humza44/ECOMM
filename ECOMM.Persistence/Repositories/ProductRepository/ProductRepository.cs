using AutoMapper;
using ECOMM.Common.Models.Product;
using ECOMM.Common.Security;
using ECOMM.Persistence.Builder;
using ECOMM.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECOMM.Persistence.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDBContextBuilder _builder;
        private readonly IMapper _mapper;
        private readonly IConfiguration _config;
        private readonly IUserService _userService;

        public ProductRepository(IMapper mapper, IConfiguration config, IUserService userService)
        {
            _mapper = mapper;
            _config = config;
            _builder = new DBContextBuilder(config, userService);
        }

        /// <summary>
        /// Create product
        /// </summary>
        /// <param name="model">Create product model</param>
        /// <returns>inerted id</returns>
        public async Task<int> CreateProductAsync(ProductCreateModel model)
        {
            using (var context = _builder.CreateDbContext())
            {
                var product = _mapper.Map<Product>(model);
                await context.Products.AddAsync(product);
                context.SaveChanges();

                return product.ProductId;
            }
        }

        /// <summary>
        /// featch all products with no filters
        /// </summary>
        /// <returns>List products</returns>
        public async Task<List<ProductListModel>> GetAllProductAsync()
        {
            using (var context = _builder.CreateDbContext())
            {
                var agency = await context.Products.ToListAsync();

                return _mapper.Map<List<ProductListModel>>(agency);
            }
        }
    }
}
