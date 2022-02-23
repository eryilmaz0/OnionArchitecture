using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using OnionArchitectureDemo.Application.Abstracts.Repository;
using OnionArchitectureDemo.Application.Queries;
using OnionArchitectureDemo.Application.ResponseObjects;
using OnionArchitectureDemo.Application.ViewModels;
using OnionArchitectureDemo.Application.Wrapper;

namespace OnionArchitectureDemo.Application.Handlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ServiceResponse<GetProductByIdQueryResponse>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductByIdQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public Task<ServiceResponse<GetProductByIdQueryResponse>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = _productRepository.Get(x => x.Id == request.Id);

            if (product is null)
                return Task.FromResult(new ServiceResponse<GetProductByIdQueryResponse>()
                    { Id = Guid.NewGuid(), IsSuccess = false, Message = "Product Not Found." });

            var mappedProduct = _mapper.Map<GetProductViewModel>(product);
            return Task.FromResult(new ServiceResponse<GetProductByIdQueryResponse>(new(){Product = mappedProduct}){Id = Guid.NewGuid(), IsSuccess = true});
        }
    }
}