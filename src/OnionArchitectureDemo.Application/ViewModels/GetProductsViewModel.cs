using System;

namespace OnionArchitectureDemo.Application.ViewModels
{
    public class GetProductsViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}