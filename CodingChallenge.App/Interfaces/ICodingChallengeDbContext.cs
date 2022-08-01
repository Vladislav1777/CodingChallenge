using CodingChallenge.DomainModel;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace CodingChallenge.App.Interfaces
{
    public interface ICodingChallengeDbContext
    {
        DbSet<Customer> Customers { get; set; }
        DbSet<CustomerTransaction> CustomerTransactions { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
