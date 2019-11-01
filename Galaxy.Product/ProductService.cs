using Galaxy.Product.Abstraction;
using Galaxy.Product.Abstraction.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Galaxy.Product
{
    public class ProductService : IProductService
    {
        public Task<ProductDto> CreateAsync(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDto>> GetListAsync(ProductQueryDto query)
        {
            throw new NotImplementedException();
        }
    }
}
