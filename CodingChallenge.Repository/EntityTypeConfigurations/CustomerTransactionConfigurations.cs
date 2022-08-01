using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CodingChallenge.DomainModel;

namespace CodingChallenge.Repository.EntityTypeConfigurations
{
    internal class CustomerTransactionConfigurations : IEntityTypeConfiguration<CustomerTransaction>
    {
        public void Configure(EntityTypeBuilder<CustomerTransaction> builder)
        {
            builder.HasKey(customerTransaction => customerTransaction.Id);
            builder.HasIndex(customerTransaction => customerTransaction.Id).IsUnique();
            builder.Property(customerTransaction => customerTransaction.Id).ValueGeneratedOnAdd();
            builder.Property(customerTransaction => customerTransaction.CustomerId);
            builder.Property(customerTransaction => customerTransaction.Sum);
            builder.Property(customerTransaction => customerTransaction.CreatedDate);
        }
    }
}
