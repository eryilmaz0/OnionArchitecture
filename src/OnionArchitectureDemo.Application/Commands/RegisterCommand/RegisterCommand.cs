using MediatR;
using OnionArchitectureDemo.Application.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureDemo.Application.Commands.RegisterCommand
{
    public class RegisterCommand : IRequest<ServiceResponse<Guid>>
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
