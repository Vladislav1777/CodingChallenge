using CodingChallenge.DomainModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodingChallenge.Repository.EntityTypeConfigurations
{
    public class CustomerConfigurations : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(customer => customer.Id);
            builder.HasIndex(customer => customer.Id).IsUnique();
            builder.Property(customer => customer.Id).ValueGeneratedOnAdd();
            builder.Property(customer => customer.Name).HasMaxLength(250);
        }
    }
}
