using CleanArchitecture.Application.Commands;
using CleanArchitecture.Application.Queries;
using CleanArchitecture.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController (ISender sender) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddCustomerAsync(
            [FromBody] CustomerEntity customer)
        {
            var result = await sender.Send(new AddCustomerCommand(customer));
            return Ok(result);
        }

        [HttpGet("customers")]
        public async Task<IActionResult> GetAllCustomersAsync()
        {
            var result = await sender.Send(new GetAllCustomersQuery());
            return Ok(result);
        }

        [HttpGet("customers/{customerId}")]
        public async Task<IActionResult> GetCustomerByIdAsync([FromRoute] Guid customerId)
        {
            var result = await sender.Send(new GetCustomerByIdQuery(customerId));
            return Ok(result);
        }

        [HttpPut("customers/{customerId}")]
        public async Task<IActionResult> UpdateCustomerAsync([FromRoute] Guid customerId, [FromBody] CustomerEntity customer)
        {
            var result = await sender.Send(new UpdateCustomerCommand(customerId, customer));
            return Ok(result);
        }

        [HttpDelete("customers/{customerId}")]
        public async Task<IActionResult> DeleteCustomerAsync([FromRoute] Guid customerId)
        {
            var result = await sender.Send(new DeleteCustomerCommand(customerId));
            return Ok(result);
        }
    }
}
