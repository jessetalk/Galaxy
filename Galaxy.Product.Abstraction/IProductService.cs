using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Galaxy.Product.Abstraction.Models.Dtos;
using System.ServiceModel;

namespace Galaxy.Product.Abstraction
{
    [ServiceContract]
    public interface IProductService
    {
        Task<ProductDto> CreateAsync(ProductDto product);
        Task<IEnumerable<ProductDto>> GetListAsync(ProductQueryDto query);
    }
}
