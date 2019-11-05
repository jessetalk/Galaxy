using Galaxy.Product.Abstraction.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Galaxy.Order.Abstraction.Models.Dtos
{
    public class OrderDto
    {
        public string Id { get; set; }

        public string OrderNo { get; set; }

        public IEnumerable<ProductDto> ProductItems { get; set; }
    }
}
