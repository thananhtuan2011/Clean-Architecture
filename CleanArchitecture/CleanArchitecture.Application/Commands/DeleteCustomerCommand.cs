using CleanArchitecture.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Commands
{
    public record DeleteCustomerCommand(Guid CustomerId) : IRequest<bool>;
    
    public class DeleteCustomerCommandHandler(ICustomerRepository customerRepository)
        :IRequestHandler<DeleteCustomerCommand, bool>
    {
        public async Task<bool> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            return await customerRepository.DeleteCustomerAsync(request.CustomerId);
        }
    }
    
}
