using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Galaxy.Product.Entity
{
    [Table("Product")]
    public class ProductEntity
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
