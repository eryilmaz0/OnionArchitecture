using MediatR;
using OnionArchitectureDemo.Application.ResponseObjects;
using OnionArchitectureDemo.Application.Wrapper;

namespace OnionArchitectureDemo.Application.Commands
{
    public class CreateProductCommand : IRequest<ServiceResponse<CreateProductCommandResponse>>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int Stock { get; set; }
    }
}