using Galaxy.Product.Abstraction;
using Galaxy.Product.Abstraction.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Galaxy.Product
{
    public class ProductService : IProductService
    {
        private List<ProductDto> products { get; set; }

        public ProductService()
        {
            products = new List<ProductDto>();
            products.Add(new ProductDto() { Id = "1", Name = "Apple" });
            products.Add(new ProductDto() { Id = "2", Name = "Orange" });
        }

        public Task<ProductDto> CreateAsync(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDto>> GetListAsync(ProductQueryDto query)
        {
            var task = Task.Run(() =>
            {
                Thread.Sleep(100);
                return products.AsEnumerable();
            });
            return task;
        }
    }
}
