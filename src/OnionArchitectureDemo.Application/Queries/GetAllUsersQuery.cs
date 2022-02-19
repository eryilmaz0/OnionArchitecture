using MediatR;
using OnionArchitectureDemo.Application.Dto;
using OnionArchitectureDemo.Application.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureDemo.Application.Queries
{
    public class GetAllUsersQuery : IRequest<ServiceResponse<List<ListAllUsersDto>>>
    {
    }
}
