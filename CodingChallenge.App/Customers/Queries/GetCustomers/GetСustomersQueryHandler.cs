using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CodingChallenge.App.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CodingChallenge.App.Customers.Queries.GetCustomers
{
    internal class GetCustomersQueryHandler : IRequestHandler<GetCustomersQuery, CustomersVm>
    {
        private readonly ICodingChallengeDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetCustomersQueryHandler(ICodingChallengeDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task<CustomersVm> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
        {
            var customerQuery = await _dbContext.Customers
                .ProjectTo<CustomerDataContract>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
            return new CustomersVm { Customers = customerQuery };
        }
    }
}
