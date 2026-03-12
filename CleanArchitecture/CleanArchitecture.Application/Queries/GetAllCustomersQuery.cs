using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Queries
{
    public record GetAllCustomersQuery() : IRequest<IEnumerable<CustomerEntity>>;
    public class GetAllCustomersQueryHandler(ICustomerRepository customerRepository)
        :IRequestHandler<GetAllCustomersQuery, IEnumerable<CustomerEntity>>
    {
        public async Task<IEnumerable<CustomerEntity>> Handle(GetAllCustomersQuery query, CancellationToken cancellationToken)
        {
            return await customerRepository.GetCustomers();
        }
    }
    
}
