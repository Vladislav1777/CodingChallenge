using CodingChallenge.App.Interfaces;
using CodingChallenge.DomainModel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CodingChallenge.Repository
{
    internal class CodingChallengeRepository : ICodingChallengeRepository
    {
        private readonly ICodingChallengeDbContext _dbContext;    

        public CodingChallengeRepository(ICodingChallengeDbContext dbContext)
        {
            _dbContext = dbContext;           
        }

        public async Task<IList<CustomerTransaction>> GetCustomerTransactionsAsync(int CustomerId, CancellationToken cancellationToken)
        {
            return  await _dbContext.CustomerTransactions
                .Where(customer => customer.CustomerId == CustomerId)                
                .ToListAsync(cancellationToken);
        }
    }
}
