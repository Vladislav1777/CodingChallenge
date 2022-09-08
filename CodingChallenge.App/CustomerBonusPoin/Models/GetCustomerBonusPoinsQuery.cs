using MediatR;

namespace CodingChallenge.App.CustomerBonusPoin.Models
{
    public class GetCustomerBonusPoinsQuery: IRequest<CustomerBonusPoints>
    {
        public int CustomerId { get; set; }
    }
}
