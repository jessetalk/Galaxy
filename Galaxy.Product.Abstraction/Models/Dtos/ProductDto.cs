using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Galaxy.Product.Abstraction.Models.Dtos
{
    [DataContract]
    public class ProductDto
    {
        [DataMember(Order = 1)]
        public string Id { get; set; }

        [DataMember(Order = 2)]
        public string Name { get; set; }
    }
}
