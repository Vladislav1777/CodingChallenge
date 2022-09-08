using CodingChallenge.App.CustomerBonusPoin.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CodingChallenge.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class CustomerBonusPointController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerBonusPointController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<CustomerBonusPoints>> GetAll()
        {
            var query = new GetCustomerBonusPoinsQuery() {CustomerId =1 };
            var vm = await _mediator.Send(query);

            return Ok(vm);
        }
    }
}
