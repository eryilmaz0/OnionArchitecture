using System.Collections.Generic;
using OnionArchitectureDemo.Application.ViewModels;

namespace OnionArchitectureDemo.Application.ResponseObjects
{
    public class GetProductsQueryResponse
    {
        public ICollection<GetProductsViewModel> Products { get; set; }
    }
}