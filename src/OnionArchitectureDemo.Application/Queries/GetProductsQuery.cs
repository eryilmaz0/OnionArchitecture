using MediatR;
using OnionArchitectureDemo.Application.ResponseObjects;
using OnionArchitectureDemo.Application.Wrapper;

namespace OnionArchitectureDemo.Application.Queries
{
    public class GetProductsQuery : IRequest<ServiceResponse<GetProductsQueryResponse>>
    {
        
    }
}