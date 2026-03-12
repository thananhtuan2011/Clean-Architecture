using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<CustomerEntity>> GetCustomers();
        Task<CustomerEntity> GetCustomerByIdAsync(Guid id);
        Task<CustomerEntity> AddCustomerByIdAsync(CustomerEntity entity);
        Task<CustomerEntity> UpdateCustomerByAsync(Guid customerId, CustomerEntity entity);
        Task<bool> DeleteCustomerAsync(Guid customerId);
    }
}
