using System;
using MediatR;
using OnionArchitectureDemo.Application.ResponseObjects;
using OnionArchitectureDemo.Application.Wrapper;

namespace OnionArchitectureDemo.Application.Commands
{
    public class DeleteProductCommand : IRequest<ServiceResponse<DeleteProductCommandResponse>>
    {
        public Guid Id { get; set; }
    }
}