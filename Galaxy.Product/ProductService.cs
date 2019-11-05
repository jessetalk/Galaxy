using Galaxy.Product.Abstraction;
using Galaxy.Product.Abstraction.Models.Dtos;
using Galaxy.Product.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Galaxy.Product
{
    public class ProductService : IProductService
    {
        private ProductContext context { get; set; }

        public ProductService(ProductContext context)
        {
            this.context = context;
        }

        public Task<ProductDto> CreateAsync(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductDto>> GetListAsync(ProductQueryDto query)
        {
            var entities = await this.context.Set<ProductEntity>().ToListAsync();
            var products = new List<ProductDto>();
            entities.ForEach(entity => products.Add(new ProductDto() { Id = entity.Id, Name = entity.Name }));
            return products;
        }
    }
}
