using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OnionArchitectureDemo.Application.Abstracts.Repository;
using OnionArchitectureDemo.Application.Commands;
using OnionArchitectureDemo.Application.ResponseObjects;
using OnionArchitectureDemo.Application.Wrapper;

namespace OnionArchitectureDemo.Application.Handlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, ServiceResponse<DeleteProductCommandResponse>>
    {
        private readonly IProductRepository _productRepository;

        public DeleteProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<ServiceResponse<DeleteProductCommandResponse>> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = _productRepository.Get(x => x.Id == request.Id);

            if (product is null)
                return Task.FromResult(new ServiceResponse<DeleteProductCommandResponse>()
                    { Id = Guid.NewGuid(), IsSuccess = false, Message = "Product Not Found." });

            var result = _productRepository.Delete(product);
            return Task.FromResult(new ServiceResponse<DeleteProductCommandResponse>(){Id = Guid.NewGuid(), IsSuccess =result});
        }
    }
}