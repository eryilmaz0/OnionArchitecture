using MediatR;
using OnionArchitectureDemo.Application.Dto;
using OnionArchitectureDemo.Application.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OnionArchitectureDemo.Application.Queries
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, ServiceResponse<List<ListAllUsersDto>>>
    {
        public Task<ServiceResponse<List<ListAllUsersDto>>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            //List All Users From Db
            return Task.FromResult(new ServiceResponse<List<ListAllUsersDto>>(new()));
        }
    }
}
