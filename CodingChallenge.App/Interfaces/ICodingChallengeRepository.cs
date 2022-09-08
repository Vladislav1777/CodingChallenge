using CodingChallenge.App.CustomerBonusPoin.Queries.GetCustomerBonusPoins;
using CodingChallenge.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodingChallenge.App.Interfaces
{
    public interface ICodingChallengeRepository
    {
        public Task<IList<CustomerTransaction>> GetCustomerTransactionsAsync(int IdCustomer, CancellationToken cancellationToken);
    }
}
