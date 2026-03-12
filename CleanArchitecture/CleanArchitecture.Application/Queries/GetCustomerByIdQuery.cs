using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Queries
{
    public record GetCustomerByIdQuery(Guid customerId) : IRequest<CustomerEntity>;
    
    public class GetCustomerByIdQueryHandler(ICustomerRepository customerRepository)
        :IRequestHandler<GetCustomerByIdQuery, CustomerEntity>
    {
        public async Task<CustomerEntity> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            return await customerRepository.GetCustomerByIdAsync(request.customerId);
        }
    }
}
