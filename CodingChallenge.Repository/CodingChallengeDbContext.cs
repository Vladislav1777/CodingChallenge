using CodingChallenge.DomainModel;
using CodingChallenge.Repository.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;
using CodingChallenge.App.Interfaces;

namespace CodingChallenge.Repository
{
    public class CodingChallengeDbContext : DbContext, ICodingChallengeDbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerTransaction> CustomerTransactions { get; set; }

        public CodingChallengeDbContext(DbContextOptions<CodingChallengeDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CustomerConfigurations());
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new CustomerTransactionConfigurations());
            base.OnModelCreating(builder);
        }
    }
}
