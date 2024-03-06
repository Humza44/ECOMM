using AutoMapper;
using ECOMM.API.Models.Product;
using ECOMM.BusinessServices.Services.ProductService;
using ECOMM.Common.Constants;
using ECOMM.Common.Models.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ECOMM.API.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class ProductController : BaseController
    {

        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(
                                ILogger<ProductController> logger,
                                IProductService productService,
                                IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
            _productService = productService;
        }

        [HttpGet(Name = "GetAll")]
        public async Task<IActionResult> GetAllProducts()
        {
            var response = await _productService.GetAllProductAsync();
            return StatusCode(response);
        }

        [HttpPost(Name = "Create")]
        public async Task<IActionResult> CreateProduct(ProductCreateViewModel model)
        {
            var obj = _mapper.Map<ProductCreateModel>(model);
            var response = await _productService.CreateProductAsync(obj);
            return StatusCode(response);
        }
    }
}