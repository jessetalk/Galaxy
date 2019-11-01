using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Galaxy.Product.Abstraction.Models.Dtos;

namespace Galaxy.Product.Abstraction
{
    public interface IProductService
    {
        Task<ProductDto> CreateAsync(ProductDto product);
        Task<IEnumerable<ProductDto>> GetListAsync(ProductQueryDto query);
    }
}
