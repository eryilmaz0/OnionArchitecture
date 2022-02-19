using MediatR;
using OnionArchitectureDemo.Application.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OnionArchitectureDemo.Application.Commands.RegisterCommand
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, ServiceResponse<Guid>>
    {
        public Task<ServiceResponse<Guid>> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            //Create User
            return Task.FromResult(new ServiceResponse<Guid>(Guid.NewGuid()));
        }
    }
}
