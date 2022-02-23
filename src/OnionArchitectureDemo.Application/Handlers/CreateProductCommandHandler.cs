
using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using OnionArchitectureDemo.Application.Abstracts.Repository;
using OnionArchitectureDemo.Application.Commands;
using OnionArchitectureDemo.Application.ResponseObjects;
using OnionArchitectureDemo.Application.Wrapper;
using OnionArchitectureDemo.Domain.Entity;

namespace OnionArchitectureDemo.Application.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ServiceResponse<CreateProductCommandResponse>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public Task<ServiceResponse<CreateProductCommandResponse>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            Product product = _mapper.Map<Product>(request);
            var result = _productRepository.Insert(product);
            return Task.FromResult(new ServiceResponse<CreateProductCommandResponse>(new()){Id = Guid.NewGuid(), IsSuccess = result});
        }
    }
}