using System;
using MediatR;
using OnionArchitectureDemo.Application.ResponseObjects;
using OnionArchitectureDemo.Application.Wrapper;

namespace OnionArchitectureDemo.Application.Queries
{
    public class GetProductByIdQuery : IRequest<ServiceResponse<GetProductByIdQueryResponse>>
    {
        public Guid Id { get; set; }
    }
}