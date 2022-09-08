using AutoMapper;
using CodingChallenge.App.CustomerBonusPoin.Models;
using CodingChallenge.App.Interfaces;
using CodingChallenge.Servise.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CodingChallenge.App.CustomerBonusPoin.Queries.GetCustomerBonusPoins
{
    internal class GetCustomerBonusPoinsQueryHandler : IRequestHandler<GetCustomerBonusPoinsQuery, CustomerBonusPoints>
    {
        private readonly IBonusPointСalculator _bonusPointСalculator;
        ICodingChallengeRepository _repository;

        public GetCustomerBonusPoinsQueryHandler(IBonusPointСalculator bonusPointСalculator
            ,ICodingChallengeRepository repository)
        {
            _bonusPointСalculator = bonusPointСalculator;
            _repository = repository;
        }

        public async Task<CustomerBonusPoints> Handle(GetCustomerBonusPoinsQuery request, CancellationToken cancellationToken)
        {
            var customerTransactions = await _repository.GetCustomerTransactionsAsync(request.CustomerId, cancellationToken);
            return await _bonusPointСalculator.CalculateBonusPointsAsync(customerTransactions, cancellationToken);
        }
    }
}
