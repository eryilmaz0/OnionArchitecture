using System;
using OnionArchitectureDemo.Domain.Common;

namespace OnionArchitectureDemo.Domain.Entity
{
    public class Product : EntityBase<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int Stock { get; set; }
    }
}