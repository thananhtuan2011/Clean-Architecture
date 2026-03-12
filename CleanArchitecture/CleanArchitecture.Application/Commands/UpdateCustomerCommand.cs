using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Commands
{
    public record UpdateCustomerCommand(Guid CustomerId, CustomerEntity Customer)
        : IRequest<CustomerEntity>;

    public class UpdateCustomerCommandHandler(ICustomerRepository customerRepository)
        :IRequestHandler<UpdateCustomerCommand, CustomerEntity>
    {
        public async Task<CustomerEntity> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            return await customerRepository.UpdateCustomerByAsync(request.CustomerId, request.Customer);
        }
    }
    
}
