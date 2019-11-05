using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Galaxy.Product.Abstraction;
using Galaxy.Product.Abstraction.Models.Dtos;

namespace Galaxy.Product.WebHost.Controllers
{
    [ApiController]
    [Route("Product")]
    public class ProductController: ControllerBase
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }

        [Route("")]
        [HttpPost]
        public async Task<ProductDto> CreateProductAsync([FromBody]ProductDto product)
        {
            return await _productService.CreateAsync(product);
        }

        [Route("")]
        [HttpGet]
        public async Task<IEnumerable<ProductDto>> GetListAsync([FromQuery]ProductQueryDto query)
        {

            return await _productService.GetListAsync(query);
        }
    }
}
