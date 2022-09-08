using Microsoft.AspNetCore.Mvc;
using MediatR;
using CodingChallenge.App.Customers.Queries.GetCustomers;
using System.Threading.Tasks;

namespace CodingChallenge.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<CustomersVm>> GetAll()
        {           
            var vm = await _mediator.Send(new GetCustomersQuery());

            return Ok(vm);
        }
    }
}
