using System;
using MediatR;
using OnionArchitectureDemo.Application.Commands;
using OnionArchitectureDemo.Application.ResponseObjects;
using OnionArchitectureDemo.Application.Wrapper;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using OnionArchitectureDemo.Application.Abstracts.Repository;
using OnionArchitectureDemo.Domain.Entity;

namespace OnionArchitectureDemo.Application.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, ServiceResponse<UpdateProductCommandResponse>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public Task<ServiceResponse<UpdateProductCommandResponse>> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = _productRepository.Get(x => x.Id == request.Id);

            if(product is null)
                return Task.FromResult(new ServiceResponse<UpdateProductCommandResponse>(){Id = Guid.NewGuid(), IsSuccess = false, Message = "Product Not Found."});

            product = _mapper.Map<Product>(request);
            var result = _productRepository.Update(product);
            return Task.FromResult(new ServiceResponse<UpdateProductCommandResponse>() { Id = Guid.NewGuid(), IsSuccess = result });
        }
    }
}