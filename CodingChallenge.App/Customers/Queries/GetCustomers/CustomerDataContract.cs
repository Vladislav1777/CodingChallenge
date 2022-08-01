using AutoMapper;
using CodingChallenge.App.Common.Mappings;
using CodingChallenge.DomainModel;

namespace CodingChallenge.App.Customers.Queries.GetCustomers
{
    public class CustomerDataContract : IMapWith<Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Customer, CustomerDataContract>()
                .ForMember(customerDto => customerDto.Id,
                    opt => opt.MapFrom(customer => customer.Id))
                .ForMember(customerDto => customerDto.Name,
                    opt => opt.MapFrom(customer => customer.Name));
        }
    }
}