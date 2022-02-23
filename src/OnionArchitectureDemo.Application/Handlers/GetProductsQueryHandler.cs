using System;
using System.Collections.Generic;
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
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, ServiceResponse<GetProductsQueryResponse>>
    {
        private IProductRepository _productRepository;
        private IMapper _mapper;

        public GetProductsQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public Task<ServiceResponse<GetProductsQueryResponse>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var products = _productRepository.GetAll();
            var mappedProducts = _mapper.Map<List<GetProductsViewModel>>(products);

            return Task.FromResult(new ServiceResponse<GetProductsQueryResponse>() { Id = Guid.NewGuid(), IsSuccess = true, Value = new() { Products = mappedProducts } });

        }
    }
}