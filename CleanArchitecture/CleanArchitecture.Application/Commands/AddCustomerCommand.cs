using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Commands
{
    public record AddCustomerCommand(CustomerEntity Customer) : IRequest<CustomerEntity>;

    public class AddCustomerCommandHandler(ICustomerRepository customerRepository)
        :IRequestHandler<AddCustomerCommand, CustomerEntity>
    {
        public async Task<CustomerEntity> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            return await customerRepository.AddCustomerByIdAsync(request.Customer);
        }
    }

}
