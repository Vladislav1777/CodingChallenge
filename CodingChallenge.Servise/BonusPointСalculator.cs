using CodingChallenge.App.CustomerBonusPoin.Models;
using CodingChallenge.DomainModel;
using CodingChallenge.Servise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CodingChallenge.Servise
{
    internal class BonusPointСalculator : IBonusPointСalculator
    {
        public Task<CustomerBonusPoints> CalculateBonusPointsAsync(IList<CustomerTransaction> customerTransaction,
            CancellationToken cancellationToken)
        {
            var bonusPoints = customerTransaction.GroupBy(t => new { t.CreatedDate.Year, t.CreatedDate.Month })
               .Select(bp => new BonusPoint
               {
                   Month = bp.First().CreatedDate.Month,
                   Year = bp.First().CreatedDate.Year,
                   Points = bp.Sum(s => CalculateBonus(s))
               }).OrderBy(b => b.Year).ThenBy(b => b.Month).ToList();

            return Task.FromResult(new CustomerBonusPoints()
            {
                CustomerId = customerTransaction.First().CustomerId,
                TotalBonusPoints = bonusPoints.Sum(b => b.Points),
                BonusPoints = bonusPoints
            });
        }

        private decimal CalculateBonus(CustomerTransaction transaction)
        {
            return CalculateBonus(transaction.Sum);
        }

        private decimal CalculateBonus(decimal sum)
        {
            decimal result = 0;
            if (sum >= 51)
                result += sum - 50;
            if (sum >= 101)
                result += sum - 100;

            return result;
        }
    }
}
