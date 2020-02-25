using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Galaxy.Product.Abstraction.Models.Dtos;
using System.ServiceModel;
using Volo.Abp.Modularity;
using Volo.Abp.Application.Services;

namespace Galaxy.Product.Abstraction
{
    public interface IProductService: IApplicationService
    {
        Task<ProductDto> CreateAsync(ProductDto product);
        Task<IEnumerable<ProductDto>> GetListAsync(ProductQueryDto query);
    }
}
