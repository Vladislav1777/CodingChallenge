using CodingChallenge.App.CustomerBonusPoin.Models;
using CodingChallenge.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodingChallenge.Servise.Interfaces
{
    public interface IBonusPointСalculator
    {
        public Task<CustomerBonusPoints> CalculateBonusPointsAsync(IList<CustomerTransaction> customerTransaction, CancellationToken cancellationToken);
    }
}
