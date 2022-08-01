using MediatR;

namespace CodingChallenge.App.Customers.Queries.GetCustomers
{
    public class GetCustomersQuery : IRequest<CustomersVm>
    {
        public int Id { get; set; }
    }
}
